using CQRSProject.CQRSDesignPattern.Commands.CategoryCommands;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateCategoryCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new DAL.Entities.Category
            {
                CategoryName = command.CategoryName
            });
            _context.SaveChanges();
        }
    }
}
