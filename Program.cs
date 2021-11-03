using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq001.Models;

namespace Linq001
{
    class Program
    {
        static void Main(string[] args)
        {//< ou >
            List<Person> people = RepositoryPerson.persons();

            /*foreach(Person p in people)
            {
                Console.WriteLine($"Person id is {p.ID}");
            }*/

            Person p = people.Where(x => x.ID == 1).First();
            Console.WriteLine($"Person is {p.Name}");

            Person p31 = people.Where(x => x.ID == 31).First();

            if(p31 is null)
            {
                Console.WriteLine("Person not found");
            }
            else
            {
                Console.WriteLine($"Person is {p31.Name}");
            }

            List<Person> Listbelow5k = people.Where(x => x.Salary <=50000).ToList();

            foreach(Person currentperson in Listbelow5k)
            {
                Console.WriteLine($"Person id is {currentperson.ID} and earns {currentperson.Salary}");
            }
        }
    }
}
