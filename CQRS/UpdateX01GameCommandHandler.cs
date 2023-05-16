using Amazon.Lambda.APIGatewayEvents;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

public class UpdateX01GameCommandHandler : IRequestHandler<UpdateX01GameCommand, APIGatewayProxyResponse>
{
    public UpdateX01GameCommandHandler()
    {
    }
    public async Task<APIGatewayProxyResponse> Handle(UpdateX01GameCommand request, CancellationToken cancellationToken)
    {
        return new APIGatewayProxyResponse { StatusCode = 200 };
    }
}