using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Customer 
    {
        private List<Order> orderHistory = new();

        public IReadOnlyCollection<Order> OrderHistory => this.orderHistory.AsReadOnly();
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer (string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
        public void AddOrder (Order order)
        {
            this.orderHistory.Add(order);
        }
    }
}
