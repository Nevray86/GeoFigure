using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeoFigure
{
     class Cub : GeoFigure
    {
        public Cub()
        {
            name = "куб";
            Lengh = 2;

        }
        public override void Dimensions()
        {
            Console.WriteLine("Вы выбрали куб");

            Console.WriteLine("Укажите размер одной стороны ");
            Lengh = Convert.ToDecimal(Console.ReadLine());


        }
        public override void Show()
        {
            Console.WriteLine("Вы выбрали куб , укажите размер одной стороны ");
        }

        public override decimal Square()

        {
            decimal _square = (lengh * lengh) * 6;
            return _square;
        }
        private decimal Lengh;

        public decimal lengh
        {
            get { return Lengh; }
            set { Lengh = value; }
        }
        

    }
}
