namespace ConsoleApp2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int> func1 = () => 10;
            Debug.WriteLine("func1():{0}", func1());

            Func<int, int> func2 = (x) => x * 2;
            Debug.WriteLine("func2():{0}", func2(4));

            Func<double, double, double> func3 = (x, y) => x / y;
            Debug.WriteLine("func3():{0}", func3(22,7));
        }
    }
}