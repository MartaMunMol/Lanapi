using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Ilogic
{
    public interface IProductLogic
    {
        void InsertProductItem(ProductItem productItem);
        List<ProductItem> GetProductItem();
        void DeleteProduct(int id);
        void UpdateProduct(ProductItem productItem);


    }
}
