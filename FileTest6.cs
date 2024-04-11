internal class Program
{
    [Serializable]
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;
    }

    
    static void Main(string[] args)
    {
        Stream ws = new FileStream("a.dat", FileMode.Create);
        BinaryFormatter serializer = new BinaryFormatter();

        NameCard nc = new NameCard();
        nc.Name = "홍길동";
        nc.Phone = "010-1234-1234";
        nc.Age = 33;

        serializer.Serialize(ws, nc);
        ws.Close();

        Stream rs = new FileStream("a.dat", FileMode.Open);
        BinaryFormatter deserializer = new BinaryFormatter();

        NameCard nc2 = (NameCard)deserializer.Deserialize(rs);
        rs.Close();

        Console.WriteLine("Name:{0}", nc2.Name);
        Console.WriteLine("Phone:{0}", nc2.Phone);
        Console.WriteLine("Age:{0}", nc2.Age);

        Console.ReadLine();
    }
}