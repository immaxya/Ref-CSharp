namespace ConsoleApp2
{
    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Class[] arrClass =
            {
                new Class() { Name = "연두반", Score = new int[] { 99, 88, 77, 66 } },
                new Class() { Name = "분홍반", Score = new int[] { 60, 67, 88, 47 } },
                new Class() { Name = "초록반", Score = new int[] { 100, 66, 88, 57 } },
                new Class() { Name = "파랑반", Score = new int[] { 99, 97, 87, 78 } },
                new Class() { Name = "노랑반", Score = new int[] { 89, 68, 78, 73 } }
            };

            var classes = from c in arrClass
                          from s in c.Score
                          where s < 60
                          orderby s
                          select new
                          {
                              c.Name,
                              Lowest = s
                          };

            foreach (var c in classes)
                Debug.WriteLine("낙제:{0}:{1}", c.Name, c.Lowest);
        }
    }
}