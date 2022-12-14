using System;
using System.Threading;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] world = new string[] { "salam", "sa2", "sa4", "sa23" } ;
           
            Console.WriteLine(Count(world));
        }
        //Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
        static int Count(string[]names)
        {
            var count = 0;
            
            for(int i =0;i<names.Length;i++)
            {
                if (names[i] == "0" || names[i] == "1" || names[i] == "2" || names[i] == "3"|| names[i] == "4"|| names[i] == "5"|| names[i] == "6" || names[i] == "7" || names[i] == "8" || names[i] == "9")
                {
                    break;
                    
                }
                count++;
                
            }
            return count;
        }
    }
}
