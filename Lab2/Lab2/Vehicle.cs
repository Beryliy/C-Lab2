using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    abstract class Vehicle
    {
        // исключения для классов наследников
        protected Exception OutOfMaxBorder = new Exception("Исключение, превышена максимальна граница");
        protected Exception NonBellowZero = new Exception("Исключение, введенное значение не может быть отрицательным!");

        protected int price, maxspeed, year;

        // свойство Стоимость
        public int Price
        {
            get { return price; }
            set { if (value > 0) price = value; }
        }
        // свойство Максимальная скорость
        public int Maxspeed
        {
            get { return maxspeed; }
            set { if (value > 0) maxspeed = value; }
        }
        // свойство Год выпуска
        public int Year
        {
            get { return year; }
            set { if (value <= DateTime.Today.Year) year = value; }
        }

        //конструктор класа!!!

        public Vehicle(int price, int maxspeed, int year)
        {
            this.Price = price;
            this.Maxspeed = maxspeed;
            this.Year = year;
        }


    }
}