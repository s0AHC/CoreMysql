using System;

namespace CoreMysql
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new TestContext();
            foreach (var number in db.Numbers)
            {
                Console.WriteLine(number.Name);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
