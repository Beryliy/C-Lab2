using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Program
    {

        static void Main(string[] args)
        {
            Garrage garrage = new Garrage();

            while (true)
            {
                int i = 0;
                Console.WriteLine(@"Выберите нужное Вам действие:
1. Добавить в список велосипед;
2. Добавить в список машину;
3. Добавить в список грузовик;
4. Вывести все велосипеды из списка;
5. Вывести все машины из списка;
6. Вывести все грузовики из списка;
7. Выход.");
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
                switch (i)
                {
                    case 1: garrage.AddBicycle(); break;
                    case 2: garrage.AddCar(); break;
                    case 3: garrage.AddLorry(); break;
                    case 4: Console.WriteLine("Велосипеды:"); garrage.GetAllBicycle(); break;
                    case 5: Console.WriteLine("Машины:"); garrage.GetAllCar(); break;
                    case 6: Console.WriteLine("Грузовики:"); garrage.GetAllLorry(); break;
                    case 7: return;
                    default: Console.WriteLine(""); break;
                }
            }
        }
    }
}