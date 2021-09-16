using CQRSandMediatR.Models;

namespace CQRSandMediatR.CreateUser
{
    public class CreateUserCommandRequest : CommandBase
    {
        public User User { get; set; }
    }
}
