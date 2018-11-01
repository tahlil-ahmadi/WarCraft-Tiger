using ProductManagment.Application.Contracts;
using ProductManagment.Domain.Model.Products;
using ProductManagment.Domain.Model.Products.GenericProducts;
using TigerFramework.Application;

namespace ProductManagment.Application
{
    public class ProductCommandHandlers : ICommandHandler<CreateGenericProductCommand>
    {
        private readonly IProductRepository _repository;
        public ProductCommandHandlers(IProductRepository repository)
        {
            _repository = repository;
        }

        public void Handle(CreateGenericProductCommand command)
        {
            var constraintValues = ConstraintFactory.CreateFromDto(command.ConstraintValues);
            var product = new GenericProduct(0, command.Title, constraintValues);
            _repository.Add(product);
        }
    }
}
