using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Ilogic
{
    public interface IPersonLogic
    {
        void InsertPersonItem(PersonItem personItem);

        List<PersonItem> GetPersonItem();
        void DeletePerson(int id);

    }
}
