internal class Program
{
    
    static void Main(string[] args)
    {
        StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create));
        sw.WriteLine(int.MaxValue);
        sw.WriteLine("Good Morning");
        sw.WriteLine(uint.MaxValue);
        sw.WriteLine("안녕하세요");
        sw.WriteLine(double.MaxValue);
        sw.Close();

        StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));
        Console.WriteLine("File size:{0} bytes", sr.BaseStream.Length);
        while(sr.EndOfStream==false)
        {
            Console.WriteLine("{0}", sr.ReadLine());
        }
        sr.Close();


        Console.ReadLine();
    }
}