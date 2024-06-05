namespace CQRSProject.CQRSDesignPattern.Queries.ProductQueries
{
    public class GetProductByIdQuery
    {
        public GetProductByIdQuery(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
    }
}
