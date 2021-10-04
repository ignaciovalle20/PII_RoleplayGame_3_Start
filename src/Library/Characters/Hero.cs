using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class Hero : Character
    {
        public int VP {get; set;}
         protected Hero(string name) : base(name)
        {
            this.Name = name;
            this.VP = VP;
        }
 
        public void addVP(Enemy enemies)
        {
            this.VP += enemies.VP; 
        }
    }
}