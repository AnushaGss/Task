using System;
namespace Reverse
{

    class Program
    {
        static void Main(string[] args)
        {
            string Str, Revstr = "  ";
            int Length;
            Console.WriteLine("Enter a String:");
            Str = Console.ReadLine();
            Length = Str.Length - 1;
            while (Length >= 0)
            {
                Revstr = Revstr + Str[Length];
                Length--;
            }
            Console.WriteLine("Rever of a String :" +Revstr);
            Console.WriteLine($"Rever of a String {Revstr}");
           // Console.ReadLine();
        }
    }
   
}