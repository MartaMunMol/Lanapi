using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UsersItem
    {
        public UsersItem() {
            IsActive = true;
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string IdRol { get; set; }
        public bool IsActive { get; }
    }
}
