using Entities.Entities;

namespace APIService.IServices
{
    public interface IProductService
    {
        int InsertProduct(ProductItem productItem);
        List<ProductItem> GetProductItem();
        
        void DeleteProduct(int id);
        void UpdateProduct(ProductItem productitem);
        List<ProductItem> GetProductByCriteria(string ProductBrand);

    }
}
