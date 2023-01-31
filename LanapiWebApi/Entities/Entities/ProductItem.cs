using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ProductItem
    {
        public ProductItem()
        {
           IsActive = true;
           IsPublic = true;
        }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string  Brand { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }
    }
}
