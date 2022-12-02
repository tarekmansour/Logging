using App.BLL.DTOs;

namespace App.BLL.Interfaces
{
    public interface IProductService
    {
        Task<GetProductDTO> GetProductAsync(int id);
        Task<IEnumerable<GetProductDTO>> GetProductsAsync();
        Task<int> CreateProductAsync(CreateProductDTO createProductDTO);
        Task DeleteProductAsync(int id);
    }
}
