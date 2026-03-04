namespace Ordena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array.Sort(args);

            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
        }
    }
}
