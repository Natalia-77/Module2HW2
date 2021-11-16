using Module2HW2.Model;
namespace Module2HW2.Provider
{
   public class UserProvider
    {
        private User _user;

        public UserProvider()
        {
            _user = new User();
        }

        public User SetUser()
        {
            _user.Id = 1;
            _user.Name = "Ivan Ivanov";
            _user.Phone = "(000)123-45-67";
            _user.Email = "ivan@gmail.com";
            _user.Notification = Config.NotificationType.Email;
            _user.UserType = Config.UserType.New;
            return _user;
        }
    }
}
