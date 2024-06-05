namespace CQRSProject.CQRSDesignPattern.Commands.ProductCommand
{
    public class RemoveProductCommand
    {
        public RemoveProductCommand(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
    }
}
