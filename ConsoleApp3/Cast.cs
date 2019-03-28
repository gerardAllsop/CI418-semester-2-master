using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    class Cast
    {
        private List<Actor> cast = new List<Actor> {
            new Actor("farmer"), new Actor("fox"),
            new Actor("goose"), new Actor("corn")
        };

        internal Actor Actor
        {
            get => default(Actor);
            set
            {
            }
        }

        public string getAllPositions()
        {
            StringBuilder sb = new StringBuilder();
            cast.ForEach(role => sb.Append(role.reportPosition()));
            return sb.ToString();
        }
        public string getCast()
        {
            StringBuilder sb = new StringBuilder();
            cast.ForEach(role => sb.Append(role.Name + " "));
            return sb.ToString();
        }
        public Boolean isValidCastMember(string name)
        {
            foreach(var role in cast)
            {
                if(role.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        public string getCastMemberPosition(string name)
        {
            foreach (var role in cast)
            {
                if (role.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    return role.reportPosition();
                }
            }
            return string .Format("Don't know where {0} is",name);
        }
        public Actor getCastMember(string name)
        {
            foreach (var role in cast)
            {
                if (role.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    return role;
                }
            }
            return null;
        }
        public void updatePosition(string name)
        {
            foreach (var role in cast)
            {
                if (role.Name.Equals(name))
                {
                    role.changeBank();
                }
            }
        }
        private void swapBank(Actor actor)
        {
            actor.changeBank();
        }

        public Boolean EveryoneSafe(out string text)
        {
            Bank farmer = getCastMember("farmer").bank;
            Bank fox = getCastMember("fox").bank;
            Bank goose = getCastMember("goose").bank;
            Bank corn = getCastMember("corn").bank;

            if (fox == goose && farmer != goose)
            {
                text = "Fox says: mmm! Tasty Goose";
                return false;
            }            
            else if (goose == corn && farmer != corn)
            {
                text = "Goose says: Time for a corny joke";
                return false;
            }
            else
            {
                text = "";
                return true;
            }
                
        }

        public Boolean EveryoneSafe()
        {
            Bank farmer = getCastMember("farmer").bank;
            Bank fox = getCastMember("fox").bank;
            Bank goose = getCastMember("goose").bank;
            Bank corn = getCastMember("corn").bank;

            if (fox == goose && farmer != goose)        
                return false;
            else if (goose == corn && farmer != corn)
                return false;
            else
                return true;
        }


        public Boolean puzzleCompleted()
        {
            Bank farmer = getCastMember("farmer").bank;
            Bank fox = getCastMember("fox").bank;
            Bank goose = getCastMember("goose").bank;
            Bank corn = getCastMember("corn").bank;

            if (fox == Bank.RIGHT &&
                goose == Bank.RIGHT &&
                corn == Bank.RIGHT)
                return true;
            return false;          
        }
    }
}
