/*
 * Thread클래스의 생성자가 받아들이는 파라미터는 ThreadStart델리게이트와 ParameterizedThreadStart델리게이트가 있다.
 * ThreadStart델리게이트는 public delegate void ThreadStart();와 같이 정의한다.
 * 리턴값과 파라미터 모두 void인 델리게이트 객체로 생성될 수 있다. */


internal class Program
{

    static void Main(string[] args)
    {
        //Run메소드를 입력받아 ThreadStart델리게이트 타입객체를 생성한후, Thread클래스 생성자에 전달
        Thread t1 = new Thread(new ThreadStart(Run));

        //컴파일러가 Run()메소드의 함수 프로토타입으로부터 ThreadStart Delegate객체를 추론하여 생성
        Thread t2 = new Thread(Run);
        t2.Start();

        //익명메소드(Anonymous Method)를 사용하여 쓰레드 생성
        Thread t3 = new Thread(delegate ()
        {
            Run();
        });
        t3.Start();

        //람다식을 사용ㅇ하여 쓰레드 생성
        Thread t4 = new Thread(() => Run());
        t4.Start();

        //간략한 표현
        new Thread(() => Run()).Start();
        
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