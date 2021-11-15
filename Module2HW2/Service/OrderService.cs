using System;
using Module2HW2.Model;

namespace Module2HW2.Service
{
    public class OrderService
    {
        public void OrderInfo(User user)
        {
            Console.WriteLine("---Order in progress---");
            Console.WriteLine($"Dear {user.Name} ,your order is accepted.Your confirmation will be sent {user.Email}");
        }

        public void OrderFinish(User user)
        {
            Console.WriteLine("---Order delivered---");
            Console.WriteLine($"{user.Name},buy from us again");
        }
    }
}
