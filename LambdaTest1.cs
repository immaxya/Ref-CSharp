namespace ConsoleApp2
{
    
    internal class Program
    {
        delegate int Calculate(int a, int b);


        static void Main(string[] args)
        {
            Calculate calc = (a, b) => a + b;
            Debug.WriteLine("{0} +{1} = {2}", 3, 4, calc(3, 4));       

        }
    }
}