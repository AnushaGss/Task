using System;
    
    class Program
{
    static void Main(string[] args)
    {
        int[] myNum = { 5, 1, 8, 9 };
        Array.Sort(myNum);
        foreach(int i in myNum)
        {
            Console.WriteLine(i);
        }
    }
}
