using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractGeoFigure
{
   
    class Program
    {   
        static void Main(string[] args)
        {
            
            
            Rectangle myRectangle = new Rectangle();
            Cub myCub = new Cub();
            Circle myCircle = new Circle();
            GeoFigure[] GeoF = { myRectangle, myCub, myCircle };
            showFigure myShow = new showFigure();

            myShow.ask();
            
           string ptr = myShow.answer();
                for (int i = 0; i < GeoF.Length; i++)

                { 
                    if (GeoF[i].name == ptr)
                    {
                        myShow.dimesion(GeoF[i]);
                        Console.Write("Площадь " + GeoF[i].name+"a" + " = ");
                        myShow.showSquare(GeoF[i]);
                    }
                         
               
                }
                
        }
    }
}


