using Data;
using Entities.Entities;
using Logic.Ilogic;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class PersonLogic: BaseContextLogic, IPersonLogic
    {
        public PersonLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertPersonItem(PersonItem personItem)
        {
            _serviceContext.Persons.Add(personItem);
            _serviceContext.SaveChanges();
        }

        public List<PersonItem> GetPersonItem()
        {
            return _serviceContext.Set<PersonItem>().ToList();

            //var resultList = new List<OrderItem>();
            //return resultList();
        }
    }
}