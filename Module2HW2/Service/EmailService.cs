using System;
using Module2HW2.Model;

namespace Module2HW2.Service
{
    public class EmailService
    {
        public void EmailAccept(User user)
        {
            Console.WriteLine("---Email post---");
            Console.WriteLine($"{user.Name} your order in progress now.");
        }
    }
}
