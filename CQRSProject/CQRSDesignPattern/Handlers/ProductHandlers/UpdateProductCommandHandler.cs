using CQRSProject.CQRSDesignPattern.Commands.ProductCommand;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var value = _context.Products.Find(command.ProductId);
            value.ProductName = command.ProductName;
            value.Price = command.Price;
            value.Description = command.Description;
            value.Stock = command.Stock;
            value.ImageUrl = command.ImageUrl;
            value.CategoryId = command.CategoryId;
            _context.SaveChanges();
        }
    }
}
