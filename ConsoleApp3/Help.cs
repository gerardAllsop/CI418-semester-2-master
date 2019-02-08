using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    class Help
    {
        string introTxt = "A farmer with a fox, a goose, and a sack of corn needs to cross a river.\n" +
                         "The farmer has a rowboat, but there is room for only the farmer and one\n " +
                         "of his three items. Unfortunately, both the fox and the goose are hungry.\n" +
                         "The fox cannot be left alone with the goose, or the fox will eat the goose.\n" +
                         "Likewise, the goose cannot be left alone with the sack of corn, or the goose\n" +
                         "will eat the corn.\n" +
                         "\nHow does the farmer get everything across the river ?";
        MenuItems menu;

        public Help()
        {
            menu = new MenuItems();
        }

        public String getIntroTxt()
        {
            return introTxt;
        }
        public String getMenuText()
        {
            return menu.MenuString;
        }
    }
}
