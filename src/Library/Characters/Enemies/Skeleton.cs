using System.Collections.Generic;
namespace RoleplayGame
{
    public class Skeleton: Enemy
    {

        public Skeleton(string name, int VP) : base (name, VP)
        {
            this.AddItem(new Bone());
        }

        
    }
}