/*
 * 동일 클래스가 아닌 다른 클래스의 메소드를 쓰레드에 호출하기 위해서는
 * 해당 클래스의 객체를 생성한후(혹은 외부로부터 전달받은 후)
 * 그 객체의 메소드를 델리게이트로 Thread에 전달하면 된다.*/

class Helper
{
    public void Run()
    {
        Console.WriteLine("Helper.Run");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        //Helper클래스의 Run메소드 호출
        Helper obj = new Helper();
        Thread t = new Thread(obj.Run);
        t.Start();
        
        Console.ReadLine();
    }
    

    static void Run()
    {
        Console.WriteLine("Thread#{0}: Begin", Thread.CurrentThread.ManagedThreadId);
        // Do Something
        Thread.Sleep(3000);
        Console.WriteLine("Thread#{0}: End", Thread.CurrentThread.ManagedThreadId);
    }
}