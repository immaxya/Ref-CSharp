namespace ConsoleApp2
{
    
    internal class Program
    {
        delegate string Concatenate(string[] args);


        static void Main(string[] args)
        {
            string[] strarr = new string[] { "123", "456", "789", "rksk" };
            Concatenate concat =
                (arr) =>
                {
                    string result = "";
                    foreach (string s in arr)
                    {
                        result += s;
                    }
                    return result;
                };

            Debug.WriteLine(concat(strarr));
        }
    }
}