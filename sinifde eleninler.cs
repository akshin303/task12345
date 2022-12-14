using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Power(2,4));
            Console.WriteLine(Sum(3,4,5));
            int[] numbers = new int[] { 4, 5, 6, 7, 8 };
            Console.WriteLine(Sum1(numbers));
        }
        //- Verilmiş ədədin verilmiş qüvvətini tapan metod
        static int Power(int number,int power)
        {
            int result = 1;
            
                for(int i = 0; i < power; i++) 
            {
                result *= number;
            }
            return result;

            
        }
        //- Verilmiş 3 ədəddən ən böyüyünü tapan metod
        static int Sum(int number1,int number2,int number3)
        {
            var max = 0;
            if(number1>number2 && number1>number3)
            {
                max = number1;
            }
            else if(number2>number3)
            {
                max = number2;
            }
            else
            {
                max = number3;
            }
            return max;
        }
          //Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan metod
          static int Sum1(int[] numbers)
        {
            var sum = 0;
            for(int i =0;i<numbers.Length;i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        //- Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan metod
        static int Sum2(int[] reqemler)
        {
            var max = reqemler[0];
            for(int i=1;i<reqemler.Length;i++)
            {
                if(reqemler[i]>max)
                {
                    max = reqemler[i];
                }
                
            }
            return max;
        }
        

        

    }
}
