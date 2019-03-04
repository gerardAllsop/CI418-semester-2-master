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
        public TeachingWindow(){
            InitializeComponent();
        }
        private void Intro_View_Click(object sender, RoutedEventArgs e){}
        private void Display_Actors_Click(object sender, RoutedEventArgs e){}
        private void Find_Actor_Click(object sender, RoutedEventArgs e){}
        private void Load_Boat_Click(object sender, RoutedEventArgs e){}
        private void River_Crossing_Click(object sender, RoutedEventArgs e){}
        private void About_Detail_Click(object sender, RoutedEventArgs e){
            about = new About();
            about.ShowDialog();
        }
        private void Quit_Click(object sender, RoutedEventArgs e){
            this.Close();
        }
    }
}
