using App.BLL.DTOs;
using App.BLL.Interfaces;
using App.DAL;
using App.DAL.Models;

namespace App.BLL.Services
{
    public class ProductService : IProductService
    {
        private readonly MyApplicationContext _db;

        public ProductService(MyApplicationContext db)
        {
            _db = db;
        }

        public async Task<GetProductDTO> GetProductAsync(int id)
        {
            var product = await _db.Products.FindAsync(id);
            if (product == null)
            {
                throw new KeyNotFoundException($"No product found for productId {id}");
            }

            return new GetProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
            };
        }

        public Task<IEnumerable<GetProductDTO>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<int> CreateProductAsync(CreateProductDTO createProductDTO)
        {
            if (createProductDTO == null)
            {
                throw new ArgumentNullException("Could not add nullable or empty product");
            }

            var product = new Product
            {
                Id = createProductDTO.Id,
                Name = createProductDTO.Name,
                Description = createProductDTO.Description
            };

            var createdProduct = await _db.Products.AddAsync(product).ConfigureAwait(false);
            await _db.SaveChangesAsync().ConfigureAwait(false);

            return createdProduct.Entity.Id;
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }        
    }
}
