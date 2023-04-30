using Grpc.Core;
using ITI.GrpcPaymentService.Server.Protos;
using static ITI.GrpcPaymentService.Server.Protos.Payment;
using ITI.ApiOrderingService.Model;

namespace ITI.GrpcPaymentService.Server.Services
{
    public class PaymentService : PaymentBase
    {
        public override Task<PaymentResponse> CheckBalance(PaymentRequest request, ServerCallContext context)
        {
            var user = ModelLists.Clients.FirstOrDefault(c => c.Id == request.ClientId);
            bool available = user != null && user.Balance > request.Balance;
            return Task.FromResult(new PaymentResponse { Success = available });

        }
    }
}
