using System.Collections.Generic;
namespace RoleplayGame
{
    public class Pirate: Enemy
    {

        public Pirate(string name, int VP) : base (name, VP)
        {
            this.AddItem(new Sword());
            this.AddItem(new Sword());
            this.AddItem(new Axe());
        }

        
    }
}