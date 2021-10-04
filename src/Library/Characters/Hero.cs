using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class Hero : Character
    {
        private int totalVP = 0;
        public int VP {get; set;}
         protected Hero(string name) : base(name)
        {
            this.Name = name;
            this.VP = VP;
        }
 
        public void addVP(Enemy enemies)
        {
            this.totalVP += enemies.VP; 
        }
    }
}