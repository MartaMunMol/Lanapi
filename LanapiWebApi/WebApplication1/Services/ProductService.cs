using APIService.IServices;
using Data;
using Entities.Entities;
using Logic.Ilogic;
using Logic.Logic;

namespace APIService.Services
{
    public class ProductService : IServices.IProductService
    {
        private readonly IProductLogic _productLogic;
        public ProductService(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }
        public int  InsertProduct (ProductItem productItem)
        {
            _productLogic.InsertProductItem(productItem);
            return productItem.Id;
        }
        public List<ProductItem> GetProductItem()
        {
            return _productLogic.GetProductItem();
        }

        public void DeleteProduct(int id)
        {
            _productLogic.DeleteProduct(id);
        }

        public void UpdateProduct(ProductItem productItem)
        {
            _productLogic.UpdateProduct(productItem);
        }
        List<ProductItem> IProductService.GetProductByCriteria(string ProductBrand)
        {
            return _productLogic.GetProductByCriteria(ProductBrand);
        }
        
    }
}
