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
    /// Interaction logic for ActorWindow.xaml
    /// </summary>
    public partial class ActorWindow : Window
    {
        public string occupantChosen{ get; set; }

        public ActorWindow(){
            InitializeComponent();
        }

        public string getActor(string msg){
            Instructions.Text = msg;
            if (this.ShowDialog() == true)
            {
                //return this.occupantChosen;
                if (Actor_List.SelectedValue != null)
                {
                    occupantChosen = Actor_List.SelectionBoxItem.ToString();

                    return occupantChosen;
                }
            }
            return String.Empty;
        }

        private void Actor_List_SelectionChanged(object sender, SelectionChangedEventArgs e){
            ComboBox cbx = (ComboBox)sender;
            if (cbx.SelectedValue != null)
                occupantChosen = cbx.SelectionBoxItem.ToString();
        }

        void acceptButton_Click(object sender, RoutedEventArgs e){
            // Accept the dialog and return the dialog result
            this.DialogResult = true;
        }
    }
}
