using FoxGooseCorn;
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
using System.Windows.Shapes;

namespace quiz_GUI
{
    /// <summary>
    /// Interaction logic for TeachingWindow.xaml
    /// </summary>
    public partial class TeachingWindow : Window
    {
        About about;
        Puzzle puzzle;
        public TeachingWindow(){
            InitializeComponent();
            puzzle = new Puzzle();
        }
        private void Intro_View_Click(object sender, RoutedEventArgs e){
            txtOutputBlock.Text = puzzle.getIntro();
        }
        private void Display_Actors_Click(object sender, RoutedEventArgs e){
            txtOutputBlock.Text = puzzle.getAllPlayerPositions();
        }
        private void Find_Actor_Click(object sender, RoutedEventArgs e){
            ActorWindow actors = new ActorWindow();
            txtOutputBlock.Text = actors.getActor("Who do you want to find?");
        }
        private void Load_Boat_Click(object sender, RoutedEventArgs e){
            string text="";
            ActorWindow actors = new ActorWindow();
            String player = actors.getActor("Who do you want to put in the boat?");
            if (puzzle.putInBoat(player, out text))
            {
                Image actorImage = getImageRef(puzzle.whereIsBoat().ToString().ToLower(),player);   
                actorImage.Opacity = 0.25;
                txtOutputBlock.Text = text;
            }
            else
            {
                txtOutputBlock.Text = text;
            }
        }
        private void River_Crossing_Click(object sender, RoutedEventArgs e){
            string boatOccupant = puzzle.getBoatOccupant().ToLower();
            bool boatHasOccupant = !boatOccupant.Equals("empty");
            txtOutputBlock.Text = puzzle.crossRiver();
            
            if (puzzle.whereIsBoat() == Bank.RIGHT)
            {
                left_boat_img.Visibility = Visibility.Hidden;
                right_boat_img.Visibility = Visibility.Visible;

                if (boatHasOccupant)
                {
                    getImageRef("left", boatOccupant).Visibility = Visibility.Hidden;
                    getImageRef("right", boatOccupant).Visibility = Visibility.Visible;
                    getImageRef("right", boatOccupant).Opacity = 1;
                }
            }
            else
            {
                left_boat_img.Visibility = Visibility.Visible;
                right_boat_img.Visibility = Visibility.Hidden;
                if (boatHasOccupant)
                {
                    getImageRef("right", boatOccupant).Visibility = Visibility.Hidden;
                    getImageRef("left", boatOccupant).Visibility = Visibility.Visible;
                    getImageRef("left", boatOccupant).Opacity = 1;
                }
            }

            if (!puzzle.safetyCheck())
            {
            
            }
            
        }
        private void About_Detail_Click(object sender, RoutedEventArgs e){
            about = new About();
            about.ShowDialog();
        }
        private void Quit_Click(object sender, RoutedEventArgs e){
            this.Close();
        }

        private Image getImageRef(string bank, string player)
        {
            StringBuilder img_name = new StringBuilder();
            img_name.Append($"{bank}_{player}_img");
            object imgNode = main_grid.FindName(img_name.ToString().ToLower());
            if (imgNode is Image)
                return imgNode as Image;
            return null;
        }
    }
}
