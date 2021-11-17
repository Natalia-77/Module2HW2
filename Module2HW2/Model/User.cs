using Module2HW2.Config;

namespace Module2HW2.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserType UserType { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public NotificationType Notification { get; set; }
    }
}
