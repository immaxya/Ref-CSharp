namespace ConsoleApp2
{
    delegate void EventHandler(string message);
    class MyNotifier
    {
        public event EventHandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp!=0 && temp%3 == 0)
            {
                SomethingHappened(String.Format("{0}:짝", number));
            }
        }
    }


    internal class Program
    {
        static public void MyHandler(string message)
        {
            Debug.WriteLine(message);
        }

        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += MyHandler;

            for (int i=0; i<100; i++)
            {
                notifier.DoSomething(i);
            }

        }
    }
}
