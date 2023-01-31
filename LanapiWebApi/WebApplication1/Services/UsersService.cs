using APIService.IServices;
using Entities.Entities;
using Logic.Ilogic;
using Logic.Logic;

namespace APIService.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersLogic _usersLogic;
        public UsersService (IUsersLogic usersLogic)
        {
            _usersLogic = usersLogic;
        }
        public int InsertUser(UsersItem usersItem)
        {
            _usersLogic.InsertUserItem(usersItem);
            return usersItem.Id;
        }
        public List<UsersItem> GetUserItem()
        {
            return _usersLogic.GetUserItem();
        }
    }
}
