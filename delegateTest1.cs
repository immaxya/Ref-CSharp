namespace DelegateTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program().Test();
        }

        //delegate정의
        delegate int MyDelegate(string s);

        void Test()
        {
            MyDelegate m = new MyDelegate(StringToInt);
            Run(m);
        }

        int StringToInt(string s)
        {
            return int.Parse(s);
        }

        void Run(MyDelegate m)
        {
            int i = m("123");
            Console.WriteLine(i);
        }           

    }
}