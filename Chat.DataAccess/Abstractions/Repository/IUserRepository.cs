using Chat.DataAccess.Abstractions.Repository;
using Chat.DataAccess.Entity.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.DataAccess.Abstractions.Repository
{
    public interface IUserRepository : IBaseRepository<UserEntity>
    {        
    }
}
