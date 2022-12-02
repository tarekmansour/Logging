using App.BLL.DTOs;
using App.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public async Task<GetProductDTO> GetProduct(int id)
        {
            return await _productService.GetProductAsync(id);
        }

        [HttpPost]
        public async Task<int> CreateProduct([FromBody] CreateProductDTO createProductDTO)
        {
            return await _productService.CreateProductAsync(createProductDTO);
        }
    }
}
