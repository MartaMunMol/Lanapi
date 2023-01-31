using Entities.Entities;
using Data;
using Logic.Ilogic;

namespace Logic.Logic
{
    public class UsersLogic : BaseContextLogic, IUsersLogic
    {
        public UsersLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertUserItem(UsersItem usersitem)
        {
            _serviceContext.Users.Add(usersitem);
            _serviceContext.SaveChanges();
        }

        public List<UsersItem> GetUserItem()
        {
            return _serviceContext.Set<UsersItem>().ToList();

        }
    }
}
