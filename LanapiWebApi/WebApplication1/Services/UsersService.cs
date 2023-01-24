using APIService.IServices;
using Entities.Entities;
using Logic.Ilogic;

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

}
}
