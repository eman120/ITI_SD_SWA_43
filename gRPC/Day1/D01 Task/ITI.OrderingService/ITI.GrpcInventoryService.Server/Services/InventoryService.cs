using Grpc.Core;
using ITI.ApiOrderingService.Model;
using ITI.GrpcInventoryService.Server.Protos;
using static ITI.GrpcInventoryService.Server.Protos.InventoryProductService;

namespace ITI.GrpcInventoryService.Server.Services
{
    public class InventoryService : InventoryProductServiceBase
    {
        private readonly ILogger<InventoryService> logger;

        public InventoryService(ILogger<InventoryService> logger)
        {
            this.logger = logger;
        }

        public override Task<ProductResponse> CheckAvailability(ProductReqeust request, ServerCallContext context)
        {
            var product = ModelLists.ProductsList.FirstOrDefault(p => p.ProductId == request.ProductId);

            if (product == null)
            {
                // product not found
                return Task.FromResult(new ProductResponse { InStock = false });
            }

            var available = product.InStock > 0;

            return Task.FromResult(new ProductResponse { InStock = available });
        }


    }
}
