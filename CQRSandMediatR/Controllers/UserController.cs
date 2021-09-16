using CQRSandMediatR.CreateUser;
using CQRSandMediatR.DeleteUser;
using CQRSandMediatR.GetUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRSandMediatR.Controllers
{
    [ApiController, Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator) => this.mediator = mediator;

        [HttpGet, Route("{id:int}")]
        public async Task<GetUserQueryResponse> GetUser(int id) => await mediator.Send(new GetUserQueryRequest { Id = id });

        [HttpPost]
        public async Task CreateUser(CreateUserCommandRequest createUserCommandRequest) => await mediator.Send(createUserCommandRequest);

        [HttpDelete]
        public async Task DeleteUser(DeleteUserCommandRequest deleteUserCommandRequest) => await mediator.Send(deleteUserCommandRequest);
    }
}
