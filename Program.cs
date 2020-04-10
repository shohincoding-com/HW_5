using System;

namespace HW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_2.1
            /* int A, B, R = 0;
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
            if(i % 2 == 1) Console.WriteLine(i); */
            //EndTask_2.2


            //Task_3.1
            /* for (int i=0; i<=10; i++){
                if (i==0 || i==10){
                    for(int j=0; j<=20; j++){
                    Console.Write(" *");}
                }
                else{
                    Console.Write(" *");
                    for (int j = 0; j <= 19; j++){
                        Console.Write("  ");
                    }
                }
                
                Console.Write(" *\n");
            }
            //EndTask_3.1

            //Task_3.2
            Console.Write("  *\n");
            for (int i = 0; i <= 8; i++)
            {
                Console.Write("  *");
                for (int j = 0; j <= i; j++)
                    Console.Write("   ");
                Console.Write("*\n");
                if (i == 8)
                {
                    for (int j = 0; j <= i; j++)
                    { Console.Write("  * "); }
                    Console.Write("\n");
                }
            }
            //EndTask_3.2

            //Task_3.3
            for (int i = 0; i <= 12; i++)
            {
                for (int k = 12 - i; k >= 0; k--)
                {
                    Console.Write("  ");
                }
                if (i >= 2 && i < 12)
                {
                    Console.Write("  *");
                    for (int l = 0; l <= i - 2; l++)
                    {
                        Console.Write("    ");
                    }
                    Console.Write("   *");
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    { Console.Write("  * "); }
                }
                Console.Write("\n");
            }
            //EndTask_3.3

            //Task_3.4
            for (int i = 0; i <= 12; i++)
            {
                for (int k = 12 - i; k >= 0; k--)
                {
                    Console.Write("  ");
                }
                if (i >= 2 && i <= 12)
                {
                    Console.Write("  *");
                    for (int l = 0; l <= i - 2; l++)
                    {
                        Console.Write("    ");
                    }
                    Console.Write("   *");
                }
                else if (i == 0 || i == 1)
                {
                    for (int j = 0; j <= i; j++)
                    { Console.Write("  * "); }
                }
                Console.Write("\n");
            }
            for (int i = 12; i >= 0; i--)
            {   if(i!=12)
                for (int k = -i + 12; k >= 0; k--)
                {
                    Console.Write("  ");
                }
                if (i >= 2 && i < 12)
                {
                    Console.Write("  *");
                    for (int l = 0; l <= i - 2; l++)
                    {
                        Console.Write("    ");
                    }
                    Console.Write("   *");
                }
                else if (i == 0 || i == 1)
                {
                    for (int j = 0; j <= i; j++)
                    { Console.Write("  * "); }
                }
                if(i!=12)Console.Write("\n");
            } */
            //EndTask_3.4


            //Task_4
            double P, Sum = 1000;int K=0;
            Console.Write("P = ");
            P = double.Parse(Console.ReadLine());
            if (P > 0 && P < 25)
            {
                for(Sum=1000;Sum<=1100;Sum+=((Sum*P)/100))K++;
                Console.WriteLine($"K = {K}");
                Console.WriteLine($"S = {Sum}");
            }
            //EndTask_4
        }
    }
}
