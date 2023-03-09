using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Testing
{
    public class Hole
    {
        int position;
        bool fill;

        
        public Hole(double X, double Y, Grid g, int pos, bool emp) 
        {
            //make a new ellipse
            Ellipse hole = new Ellipse
            {
                Tag = "H",
                Height = 30,
                Width = 30,
                
            };
            
            //set the position of the hole X being horizontal positions and Y being the vertical positions
            hole.Margin = new Thickness(X, Y, 0, 0);


            g.Children.Add(hole); //add the new hole as a child of a grid
            g.UpdateLayout(); //update the visual layout of the grid

            this.position = pos; //number position of the hole, used to help calculate valid moves

            this.fill = emp;

            //if fill is true, place a peg in the hole
            if (fill == true)
            {
                hole.Fill = Brushes.Green;
            }

            else
            {
                hole.Fill = Brushes.Black;
            }

            
        }

       

    }

}
