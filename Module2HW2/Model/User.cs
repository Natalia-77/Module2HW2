using Module2HW2.Config;

namespace Module2HW2.Model
{
    public class User
    {
        public string Name => "Ivan Ivanov";
        public UserType UserType => UserType.Regular;
        public string Email => "ivan@gmail.com";
        public string Phone => "(012)345-67-89";
        public NotificationType Notification => NotificationType.Email;
    }
}
