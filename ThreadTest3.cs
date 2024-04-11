namespace ConsoleApp2
{
    class Counter
    {
        const int LOOP_COUNTER = 10;
        readonly object thisLock;

        private int count;
        public int Count
        {
            get { return count; }
        }

        public Counter()
        {
            thisLock = new object();
            count = 0;
        }

        public void Increase()
        {
            int loopCount = LOOP_COUNTER;
            while (loopCount-- > 0)
            {
                lock (thisLock)
                {                    
                    count++;
                    Console.WriteLine("Increase:{0}:{1}", loopCount, count);

                }
                Thread.Sleep(1);
            }
        }

        public void Decrease()
        {
            int loopCount = LOOP_COUNTER;
            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    count--;
                    Console.WriteLine("Decrease:{0}:{1}", loopCount, count);
                }
                Thread.Sleep(1);
            }
        }

    }

    internal class Program
    {
        
        static void Main(string[] args)
        { 
            Counter counter = new Counter();

            Thread incThread = new Thread(new ThreadStart(counter.Increase));
            Thread decThread = new Thread(new ThreadStart(counter.Decrease));

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();

            Console.WriteLine(counter.Count);

            Console.ReadLine();
        }
    }
}