using System;

namespace Properties
{
    public class Person
    {
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public Person()
        {

        }
        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;

                return timespan.Days;
            }

        }

    }
}
