using CQRSProject.CQRSDesignPattern.Commands.CategoryCommands;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly CQRSContext _context;

        public RemoveCategoryCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(RemoveCategoryCommand command)
        {
            var value = _context.Categories.Find(command.CategoryId);
            _context.Categories.Remove(value);
            _context.SaveChanges();
        }
    }
}
