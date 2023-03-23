
using LinqExercise;
using System;
using System.Linq;
namespace LinqExercise
{
    class Program2
    {

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion



        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sum = nums.Sum();
            Console.WriteLine(sum);
            var av = nums.Average();
            Console.WriteLine(av);

            Console.WriteLine("increasing order");
            nums.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("decreasing order");
            nums.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

            foreach (var x in nums)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("All numbers greater than 6");
            nums.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("only print 4");
            foreach (var x in nums.OrderBy(x => x).Take(4))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("make index 4=21");
            nums[4] = 21;

            List<Employee> employees = CreateEmployees();

            Console.WriteLine("first letter is C or S");
            var filter = employees.Where(person => person.FirstName[0] == ('C') || person.FirstName[0] == ('S'));
            Console.WriteLine("Find people over 26 then check sort by name");
            var over26 = employees.Where(person => person.Age > 26).OrderBy(person => person.Age).ThenBy(person => person.FirstName);
            Console.WriteLine("Find people over 35 in age with over 10 years of experience");
            var years = employees.Where(person => person.YearsOfExperience<= 10 && person.Age > 35);
            Console.WriteLine("total years of experience of everyone combined");
            var sumYOE = employees.Sum(person => person.YearsOfExperience);
        }
    }
}

