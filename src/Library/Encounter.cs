using System.Collections.Generic;
using System;

namespace RoleplayGame
{
    public class Encounter
    {
        private List<Hero> heroes;
        private List<Enemy> enemies;
        public Encounter()
        {
            this.heroes = new List<Hero>();
            this.enemies = new List<Enemy>();
        }

        //uso ejemplo de Word y frases
        public void AddHero(Hero hero)
        {
            this.heroes.Add(hero);
        }
        public void AddEnemy(Enemy enemy)
        {
            this.enemies.Add(enemy);
        }

        public void DoEncounter()
        {
           //Mientras haya heroes o enemigos
           while (this.heroes.Count > 0 && this.enemies.Count > 0 )
           {
                //EnemyAttack
                int count = 0;
                foreach (Enemy enemy in this.enemies)
                {
                    // Si hay mas enemigos que heroes, el enemigo siguiente ataca al primer Heroe.
                    if(count >= this.heroes.Count)
                    {
                        count = 0;
                    }
                    this.heroes[count].ReceiveAttack(enemy.AttackValue);
                    Console.WriteLine($"Enemy: {enemy.Name} attacks to Heroe:{this.heroes[count].Name}, Health:{this.heroes[count].Health} ");
                    if (this.heroes[count].Health == 0)
                    {  
                        Console.WriteLine($"{this.heroes[count].Name} is dead!!");
                        this.heroes.Remove(heroes[count]);
                    }

                    count++;
                }
                //HeroesAttack

                //count = 0;
                foreach (Hero hero in this.heroes)
                {
                    for(int i=0 ; i < this.enemies.Count; i++)

                    //foreach (Enemy enemy in this.enemies) comento porque no deja eliminar enemigos de la lista utilizando foreach
                    {
                        this.enemies[i].ReceiveAttack(hero.AttackValue);
                        Console.WriteLine($"Hero: {hero.Name} attacks to Enemy:{this.enemies[i].Name}, Health:{this.enemies[i].Health} ");
                        if (this.enemies[i].Health == 0)
                        {  
                            Console.WriteLine($"{this.enemies[i].Name} is dead!!");
                            this.enemies.Remove(this.enemies[i]);
                            hero.addVP(this.enemies[i]);
                        }
                    }
                }
            }
        }
    }
}

