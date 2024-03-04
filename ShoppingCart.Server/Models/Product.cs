namespace ShoppingCart.Server.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal ActualPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
    }
}
