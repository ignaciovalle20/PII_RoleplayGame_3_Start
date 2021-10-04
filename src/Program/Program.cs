using System;
using System.Collections.Generic;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            //Heroes
            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book);
            Dwarf gimli = new Dwarf("Gimli");
            Knight knightdark = new Knight("KnightDark");
            Archer greenarrow = new Archer("GreenArrow");
            //Enemies
            Pirate morgan = new Pirate("PirateMorgan",10);
            Skeleton skel = new Skeleton("Skeleton", 5);
            Pirate oneill = new Pirate("O'neill",10);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

           // gimli.ReceiveAttack(gandalf.AttackValue);
           // Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
           // gimli.Cure();
           // Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}");
            Encounter Kombat = new Encounter();
            Kombat.DoEncounter();
            Kombat.AddHero(gandalf);
            Kombat.AddHero(gimli);
            Kombat.AddHero(knightdark);
            Kombat.AddHero(greenarrow);
            Kombat.AddEnemy(morgan);
            Kombat.AddEnemy(skel);
            Kombat.AddEnemy(oneill);
            Kombat.DoEncounter();
        }
    }
}
