using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Testing
{
    public class Hole : UIElement
    {
        int position;

        public Hole() 
        {
        }
        public void drawH(double X, double Y, Grid b)
        {
            Ellipse hole = new Ellipse
            {
                Tag = "H",
                Height = 30,
                Width = 30,
                Fill = Brushes.Black,
                
            };

            //hole.TranslatePoint(new Point(X, Y), b);

            hole.Margin = new Thickness(X, Y, 0, 0);


            b.Children.Add(hole);
            b.UpdateLayout();

        }


    }

}
