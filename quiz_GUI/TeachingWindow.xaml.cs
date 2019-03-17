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
            string windowTxt="";
            ActorWindow actors = new ActorWindow();
            string tmpActor = actors.getActor("Who do you want to put in the boat?");
            puzzle.putInBoat(tmpActor, out windowTxt);
            txtOutputBlock.Text = windowTxt;
        }
        private void River_Crossing_Click(object sender, RoutedEventArgs e){       
            string tmpText = puzzle.crossRiver();
            if (puzzle.puzzleConcluded())
            {
                UserInstruction("Satisfactory conclusion", "Puzzle Alert");
                this.Close();
            }
            else if (puzzle.safetyCheck())
                txtOutputBlock.Text = tmpText;
            else
            {
                UserInstruction("Unsatisfactory conclusion", "Puzzle Alert");
                this.Close();
            }
        }
        private void About_Detail_Click(object sender, RoutedEventArgs e){
            about = new About();
            about.ShowDialog();
        }
        private void Quit_Click(object sender, RoutedEventArgs e){
            this.Close();
        }

        private MessageBoxResult UserInstruction(string msg, string winCap)
        {
            string messageBoxText = msg;
            string caption = winCap;
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            // Display message box
            MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon);
            return result;
        }

    }
}
