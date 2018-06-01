using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Car : Vehicle
    {
        //оригинальное поле для авто
        public int Power { get; set; }


        //конструктор + унаследованный конструктор
        public Car(int prise, int maxspeed, int year, int Power)
            : base(prise, maxspeed, year)
        {
            this.Power = Power;
        }
    }
}