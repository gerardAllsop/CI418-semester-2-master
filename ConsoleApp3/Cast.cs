﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    class Cast
    {
        private List<Actor> cast = new List<Actor> {new Actor("farmer"), new Actor("fox"),
                                                    new Actor("goose"), new Actor("corn")};
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
                if(role.Name.Equals(name))
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
                if (role.Name.Equals(name))
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
                if (role.Name.Equals(name))
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
        public Boolean everyoneSafe()
        {
            Bank farmer = getCastMember("farmer").getPosition();
            Bank fox = getCastMember("fox").getPosition();
            Bank goose = getCastMember("goose").getPosition();
            Bank corn = getCastMember("corn").getPosition();
            if (fox == goose && farmer != goose)
                return false;
            else if (goose == corn && farmer != corn)
                return false;
            else
                return true;
        }
    }
}
