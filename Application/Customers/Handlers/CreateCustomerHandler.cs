using System;
using Shop.Application.Customers.Commands;

namespace Shop.Application.Customers.Handlers
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            //validações
            //salva
            //açoes apos salvar

            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Alberto Barros",
                Email = "alberto.barros@email.com",
                CreateaAt = System.DateTime.Now
            };

        }
    }
}