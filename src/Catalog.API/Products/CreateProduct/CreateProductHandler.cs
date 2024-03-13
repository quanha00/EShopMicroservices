using BuildingBlock.CQRS;
using Catalog.API.Model;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile,
        decimal Price) : ICommand<CreateProductResult>;

    public record CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken token)
        {
            var product = new Product
            {
                Name = command.Name,
                Category = new List<string>(),
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };
            
            //save to databáse 

            return new CreateProductResult(Guid.NewGuid());
            
            
            throw new NotImplementedException();
        }
    }
}