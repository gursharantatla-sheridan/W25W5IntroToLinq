namespace W25W5IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 4, 6, 7, 4, 9, 2, 8, 7, 4, 1 };


            //query syntax
            var result = from n in array
                         where n > 4
                         orderby n
                         select n;


            // method syntax
            //var result = array.Where(n => n > 4);


            foreach (var i in result)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");



            List<string> colors = new List<string>();
            colors.Add("BlUe");
            colors.Add("rUsT");
            colors.Add("GreEN");
            colors.Add("ReD");

            var startsWithR = from c in colors
                              let uppercaseColors = c.ToUpper()
                              where uppercaseColors.StartsWith("R")
                              orderby uppercaseColors
                              select uppercaseColors;

            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");



            // deferred execution

            colors.Add("rUBy");
            colors.Add("PInk");

            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n\n\n");



            List<Employee> employees = new List<Employee>()
            {
                new Employee("John", "Green", 5000),
                new Employee("Anne", "Green", 6000),
                new Employee("Mark", "Red", 3000),
                new Employee("James", "Indigo", 7000),
                new Employee("Sandy", "Indigo", 4000),
                new Employee("John", "Brown", 2000)
            };

            foreach (var emp in employees)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n\n");



            var between4k6k = from e in employees
                              where e.Salary >= 4000 && e.Salary <= 6000
                              select e;

            foreach (var emp in between4k6k)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n\n");



            var sortedEmps = from e in employees
                             orderby e.LastName, e.FirstName
                             select e;

            foreach (var emp in sortedEmps)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n\n");



            var lastnames = from e in employees
                            select e.LastName;

            foreach (var emp in lastnames.Distinct())
                Console.WriteLine(emp);
            Console.WriteLine("\n\n\n");



            var empNames = from e in employees
                           select new { e.FirstName, e.LastName };

            foreach (var emp in empNames)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n\n");
        }
    }
}
