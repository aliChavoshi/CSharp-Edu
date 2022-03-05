using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exapmle1

            //Nullable<DateTime> date = null;
            DateTime? date = null;
            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            Console.WriteLine(date.Value);

            #endregion

            #region Example2

            DateTime? dateTime = DateTime.Now;
            DateTime dateTime1 = dateTime.GetValueOrDefault();

            #endregion

            #region Example3

            DateTime? date1 = null;
            DateTime date2 = date1 ?? DateTime.Now;

            var date3 = (date1 != null) ? date1.GetValueOrDefault() : DateTime.Now;

            if (date1 != null)
                date2 = date1.GetValueOrDefault();
            else
                date2 = DateTime.Now;

            Console.WriteLine(date2);

            #endregion

        }
    }
}
