using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Bicycle : Vehicle
    {
        //оригинальное поле для байков
        public int MaxPassengers { get; set; }

        //конструктор + конструктор базового класса
        public Bicycle(int prise, int maxspeed, int year, int MaxPassengers)
            : base(prise, maxspeed, year)
        {
            this.MaxPassengers = MaxPassengers;
        }

    }
}