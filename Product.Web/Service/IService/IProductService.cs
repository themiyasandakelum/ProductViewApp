using Product.Web.Models;

namespace Product.Web.Service.IService
{
    public interface IProductService
    {
        Task<ResponseDto> GetAllProductAsync();
        Task<ResponseDto> CreateProductAsync(ProductDto productDto);
    }
}
