using CQRSProject.CQRSDesignPattern.Results.ProductResults;
using CQRSProject.DAL.Context;

namespace CQRSProject.CQRSDesignPattern.Handlers.ProductHandddddleeeeeers
{
    public class GetProductQueryHandler
    {
        private readonly CQRSContext _context;

        public GetProductQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x=>new GetProductQueryResult
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                CategoryId = x.CategoryId,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Price = x.Price,
                Stock = x.Stock
            }).ToList();
            return values;
        }
    }
}
