using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1
{
    class TaskOne
    {
        double time; // время полета тела
        double ttmax; // время, при котором тело оказалось на макисмальной высоте
        double max; // максимальная высота полета
        static double g = 9.8; // ускорение свободного падения
        static public double? GetCoordinate(double xO, double t, double vO)
        {
            double result = xO + vO * t - g * t * t / 2;
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
       static public double GetTimeAir(double vO, double xO)// получаем время полёта
        {
            double time = (vO + Math.Sqrt(vO * vO + 2 * g * xO)) / g;
            return time;
        }
       static public double GetMaxHeight(double vO) // получаем время, при котором тело оказалось на максимальной высоте.
        {
            double ttmax = vO / g;
            return ttmax;
        }   
       static public double GetMaxAir(double xO, double vO) // получаем максимальную высоту полета
        {
            double max = (double)GetCoordinate(xO, GetMaxHeight(vO), vO);
            return max;
        }



    }
}
