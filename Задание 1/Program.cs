using System;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Тело брошено вертикально вверх, найти высоту подъёма и время, которое тело было в полёте\n");
            Console.WriteLine("2.Тело брошено под углом к горизонту с некоторой начальной высоты h0. " +
                "Определить дальность полета тела и максимальную высоту подъема, а также, угол, " +
                " при котором дальность полета будет максимальной\n");
            Console.WriteLine("3.Задача с кроликами\n");
            Console.WriteLine("4.Задача с шифрованием\n");
            while(true)
            { 
            Console.Write("Какую задачу хотите выбрать? => ");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.Write("Укажите начальную высоту, при котором было брошено тело => ");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Укажите начальную скорость => ");
                    double vO = Convert.ToDouble(Console.ReadLine());
                    TaskOne taskOne = new TaskOne();
                    Console.WriteLine("\nВремя полета тела - {0}", TaskOne.GetTimeAir(vO, h));
                    Console.WriteLine("Время, когда тело достигло максимальной высоты - {0}", TaskOne.GetMaxHeight(vO));
                    Console.WriteLine("Максимальная высота полета тела - {0}", TaskOne.GetMaxAir(h, vO));
                        Console.WriteLine("\nРешение закончилось.");
                        break;
                    

                case 2:
                        Console.Write("Укажите начальную высоту => ");
                        double yO = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Укажите начальную скорость => ");
                        double vO1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Укажите угол брошенного тела => ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        TaskTwo taskTwo = new TaskTwo();
                        Console.WriteLine("\nВремя полета тела равно {0}", TaskTwo.GetTimeFlight(yO,vO1, a));
                        Console.WriteLine("Дальность полета тела равна {0}", TaskTwo.GetRangeFlight(vO1, yO, a));
                        Console.WriteLine("Время, когда тело достигло максимальной высоты {0}", TaskTwo.GetTimeMaxVysPod(vO1, a));
                        Console.WriteLine("Максимальная высота полета тела {0}", TaskTwo.GetMaxHeight(vO1, yO, a));
                        Console.WriteLine("Угол, при котором дальность полёта максимальна равен {0}", TaskTwo.GetUgol(vO1, yO));
                       
                        Console.WriteLine("\nРешение закончилось.");
                        break;
                case 3:
                        Console.Write("Введите количество кроликов");
                        int bunny = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите количество волков");
                        int wolf = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Укажите коэффициент рождаемости кроликов");
                        double kfbunny = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Укажите вероятность, что кролик умрет");
                        double deadbunny = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Укажите коэффициент смертности волков");
                        double deadwolf = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Какова способность к воспроизводству волков? ");
                        double sxwolf = Convert.ToDouble(Console.ReadLine());
                        TaskThree taskThree = new TaskThree();
                        //double[,] test = TaskThree.GetInfo
                        for (int i = 0; i < 217; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                //TaskThree.GetInfo[i, j];
                                Console.Write(Math.Round(TaskThree.GetInfo(bunny,wolf, kfbunny, deadbunny, deadwolf, sxwolf)[i, j]) + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Стац.точка - {0} {1}", TaskThree.GetStacionar1(bunny, wolf), TaskThree.GetStacionar2(deadwolf, sxwolf));

                        break;
                case 4:break;
            }
            }

            
        }
    }
}