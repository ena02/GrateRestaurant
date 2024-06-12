using Greate.Services.ProdustAPI.Models.Dto;

namespace Greate.Services.ProdustAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProductAsync(int productId);
    }
}
