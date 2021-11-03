using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq001.Models
{
    public class RepositoryPerson
    { //< ou >
        public static List<Person> persons()
        {
            List<Person> people = new List<Person>()
            {
                new Person() {ID =1, Name = "Person 1", Adress = "Country 1", Salary = 10000},
                new Person() {ID =2, Name = "Person 12", Adress = "Country 1", Salary = 20000},
                new Person() {ID =3, Name = "Person 123", Adress = "Country 1", Salary = 30000},
                new Person() {ID =4, Name = "Person 1234", Adress = "Country 1", Salary = 40000},
                new Person() {ID =5, Name = "Person 12345", Adress = "Country 1", Salary = 50000},
                new Person() {ID =6, Name = "Person 123456", Adress = "Country 1", Salary = 60000},
                new Person() {ID =7, Name = "Person 1234567", Adress = "Country 1", Salary = 70000},
                new Person() {ID =8, Name = "Person 12345678", Adress = "Country 1", Salary = 80000}
            };
            return people;
        }
    }
}
