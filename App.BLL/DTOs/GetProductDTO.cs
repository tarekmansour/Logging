using App.DAL.Models;

namespace App.BLL.DTOs
{
    public class GetProductDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
