using Microsoft.AspNetCore.Mvc;
using Shop.Application.Customers.Commands;
using Shop.Application.Customers.Handlers;

namespace Shop.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public CreateCustomerResponse Create(
            [FromServices] ICreateCustomerHandler handler,
            [FromBody] CreateCustomerRequest command)
            {
                return handler.Handle(command);
            }
    }
}