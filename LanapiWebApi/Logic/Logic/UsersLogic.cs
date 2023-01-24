using System.Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
