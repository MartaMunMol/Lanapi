using Entities.Entities;

namespace APIService.IServices
{
    public interface IPersonService
    {
        int InsertPerson(PersonItem personItem);

        List<PersonItem> GetPersonItem();
    }
}