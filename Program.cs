using System;

namespace CoreMysql
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                foreach (var item in db.Employees)
                {
                    Console.WriteLine(item.LastName + " " + item.FirstName);
                }
            }
        }
    }
}
