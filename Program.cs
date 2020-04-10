using System;

namespace HW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_2.1
            int A, B, R = 0;
            Console.WriteLine("A = ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("B = ");
            B = int.Parse(Console.ReadLine());

            for(int i = A; i <= B; i ++) R += i;
            Console.WriteLine($"Сумма от {A} до {B} = {R}");
            // EndTask_2.1

            // Task_2.2
            int A, B;
            Console.WriteLine("A = ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("B = ");
            B = int.Parse(Console.ReadLine());

            for(int i = A; i <=B; i ++)
            if(i % 2 == 1) Console.WriteLine(i);
            //EndTask_2.2


            //Task_3.1
            
        }
    }
}
