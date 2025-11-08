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
    public class Treugol : Figura
    {
        public double Size { get; set; }

        public Treugol(double x, double y, double size) : base(x, y) {  
        
            Size = size;
            
        }

        public void Draw(Canvas canvas)
        {
            Polygon polygon = new Polygon
            {
                Fill = Brushes.Red,
                Points = new System.Windows.Media.PointCollection
                {
                    new System.Windows.Point(X, Y - Size/2),
                    new System.Windows.Point(X - Size/2, Y + Size/2),
                    new System.Windows.Point(X + Size/2, Y + Size/2)
                }
            };

            canvas.Children.Add(polygon);
        }
    }
}
