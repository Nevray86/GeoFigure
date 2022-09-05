using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeoFigure
{
    class showFigure
    {
        public void showSquare(GeoFigure sss)
        {
            Console.WriteLine(sss.Square());
        }
        public void ask()
        {
            Console.Write("Напишите название фигуры для вычисления площади:");

        }
        public string answer()
        {
            string b = Console.ReadLine();
            return b.ToLower();
        }
        public void Name(GeoFigure _name)
        {
            _name.Show();
        }
        public void dimesion(GeoFigure _namber)
        {
            _namber.Dimensions();

        }
       
    }
}
