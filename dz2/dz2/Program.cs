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

            while (R1<0)
            {
                Console.WriteLine("введите ещё раз R1 (R1>=0) : ");
                R1 = Convert.ToDouble(Console.ReadLine());
            }

            while (R2<0)
            {
                Console.WriteLine("введите ещё раз R2 (R>=0) : ");
                R2 = Convert.ToDouble(Console.ReadLine());
            }
        }
        static Double equation(Double x,Double a,Double b )
        {
            Double y = a * x + b;
            if (Math.Round(y, 2) == 0)
                return 0;
            else
                return Math.Round(y,2);
        }

        static Double equation3(Double x,Double R2)
        {
            Double y = Math.Sqrt(Math.Round(Math.Pow(R2, 2),2) - Math.Round(Math.Pow(x + 2, 2),2));
            if (Math.Round(y, 2) == 0)
                return 0;
            else
                return Math.Round(y, 2);
        }

        static Double equation4(Double x, Double R1)
        {
            Double y= -(Math.Sqrt(Math.Round(Math.Pow(R1, 2),2) - Math.Round(Math.Pow(x - 1, 2),2)));
            if (Math.Round(y, 2) == 0)
                return 0;
            else
                return Math.Round(y,2);
        }

        static void Main(string[] args)
        {
            Double R1=0, R2=0;

            enter(ref R1, ref R2);

            Console.WriteLine("R1={0:0.00}\tR2={1:0.00}\n", R1, R2);

            for (Double x=(-7); x<=3; x+=0.2)
            {
                x = Math.Round(x, 2);
                if (x < -7 || x > 3)
                    Console.WriteLine("Функции не определена ");

                else
                    if (x <= -6)
                    Console.WriteLine("y({0}) = {1}", x, equation(x, 0, 3));

                else
                    if (x <= -4)
                {
                    if (x == -4 && R2 > 2)
                        Console.WriteLine("y({0}) = {1} or y({2}) = {3}", x, equation(x, -0.5, -2), x, equation3(x, R2));
                    else
                        Console.WriteLine("y({0}) = {1}", x, equation(x, -0.5, -2));
                }
                else
                    if (x <= 0)
                    {
                        if (R2 >= 2)
                        {
                        if (x == 0 && R1 > 1)
                            Console.WriteLine("y({0}) = {1} or y({2}) = {3}",x,equation3(x,R2), x, equation4(x, R1));
                        else
                            Console.WriteLine("y({0}) = {1}", x, equation3(x, R2));         
                        }
                    else
                        {
                            if (x >= (-2 - R2) && x <= (-2 + R2))
                                Console.WriteLine("y({0}) = {1}", x, equation3(x, R2));
                            else if (R1>=1 & x==0)
                                    Console.WriteLine("y({0}) = {1}", x, equation4(x, R1));
                                else
                                    Console.WriteLine("Функции не определена в точке y({0:0.00})", x);
                        }
                    }

                else
                    if (x>=0 && x <= 2)
                {
                    if (R1 > 1)
                    {
                        if (x == 2)
                            Console.WriteLine("y({0}) = {1} or y({2}) = {3}",x,equation4(x,R1),x, equation(x, -1, 2));
                        else
                            Console.WriteLine("y({0}) = {1}", x, equation4(x, R1));
                    }
                    else
                    {
                        if (x >= (1 - R1) && x <= (1 + R1))
                            Console.WriteLine("y({0}) = {1}", x, equation4(x, R1));
                        else if (x==2)
                                Console.WriteLine("y({0}) = {1}", x, equation(x, -1, 2));
                             else
                                Console.WriteLine("Функции не определена в точке y({0:0.00})", x);
                    }
                }
                else
                    if (x <= 3)
                    Console.WriteLine("y({0}) = {1}", x, equation(x, -1, 2));
            }

            Console.ReadKey();
        }
      
    }
}
