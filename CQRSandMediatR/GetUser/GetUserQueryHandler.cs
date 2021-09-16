using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSandMediatR.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQueryRequest, GetUserQueryResponse>
    {
        public Task<GetUserQueryResponse> Handle(GetUserQueryRequest request, CancellationToken cancellationToken)
        {
            var user = Database.Users.FirstOrDefault(u => u.Id == request.Id);
            return Task.FromResult(new GetUserQueryResponse { User = user });
        }
    }
}
