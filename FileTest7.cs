internal class Program
{
    [Serializable]
    class NameCard
    {
        public NameCard(string Name, string Phone, int Age)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Age = Age;
        }
        public string Name;
        public string Phone;
        public int Age;
    }

    
    static void Main(string[] args)
    {
        Stream ws = new FileStream("a.dat", FileMode.Create);
        BinaryFormatter serializer = new BinaryFormatter();

        List<NameCard> list = new List<NameCard>();
        list.Add(new NameCard("홍길동", "010-1234-1234", 29));
        list.Add(new NameCard("아무개", "010-4321-4321", 59));
        list.Add(new NameCard("이순신", "010-5678-5678", 52));

        serializer.Serialize(ws, list);
        ws.Close();

        Stream rs = new FileStream("a.dat", FileMode.Open);
        BinaryFormatter deserializer = new BinaryFormatter();

        List<NameCard> list2 = (List<NameCard>)deserializer.Deserialize(rs);
        rs.Close();

        foreach(NameCard card in list2)
        {
            Console.WriteLine("Name:{0}", card.Name);
            Console.WriteLine("Phone:{0}", card.Phone);
            Console.WriteLine("Age:{0}", card.Age);
        }


        Console.ReadLine();
    }
}