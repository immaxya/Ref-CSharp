class MyClass
{
    //1.delegate 선언
    private delegate void RunDelegate(int i);

    private void RunThis(int val)
    {
        Console.WriteLine("{0}", val);
    }

    private void RunThat(int value)
    {
        Console.WriteLine("0x{0:X}", value);
    }

    public void Perform()
    {
        //2. delegate 인스턴스 생성
        RunDelegate run = new RunDelegate(RunThis);
        //3. delegate 실행
        run(1024);

        run = RunThat;
        run(1024);
    }
}


internal class Program
{
    static void Main(string[] args)
    {
        MyClass mc = new MyClass();
        mc.Perform();
    }
}