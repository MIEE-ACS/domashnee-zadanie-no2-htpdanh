using System;

namespace dz2
{
    class Program
    {
        static void enter(ref Double R1, ref Double R2)
        {
            Console.WriteLine("введите R1 :");
            R1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введите R2 :");
            R2 = Double.Parse(Console.ReadLine());

            while (R1>1 || R1<0)
            {
                Console.WriteLine("введите ещё раз R1 (0<=R1<=1) : ");
                R1 = Convert.ToDouble(Console.ReadLine());
            }

            while (R2>2 || R2<0)
            {
                Console.WriteLine("введите ещё раз R2 (0<=R2<=2) : ");
                R2 = Convert.ToDouble(Console.ReadLine());
            }
        }

        static Double equation1(Double x)
        {
            return 1;
        }

        static Double equation2(Double x)
        {
            return (Double)(-x/2) - 2;
        }

        static Double equation3(Double x,Double R2)
        {
            return Math.Sqrt(Math.Pow(R2,2)-Math.Pow(x+2,2));
        }

        static Double equation4(Double x, Double R1)
        {
            return -(Math.Sqrt(Math.Pow(R1, 2) - Math.Pow(x - 1, 2)));
        }

        static Double equation5(Double x)
        {
            return -x+2;
        }

        static void Main(string[] args)
        {
            Double R1=0, R2=0;

            enter(ref R1, ref R2);

            Console.WriteLine("R1={0:0.00}\tR2={1:0.00}\n", R1, R2);

            for (Double x=(-7); x<=3; x+=0.2)
            {
                x = Math.Round(x, 2);
                if (x<-7 || x>3)
                    Console.WriteLine("Функции не определена ");

                else
                if (x >= -7 && x <= -6)
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, equation1(x));

                else
                  if (x >= -6 && x <= -4)
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, equation2(x));

                else
                  if (x >= (-2 - R2) && x <= (-2 + R2))
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, equation3(x, R2));

                else
                  if (x >= (1 - R1) && x <= (1 + R1))
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, equation4(x, R1));

                else
                     if (x >= 2 && x <= 3)
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, equation5(x));

                else
                    Console.WriteLine("Функции не определена в точке y({0:0.00})",x);
            }

            Console.ReadKey();
        }
      
    }
}
