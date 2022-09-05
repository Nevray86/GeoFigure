using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeoFigure
{
    internal class Circle : GeoFigure
    {
        public Circle()
        {
            name = "круг";
            Radius = 2;
            P = 3.14m;

        }
        public override void Dimensions()
        {
            Console.WriteLine("Вы выбрали круг");

            Console.WriteLine("Укажите радиус ");
            Radius = Convert.ToDecimal(Console.ReadLine());


        }
        public override void Show()
        {
            Console.WriteLine("Вы выбрали круг , укажите радиус ");
        }

        public override decimal Square()

        {
            decimal _square = (Radius * Radius) * P;
            return _square;
        }
        private decimal Radius;

        public decimal radius
        {
            get { return Radius; }
            set { Radius = value; }
        }
        private decimal P;

       
    }
}

