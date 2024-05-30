using CQRSProject.CQRSDesignPattern.Results.CategoryResults;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly CQRSContext _context;
        public GetCategoryQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public List<GetCategoryQueryResults> Handle()
        {
            var values = _context.Categories.Select(x => new GetCategoryQueryResults
            {
                CategoryId = x.CategoryId
            });
            return values.ToList();
        }
    }
}
