using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class Enemy : Character
    {

        protected Enemy(string name, int VP) : base (name)
        {
            this.Name = name;
            this.VP = VP;
        }
        public int VP {get;}
        
     

    }
}