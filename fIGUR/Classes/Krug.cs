using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace fIGUR.Classes
{
    public class Krug : Figura
    {
        public double Radius { get; set; }

        public Krug(double x, double y, double radius) : base(x, y) {
        
            Radius = radius;
        
        }

        public void Draw(Canvas canvas)
        {
            Ellipse ellipse = new Ellipse
            {
                Width = Radius * 2,
                Height = Radius * 2,
                Fill = Brushes.Blue
            };

            Canvas.SetLeft(ellipse, X - Radius);
            Canvas.SetLeft(ellipse, Y - Radius);
            canvas.Children.Add(ellipse);
        }
    }
}
