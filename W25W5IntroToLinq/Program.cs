namespace W25W5IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 4, 6, 7, 4, 9, 2, 8, 7, 4, 1 };

            var result = from n in array
                         where n > 4
                         orderby n
                         select n;

            foreach (var i in result)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");


        }
    }
}
