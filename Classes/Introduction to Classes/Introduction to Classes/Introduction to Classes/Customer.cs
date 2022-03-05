using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Introduction_to_Classes
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> orders;


        public Customer()
        {
            orders = new List<Order>();
        }

        public Customer(int id) : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
