using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
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
            initializeHoles();

            
        }

        private void initializeHoles()
        {
            Hole hole1 = new Hole();
            Hole hole2 = new Hole();

            hole1.drawH(10, 10, MainGrid);
            hole2.drawH(50,100, MainGrid);

        }

    }
}
