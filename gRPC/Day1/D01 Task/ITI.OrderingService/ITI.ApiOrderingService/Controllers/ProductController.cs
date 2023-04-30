using Grpc.Net.Client;
using ITI.GrpcInventoryService.Server.Protos;
using static ITI.GrpcInventoryService.Server.Protos.InventoryProductService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Google.Protobuf.WellKnownTypes;
using ITI.ApiOrderingService.Model;
using ITI.GrpcPaymentService.Server.Protos;
using static ITI.GrpcPaymentService.Server.Protos.Payment;

namespace ITI.ApiOrderingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> logger;

        public ProductController(ILogger<ProductController> logger)
        {
            this.logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> AddOrder([FromBody] Order order)
        {
            order.OrderId =  ModelLists.Orders.Max(o => o.OrderId) + 1;

            ModelLists.CalculateBalance(order);

            #region Inventory
            var channel = GrpcChannel.ForAddress("https://localhost:7042");
            var client = new InventoryProductServiceClient(channel);

            foreach (var item in order.ProductsIds)
            {
                var request = new ProductReqeust { ProductId = item };
                var response = await client.CheckAvailabilityAsync(request);

                if (!response.InStock)
                {
                    // return an error response if the quantity is not available
                    return BadRequest($"Product Id : {item} is not available in the requested quantity.");
                }
            }
            #endregion

            #region PaymentService
            var channel2 = GrpcChannel.ForAddress("https://localhost:7185");
            var client2 = new PaymentClient(channel2);
            var request2 = new PaymentRequest { ClientId = order.clientId, Balance = order.Balance };
            var response2 = await client2.CheckBalanceAsync(request2);
            
            // Check if the Balance is available
            if (!response2.Success)
            {
                return BadRequest("Balance Of Selected User is not enough");
            }
            #endregion



            ModelLists.Orders.Add(order);
            return Ok("Order added successfully.");
        }

    }
}
