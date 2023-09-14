using ProductApi.Models;

namespace ProductApi.Repositary
{
    public interface IData
    {
        Product SaveBillDetails(Product details);
        List<Product> GetAllProductDetails();
    }
}
