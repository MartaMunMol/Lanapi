using APIService.IServices;
using Entities.Entities;
using Logic.Ilogic;
using Logic.Logic;

namespace APIService.Services
{
    public class PersonService : IPersonService
    {
        public readonly IPersonLogic _personLogic;
        
        public PersonService (IPersonLogic personLogic)
        {
            _personLogic = personLogic;
        }
        public int InsertPerson(PersonItem personItem)
        {
            _personLogic.InsertPersonItem(personItem);
            return personItem.Id;
        }

        public List<PersonItem> GetPersonItem()
        {
            return _personLogic.GetPersonItem();
        }

        public void DeletePerson(int id)
        {
            _personLogic.DeletePerson(id);
        }

    }
}