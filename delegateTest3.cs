class MySort
{
    //1.delegate 선언
    public delegate int CompareDelegate(int x, int y);

    public static void Sort(int[] arr, CompareDelegate comp)
    {
        if (arr.Length < 2) return;
        Console.WriteLine("함수 Prototype:", comp.Method);

        int ret;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                ret = comp(arr[i], arr[j]);
                if (ret == -1)
                {
                    int tmp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = tmp;
                }
            }
        }
    }
    static void Display(int[] arr)
    {
        foreach(int i in arr)
        {
            Console.WriteLine(i + " ");
        }
        Console.WriteLine();
    }
}



internal class Program
{
    static void Main(string[] args)
    {
        (new Program()).Run();
    }

    void Run()
    {
        int[] a = { 5, 53, 3, 7, 1 };

        MySort.CompareDelegate compDelegate = new MySort.CompareDelegate(AscendingCompare);
        MySort.Sort(a, compDelegate);

        // 내림차순으로 소트
        compDelegate = DescendingCompare;
        MySort.Sort(a, compDelegate);
    }

    int AscendingCompare(int i1, int i2)
    {
        if (i1 == i2) return 0;
        return (i2 - i1) > 0 ? 1 : -1;
    }

    int DescendingCompare(int i1, int i2)
    {
        if (i1 == i2) return 0;
        return (i1 - i2) > 0 ? 1 : -1;
    }
}