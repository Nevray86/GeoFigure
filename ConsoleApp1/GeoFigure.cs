using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeoFigure
{
    abstract class GeoFigure
    {
        private string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public abstract decimal Square();
        public abstract void Show();

        public abstract void Dimensions();

    }
}
