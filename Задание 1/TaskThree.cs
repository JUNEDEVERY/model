using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1
{
    class TaskThree
    {
        // a - коэффициент рождаемости жертв.
        // b - вероятность убийства волка
       // y - коэф. смертности волков
       // q - способность к воспроизводству хищников
        // kkbunny - количество кроликов
        // kkwolf - количество волков

        static double GetPOPBunny(double a, double b, double kkbunny, double kkwolf)
        {
            double bny = kkbunny + kkwolf * a - b * kkbunny * kkwolf;
            return bny;
        }
        static double GetPOPWolf(double y, double q, double kkbunny, double kkwolf)
        {
            double wlf = kkwolf - kkwolf * y + q * kkbunny * kkwolf;
            return wlf;
        }

        public static double[,] GetInfo(int bunny, int wolf, double a, double b, double y, double q)
        {
            double[,] pop = new double[217, 2];
            pop[0, 0] = bunny;
            pop[0, 1] = wolf;
            for (int i = 1; i<217; i++)
            {
                pop[i, 0] = GetPOPBunny(a, b, pop[i - 1, 0], pop[i - 1, 1]);
                pop[i, 1] = GetPOPWolf(y, q, pop[i - 1, 0], pop[i - 1, 1]);
            }
            
            return pop;
        }
        public static double GetStacionar1(double a, double b)
        {
            double pointwolf = a / b;
            return pointwolf;
            
        }

        public static double GetStacionar2(double y, double q)
        {
          
            double pointBunny = y / q;
            return pointBunny;
        }



    }
}
