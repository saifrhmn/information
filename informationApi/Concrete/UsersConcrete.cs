using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using informationApi.Interface;
using informationApi.Models;
using informationApi.DBContext;

namespace informationApi.Concrete
{
    public class UsersConcrete : IUser
    {
        private readonly DatabaseContext _context;
        public UsersConcrete(DatabaseContext context)
        {
            _context = context;
        }

        public bool InsertUsers(User user)
        {
            _context.Users.Add(user);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
