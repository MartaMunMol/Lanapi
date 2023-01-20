using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class productItem
    {
        public ProductItem()
        {
            IsActive = true;
            IsPublic = true;
        }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public bool IsActive { get; private set; }
        public bool IsPublic { get; private set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string  Brand { get; set; }
        public decimal Price { get; set; }
    }
}
}
