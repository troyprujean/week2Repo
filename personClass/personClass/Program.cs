using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person1 employee1 = new Person1("Bob", "Smith", 27.50, 18.50, 10486554);
            Person1 employee2 = new Person1("John", "Jack", 32.00, 17.00, 12345678);
            Person1 employee3 = new Person1("Ian", "Good", 18.00, 17.00, 4567891);
            Person1 employee4 = new Person1("Casey", "Frank", 22.00, 18.50, 32426565);
            Person1 employee5 = new Person1("Heather", "Alice", 25.00, 18.50, 54648879);

            List<Person1>personList = new List<Person1>
            {
                employee1,
                employee2,
                employee3,
                employee4,
                employee5
            };

            foreach (Person1 employee in personList)
            {
                Console.WriteLine(employee.Fname);
                Console.WriteLine(employee.Lname);
                Console.WriteLine(employee.Payrate);
                Console.WriteLine(employee.Taxrate);
                Console.WriteLine(employee.Accountnum);
                Console.WriteLine();
            }
        }
    }
}
