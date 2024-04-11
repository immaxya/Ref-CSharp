internal class Program
{
    static void OnWrongPathType(string path)
    {
        Console.WriteLine("Type:{0} is wrong type");
        return;
    }
    static void Main(string[] args)
    {
        string path = "D:\\pathtest";
        string type = "File";

        if (File.Exists(path) || Directory.Exists(path))
        {
            if (type == "File")
                File.SetLastWriteTime(path, DateTime.Now);
            else if (type == "Directory")
                Directory.SetLastWriteTime(path, DateTime.Now);
            else
            {
                OnWrongPathType(path);
                return;
            }
            Console.WriteLine("Updated {0} {1}", path, type);

            return;
        }

        if (type == "File")
            File.Create(path).Close();
        else if (type == "Directory")
            Directory.CreateDirectory(path);
        else
        {
            OnWrongPathType(path);
            return;
        }

        Console.WriteLine("Updated {0} {1}", path, type);
        
        Console.ReadLine();
    }
} 