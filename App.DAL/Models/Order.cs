namespace App.DAL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public float Total { get; set; }
        public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();
    }
}
