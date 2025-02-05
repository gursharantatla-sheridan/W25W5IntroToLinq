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
            Console.WriteLine("\n\n");
        }
    }
}
