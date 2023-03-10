using Data;
using Entities.Entities;
using Logic.Ilogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class ProductLogic : BaseContextLogic, IProductLogic
    {
        public ProductLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertProductItem(ProductItem productItem)
        {
            _serviceContext.Products.Add(productItem);
            _serviceContext.SaveChanges();
        }

        public List<ProductItem> GetProductItem()
        {
            return _serviceContext.Set<ProductItem>().ToList();

        }

        public void DeleteProduct(int id)
        {
            var productToDelete = _serviceContext.Set<ProductItem>()
                 .Where(u => u.Id == id).First();

            productToDelete.IsActive = false;

            _serviceContext.SaveChanges();

        }

        public void UpdateProduct(ProductItem productItem)
        {
            _serviceContext.Products.Update(productItem);

            _serviceContext.SaveChanges();
        }
        public List<ProductItem> GetProductByCriteria(string ProductBrand)
        {
            var brandFilter = new ProductItem();
            brandFilter.Brand = ProductBrand;

            var resultList = _serviceContext.Set<ProductItem>()
                                .Where(p => p.Brand == ProductBrand);

            if (brandFilter.Brand == ProductBrand)
            {
                resultList = resultList.Where(p => p.Brand == ProductBrand);
            }


            return resultList.ToList();
        }
    }
}
