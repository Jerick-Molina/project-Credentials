using MediatR;
using Microsoft.AspNetCore.Mvc;
using project_Credentials.App.Features.Queries;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project_Credentials.Controllers;

[Route("api/[controller]")]
[ApiController]
public class User : ControllerBase
{
    IMediator _mediator;


    public User (IMediator mediator) 
    {
        _mediator = mediator;
    }
    // GET: api/SignUp
    [HttpPost]
    public  async Task<string> Get()
    {
        return await _mediator.Send(new LoginQuery("Returning data from database(Notr"));
    }

 
}
