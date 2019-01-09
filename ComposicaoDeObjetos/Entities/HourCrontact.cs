using System;
using System.Collections.Generic;
using System.Text;

namespace ComposicaoDeObjetos.Entities
{
    class HourCrontact
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourCrontact()
        {
        }

        public HourCrontact(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

    }
}
