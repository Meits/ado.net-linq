using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>()
            {
            new Department(){ Id = 1, Country = "Ukraine", City = "Donetsk" },
            new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },
            new Department(){ Id = 3, Country = "France", City = "Paris" },
            new Department(){ Id = 4, Country = "Russia", City = "Moscow" }
            };

            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                { Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2 },
                new Employee()
                { Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },
                new Employee()
                { Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },
                new Employee()
                { Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
                new Employee()
                { Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },
                new Employee()
                { Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
                new Employee()
                { Id = 7, FirstName = "Nikita", LastName = " Krotov ", Age = 27,DepId = 4 }
            };


            //1. Выбрать имена и фамилии сотрудников, работающих в Украине, но не в Донецке. 

            //var result =
            //   from e in employees
            //   join d in departments on e.DepId equals d.Id
            //   where d.City != "Donetsk"
            //   select new { Firstname = e.FirstName, Lastname = e.LastName };

            //foreach (var item in result)
            //{

            //    Console.WriteLine(item.Firstname);
            //}


            //2. Вывести список стран без повторений. 
            //var result = departments.Select(d => d.Country).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3.  Выбрать 3-x первых сотрудников, возраст которых превышает 25 лет. 

            //var result = employees.Select(e=>e).Where(e=>e.Age > 25).Take(3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.FirstName);
            //}

            //4. Выбрать имена, фамилии и возраст студентов из Киева, возраст которых превышает 23 года
            //var result =
            //   from e in employees
            //   join d in departments on e.DepId equals d.Id
            //   where d.City != "Kyiv" && e.Age > 23
            //   select new { Firstname = e.FirstName, Lastname = e.LastName, Age = e.Age };

            //foreach (var item in result)
            //{

            //    Console.WriteLine(item.Firstname + " AGE " +item.Age);
            //}

            // 5. Упорядочить имена и фамилии сотрудников по алфавиту, которые проживают в Украине.
            //var result =
            //   from e in employees
            //   join d in departments on e.DepId equals d.Id
            //   where d.Country == "Ukraine"
            //   orderby e.FirstName, e.LastName
            //   select new { Firstname = e.FirstName, Lastname = e.LastName };

            //foreach (var item in result)
            //{

            //    Console.WriteLine(item.Firstname + " " + item.Lastname);
            //}

            // 6.  Отсортировать сотрудников по возрастам, по убыванию. Вывести Id, FirstName, LastName, Age
            //var result = employees.OrderByDescending(e =>e.Age);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.FirstName + " " + item.LastName + " Age " + item.Age + " id " + item.Id);
            //}

            //7. Сгруппировать студентов по возрасту. Вывести возраст и сколько раз он встречается в списке. 
            var result = from e in employees
                         group e by e.Age into g
                         select new { Age = g.Key, Count = g.Count() };

            foreach (var item in result)
            {

                Console.WriteLine(item.Age + " Count " + item.Count);
            }

        }
    }
}
