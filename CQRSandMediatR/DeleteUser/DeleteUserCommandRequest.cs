namespace CQRSandMediatR.DeleteUser
{
    public class DeleteUserCommandRequest : CommandBase
    {
        public int Id { get; set; }
    }
}
