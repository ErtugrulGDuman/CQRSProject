using CQRSProject.CQRSDesignPattern.Commands.ProductCommand;
using CQRSProject.DAL.Context;
using CQRSProject.DAL.Entities;

namespace CQRSProject.CQRSDesignPattern.Handlers.ProductHandddddleeeeeers
{
    public class CreateProductCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                CategoryId = command.CategoryId,
                Description = command.Description,
                ImageUrl = command.ImageUrl,
                Price = command.Price,
                ProductName = command.ProductName,
                Stock = command.Stock
            });
            _context.SaveChanges();
        }
    }
}
