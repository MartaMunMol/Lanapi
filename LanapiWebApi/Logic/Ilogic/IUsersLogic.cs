using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Ilogic
{
    public interface IUsersLogic
    {
        void InsertUserItem(UsersItem userItem);
        List<UsersItem> GetUserItem();
    }
}
