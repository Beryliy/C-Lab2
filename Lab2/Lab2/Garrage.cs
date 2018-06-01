using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Garrage
    {
        public List<Lorry> lorrys = new List<Lorry>();
        public List<Car> cars = new List<Car>();
        public List<Bicycle> bicycles = new List<Bicycle>();

        public void AddLorry()
        {
            int prise = 0, maxspeed = 0, year = 0, MaxCapacity = 0;
            Console.WriteLine("Введите цену:");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите максимальную скорость");
            try
            {
                maxspeed = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите год:");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите грузоподьемность");
            try
            {
                MaxCapacity = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            lorrys.Add(new Lorry(prise, maxspeed, year, MaxCapacity));
        }

        public void AddCar()
        {
            int prise = 0, maxspeed = 0, year = 0, Power = 0;
            Console.WriteLine("Введите цену:");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите максимальную скорость");
            try
            {
                maxspeed = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите год:");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите мощьность:");
            try
            {
                Power = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            cars.Add(new Car(prise, maxspeed, year, Power));
        }

        public void AddBicycle()
        {
            int prise = 0, maxspeed = 0, year = 0, MaxPassengers = 0;
            Console.WriteLine("Введите цену:");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите максимальную скорость");
            try
            {
                maxspeed = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите год:");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите количество пасажиров:");
            try
            {
                MaxPassengers = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            bicycles.Add(new Bicycle(prise, maxspeed, year, MaxPassengers));
        }

        public void GetAllLorry()
        {
            foreach (Lorry lorry in lorrys)
            {
                Console.WriteLine("Цена: {0}, Максимальная скорость: {1}, Год: {2}, Максимальная грузоподьемность: {3};", lorry.Price, lorry.Maxspeed, lorry.Year, lorry.MaxCapacity);
            }
        }

        public void GetAllCar()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine("Цена: {0}, Максимальная скорость: {1}, Год: {2}, Мощьность: {3};", car.Price, car.Maxspeed, car.Year, car.Power);
            }
        }

        public void GetAllBicycle()
        {
            foreach (Bicycle bicycle in bicycles)
            {
                Console.WriteLine("Цена: {0}, Максимальная скорость: {1}, Год: {2}, Максимум пасажиров: {3};", bicycle.Price, bicycle.Maxspeed, bicycle.Year, bicycle.MaxPassengers);
            }
        }

    }
}