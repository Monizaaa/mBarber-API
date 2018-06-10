

namespace mBarber.Model
{
    public class UserRepo : BaseDB
    {
        public UserModel GetUser(string user, string password)
        {
            return null;
        }

        public UserModel InsertUser(UserModel userModel)
        {
            _db.GetCollection<UserModel>("users").InsertOneAsync(userModel);

            return userModel;
        }
    }
}
