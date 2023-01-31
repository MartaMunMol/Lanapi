using Entities.Entities;

namespace APIService.IServices
{
    public interface IUsersService
    {
        int InsertUser(UsersItem useritem);
        List<UsersItem> GetUserItem();
    }
}
