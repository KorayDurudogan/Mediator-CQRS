namespace CQRSandMediatR.GetUser
{
    public class GetUserQueryRequest : QueryBase<GetUserQueryResponse>
    {
        public int Id { get; set; }
    }
}
