using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


            NewGame();
        }

        private void NewGame()
        {
            initializeBoard();


        }

        private void initializeBoard()
        {
            
            //intiializes values of polygon
            Polygon GameBoard = new Polygon
            {
                Tag = "B",
                Fill = Brushes.SaddleBrown,
                Stroke = Brushes.Black,
                Height = 450,
                Width = 800,
                Points = {new Point(240, 25), new Point(440, 290), new Point(47, 290) },
            };
            
            //add triangular board to the maingrid.
            MainGrid.Children.Add(GameBoard);
            MainGrid.UpdateLayout();

            //declare and intialize the hole objects
            Hole hole1 = new Hole(-300, -275, MainGrid, 1, true); //row 1
            Hole hole2 = new Hole(-375, -175, MainGrid, 2, true); //row 2
            Hole hole3 = new Hole(-225, -175, MainGrid, 3, true);
            Hole hole4 = new Hole(-450, -75, MainGrid, 4, true); //row 3
            Hole hole5 = new Hole(-300, -75, MainGrid, 5, false);
            Hole hole6 = new Hole(-150, -75, MainGrid, 6, true);
            Hole hole7 = new Hole(-525, 25, MainGrid, 7, true); //row 4
            Hole hole8 = new Hole(-375, 25, MainGrid, 8, true);
            Hole hole9 = new Hole(-225, 25, MainGrid, 9, true);
            Hole hole10 = new Hole(-75, 25, MainGrid, 10, true);
            Hole hole11 = new Hole(-600, 125, MainGrid, 11, true); //row 5
            Hole hole12 = new Hole(-450, 125, MainGrid, 12, true);
            Hole hole13 = new Hole(-300, 125, MainGrid, 13, true);
            Hole hole14 = new Hole(-150, 125, MainGrid, 14, true);
            Hole hole15 = new Hole(0, 125, MainGrid, 15, true);

        }

    }
}
