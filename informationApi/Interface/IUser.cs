using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using informationApi.Models;

namespace informationApi.Interface
{
    public interface IUser
    {
        bool InsertUsers(User user);
    }
}
