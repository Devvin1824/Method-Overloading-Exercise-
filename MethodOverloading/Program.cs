namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Methods.Add(5, 5));
            Console.WriteLine(Methods.Add(-3.0m, 6.5m));
            Console.WriteLine(Methods.Add(8, 9, true));
        }
    }
}
