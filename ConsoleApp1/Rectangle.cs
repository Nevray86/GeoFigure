using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeoFigure
{
   
         class Rectangle : GeoFigure
        {
             public Rectangle()
            {
                name = "прямоугольник";
                Lengh = 3m;
                Heigth = 3m;
            }
            public override void Dimensions()
            {
                Console.WriteLine("Вы выбрали прямоугольник ");
                Console.WriteLine("Укажите размер первой стороны ");
                Lengh = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Укажите размер второй стороны ");
                Heigth = Convert.ToDecimal(Console.ReadLine());

            }
            public override void Show()
            {
                Console.WriteLine("Вы выбрали прямоугольник , укажите размер одной стороны ");
            }
            public override decimal Square()

            {
                decimal _square = this.lengh * this.heigth;
                return _square;
            }
            private decimal Lengh;

            public decimal lengh
            {
                get { return Lengh; }
                set { Lengh = value; }
            }
            private decimal Heigth;

            public decimal heigth
            {
                get { return Heigth; }
                set { Heigth = value; }
            }


        }
}

