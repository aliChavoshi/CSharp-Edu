using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        //1Way
        public readonly List<Order> orders = new List<Order>();

        //2Way
        public Customer()
        {
            this.orders = new List<Order>();
        }

        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
        public void Promote()
        {
            //this.orders = new List<Order>();
        }

    }
}
