using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class EmployeeItem : personItem
    {
    public EmployeeItem() { }
    public decimal Salary { get; set; }
    public int CompanyId { get; set; }

    }
}
