using System.Windows;

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
            initializeHoles();


        }

        private void initializeHoles()
        {
            Hole hole1 = new Hole();
            Hole hole2 = new Hole();

            hole1.drawH(10, 10, MainGrid);
            hole2.drawH(50, 100, MainGrid);

        }

    }
}
