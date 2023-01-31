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
    }
}
