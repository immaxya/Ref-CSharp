internal class Program
{

    static void Main(string[] args)
    {
        new Program().DoTest();

        Console.ReadLine();
    }

    void DoTest()
    {
        //새로운 쓰레드에서 Run()실행
        Thread t1 = new Thread(new ThreadStart(Run));
        t1.Start();

        //메인쓰레드에서 Run()실행
        Run();
    }

    void Run()
    {
        Console.WriteLine("Thread#{0}: Begin", Thread.CurrentThread.ManagedThreadId);
        // Do Something
        Thread.Sleep(3000);
        Console.WriteLine("Thread#{0}: End", Thread.CurrentThread.ManagedThreadId);
    }
}