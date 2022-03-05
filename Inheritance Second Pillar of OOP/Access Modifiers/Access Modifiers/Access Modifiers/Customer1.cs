using System;

namespace Access_Modifiers
{
    public class Customer1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Promote()
        {
            var rating = CaculateRating(excludeOrders: true);
            if (rating == 0)
            {
                Console.WriteLine("Promoted to Level 1");
            }
            Console.WriteLine("Promoted to Level 1");
        }

        protected int CaculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
