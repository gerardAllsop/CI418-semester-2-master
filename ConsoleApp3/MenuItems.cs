using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    class MenuItems
    {
        private Dictionary<int, String> menuList = new Dictionary<int, string>{
            {1, "Repeat Intro" },
            {2, "Where is Everybody?" },
            {3, "Where is..." },
            {4, "Put in the boat?..." },
            {5, "Cross the river..." },
            {6, "Quit" }
        };
       
        public string MenuString {
            get {
                StringBuilder menuString = new StringBuilder();
                 foreach(var key in menuList.Keys)
                {
                    string str = string.Format("{0}: {1} ",key,menuList[key]);
                   menuString.Append(str);
                }
                return menuString.ToString();
            }
            private set{;}
            }

        internal Program Program
        {
            get => default(Program);
            set
            {
            }
        }

        public string getMenuItem(int index)
        {
            if (menuList.ContainsKey(index))
            {
                return menuList[index];
            }
            else
            {
                return "No such menu item";
            }
        }
    }
}
