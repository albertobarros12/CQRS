using Shop.Application.Customers.Commands;

namespace Shop.Application.Customers.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}