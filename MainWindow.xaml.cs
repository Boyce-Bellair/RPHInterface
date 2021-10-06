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

namespace InterfacePrototype
{

    public partial class MainWindow : Window
    {
        public Player player;


        public MainWindow()
        {
            InitializeComponent();


            Player player = new Player();
            GameText.Text = "Welcome to the game. You are now " +
                "facing " + player.CurrentDirection;
            
        }

        private void North_Click(object sender, RoutedEventArgs e)
        {
            if (player.CurrentDirection == Directions.North)
            {
                player.CurrentDirection = Directions.North;
                GameText.Text = "You are now facing North";

            }

            else
            {
                GameText.Text += "the direction was not north";
            }



        }
    }
}
