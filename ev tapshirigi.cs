using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //- Verilmiş yazıda rəqəm olub olmadığını qaytaran metod
            var word = Console.ReadLine();
          
            Console.WriteLine(Hasworld(word));

        }
        static bool Hasworld(string world)
        {
            for(int i=0;i<world.Length;i++)
            {
                if (world[i] == '0' || world[i] == '1'|| world[i] == '2'|| world[i] == '3' || world[i] == '4' || world[i] == '5'|| world[i] == '6' || world[i] == '7' || world[i] == '8' || world[i] == '9')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
