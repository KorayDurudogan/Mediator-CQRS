using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSandMediatR.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommandRequest>
    {
        public Task<Unit> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            Database.Users.Add(request.User);
            return Unit.Task;
        }
    }
}
