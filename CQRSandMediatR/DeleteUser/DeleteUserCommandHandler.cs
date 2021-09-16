using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSandMediatR.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommandRequest>
    {
        public Task<Unit> Handle(DeleteUserCommandRequest request, CancellationToken cancellationToken)
        {
            Database.Users.RemoveAll(u => u.Id == request.Id);
            return Unit.Task;
        }
    }
}
