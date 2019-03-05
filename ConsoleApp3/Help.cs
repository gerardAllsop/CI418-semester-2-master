using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    public class Help
    {
        string introTxt = "A farmer with a fox, a goose, and a sack of corn needs to cross a river. " +
                         "The farmer has a rowboat, but there is room for only the farmer and one " +
                         "of his three items. Unfortunately, both the fox and the goose are hungry. " +
                         "The fox cannot be left alone with the goose, or the fox will eat the goose. " +
                         "Likewise, the goose cannot be left alone with the sack of corn, or the goose. " +
                         "will eat the corn." +
                         "\n\nHow does the farmer get everything across the river ?\n\n";
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
