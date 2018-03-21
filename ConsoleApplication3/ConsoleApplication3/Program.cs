using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;


            Console.Write("輸入體重:");
            double kg = double.Parse(Console.ReadLine());
            Console.Write("輸入身高:");
            double cm = double.Parse(Console.ReadLine());
            double BMI = kg / ((cm * 0.01) * (cm * 0.01));
            Console.WriteLine("BMI值為:" + BMI);


            if (BMI < 18.5)
            {
                Console.WriteLine("體重過輕,必須去當兵");
            }

            if (BMI >= 18.5 && BMI < 24)
            {
                Console.WriteLine("體重正常,必須去當兵");
            }

            if (BMI >= 24 && BMI < 31)
            {
                Console.WriteLine("體重過重,但要當兵");
            }

            if (BMI > 31)
            {
                Console.WriteLine("體重超重,死肥老當什麼當兵");


                Console.Beep(784, 500);
                Console.Beep(659, 500);
                Console.Beep(659, 500);
                Console.Beep(698, 500);
                Console.Beep(587, 500);
                Console.Beep(587, 500);


            }

            Console.ReadLine();
        }
    }
}
