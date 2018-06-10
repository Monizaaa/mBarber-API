using System;
using System.Collections.Generic;
using System.Text;

namespace mBarber.Model
{
    public class UserRepo : BaseDB
    {
        public UserModel GetUser(string user, string password)
        {
            return null;
        }

        public void InsertUser(UserModel userModel)
        {
            //_db.GetCollection<UserModel>("users").Save(userModel);
            // return d;
        }
    }
}
