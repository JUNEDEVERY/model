using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1
{
    class TaskTwo
    {
        // a - угол, под котором брошено тело
        // t - время
        // d - дискриминант
        // v0 - нач.скорость
        // g - УСП
        // t1,t2 - неизвестные
        // y0 - высота, откуда начали кидать тело
        // dalnost - дальность полета тела
        // maxvispol - макс. высота полета тела

        static double g = 9.8;
        
        static double GetCoordinateX(double vO1, double t, double a)
        {
            double result = vO1* Math.Cos(a) * t;
            return result;

        }
        static double? GetCoordinateY(double yO, double vO1, double t, double a)
        {
            double result = yO + vO1 * Math.Sin(a) * t -(g*Math.Pow(t,2)) / 2;

            if (result < 0)
            {
                Console.WriteLine("Брошенное тело оказалось на земле.");
                return null;
            }
            else
            {
                return result;
            }
        }
        static public double GetTimeFlight(double yO, double vO1, double a) // получаем время полета тела
        {
            double time = ((-vO1 * Math.Sin(a) - Math.Sqrt(Math.Pow(vO1 *Math.Sin(a), 2)+ 2 * g * yO)) / -g);
            return time;
        }
        static public double GetRangeFlight(double vO1, double yO, double a) // получаем дальность полета тела
        {
            double dalnost = (double)GetCoordinateX(vO1, GetTimeFlight(yO, vO1, a), a);
            //for (double i = 0; i < 1.57; i=0.000001)// находим угол, при котором дальность полета тела максимальна
            //{
            //    double time = (-vO1 * Math.Sin(i) - Math.Sqrt(Math.Pow(vO1 * Math.Sin(i), 2) + 2 * g * yO)) / -g;
            //    double x = (double)GetCoordinateX(vO1, time, i); // х - координата
            //    if (x>dalnost)
            //    {
            //        dalnost = x;
            //        maxugol = i;
            //    }
            //    return maxugol;
            //}
            return dalnost;
            
        }
        static public double GetUgol(double vO1, double yO)
        {
            double dalnost = 0;
            double maxugol = 0;
            for (double i = 0; i < 1.57; i = 0.000001)// находим угол, при котором дальность полета тела максимальна
            {
                double t = (-vO1 * Math.Sin(i) - Math.Sqrt(Math.Pow(vO1 * Math.Sin(i), 2) + 2 * g * yO)) / - g;
                double x = GetCoordinateX(vO1, t, i); // х - координата
                
                if (x > dalnost)
                {
                    dalnost = x;
                    maxugol = i;
                }

            }
            return maxugol;
            Console.Read();
        }
        static public double GetTimeMaxVysPod(double vO1, double a) // получаем максимальное время подъема тела
        {
            double timemaxpol = Math.Sin(a) * vO1 / g;
            return timemaxpol;
        }
        
        static public double GetMaxHeight(double vO1, double yO, double a) // получаем максимальную высоту подъема
        {
            double maxvys = (double)GetCoordinateY(yO, vO1, GetTimeMaxVysPod(vO1, a), a);
            return maxvys;

        }
        

        
    }
}
