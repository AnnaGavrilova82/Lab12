using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату х:  ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y:  ");
            int y = Convert.ToInt32(Console.ReadLine());
            Krug krug = new Krug(radius, x, y);

            //Console.Write("Введите радиус окружности ");
            //krug.Radius = Console.ReadLine();
            krug.SS();
            krug.Duga();
            krug.Koordinaty();
            krug.Result();
            Console.ReadKey();
        }
        public class Krug
        {
            public double Radius { get; set; }
            //public const double PI = 3.14;
            double S;
            double L;
            int X { get; set; }
            int Y { get; set; }
            
            /*public double Radius
            {
                set
                {
                    if (Double.TryParse(value, out radius))
                    {

                    }
                    else
                        Console.WriteLine("Не верный тип данных");
                }
                get
                {
                    return radius;
                }
            }*/

            public Krug(double radius, int x, int y)
            {
                Radius = radius;
                X = x;
                Y = y;
            }
            public void SS()
            {
                S = (2 * Math.PI * Math.Pow(Radius, 2));
            }
            public void Duga()
            {
                L = (2 * Math.PI * Radius);
            }
            public void Koordinaty()
            {
                if (Math.Pow(Y, 2) + Math.Pow(X, 2) <= Math.Pow(Radius, 2))
                    Console.WriteLine("Точка пренадлежит окружности ");
                else 
                    Console.WriteLine("Точка не пренадлежит окружности ");

            }

            public void Result()
            {
                Console.WriteLine("Площадь окружности: {0}", S);
                Console.WriteLine("Длина окружности: {0}", L);

            }
        }
    }

}
        
