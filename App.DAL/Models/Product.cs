namespace App.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
