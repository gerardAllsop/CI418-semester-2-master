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
using FoxGooseCorn;

namespace quiz_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Help help;        
       
        public MainWindow()
        {
            InitializeComponent();
            help = new Help();
        }

        private void printIntro(object sender, RoutedEventArgs e)
        {
           txt_intro.Text =  help.getIntroTxt();   
        }


        private void showAbout(object sender, RoutedEventArgs e)
        {
            About aboutWindow = new About();
            aboutWindow.Show();
        }

        private void quitProgramme(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
