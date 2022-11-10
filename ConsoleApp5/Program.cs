using System;

class Program
{
    static void Main(string[] args)
    {
        String str = "wonderful nature ";
        int count;
        char[] String1=str.ToCharArray();
        Console.WriteLine("Repeated Character in a string:");

        for(int i=0; i<String1.Length-1; i++)
        {
            count = 1;
            for (int j = i+1; j < String1.Length-1; j++)
            {
                if (String1[i] == String1[j])
                {
                    count++;
                    String1[j]=String1[i];
                }
            }
                        if (count > 1 && String1[i] != '0')
                            Console.WriteLine(String1[i]);
                    }
                }
            }

                  