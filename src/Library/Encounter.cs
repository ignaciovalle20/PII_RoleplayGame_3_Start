using System.Collections.Generic;
using System;
using System.ComponentModel;

namespace RoleplayGame
{
    public class Encounter
    {
        private List<Hero> heroes;
        private List<Enemy> enemies;

        private List<Hero> deadheroes = new List<Hero>();
        private List<Enemy> deadenemies = new List<Enemy>();

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

        private void EnemiesAttack()
        {
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
                    // this.heroes.Remove(heroes[count]);
                    this.deadheroes.Add(heroes[count]);
                }

                count++;
            }
        }
        private void HeroesAttack()
        {
            foreach (Hero hero in this.heroes)
            {
                for(int i=0 ; i < this.enemies.Count; i++)
                //foreach (Enemy enemy in this.enemies) comento porque no deja eliminar enemigos de la lista utilizando foreach
                {
                    //Si no esta en la lista de Enemigos muertos lo ataco
                    if (!this.deadenemies.Contains(this.enemies[i]))
                    {
                        this.enemies[i].ReceiveAttack(hero.AttackValue);
                        Console.WriteLine($"Hero: {hero.Name} attacks to Enemy:{this.enemies[i].Name}, Health:{this.enemies[i].Health} ");
                        //Si el enemigo muere lo agrego a lista de enemigos muertos y asigno puntos de victoria al heroe
                        if ((this.enemies[i].Health == 0) ) 
                        {  
                            Console.WriteLine($"{this.enemies[i].Name} is dead!! - Hero {hero.Name} won {this.enemies[i].VP} VPs  ");
                            this.deadenemies.Add(this.enemies[i]);
                            hero.addVP(this.enemies[i]);
                        }
                    }
                }
            }
        }     
        //Remove deadHeroes form list
        private void RemoveDeadHeroes()
        {
            foreach (Hero deadhero in this.deadheroes)
            {
                this.heroes.Remove(deadhero);
            }
        }
        
        //Remove deadEnemies form list
        private void RemoveDeadEnemies()
        { 
            foreach (Enemy deadenemy in this.deadenemies)
            {
                this.enemies.Remove(deadenemy);
            }
        }
        private void CureHero()
        {
            foreach(Hero hero in this.heroes)
            {
                Console.WriteLine($"Heroe Name: {hero.Name}, VP: {hero.VP}, Heal: {hero.Health}");
                if (hero.VP >= 5)
                {
                    hero.Cure();
                    hero.VP -= 5;
                    Console.WriteLine($"Heroe: {hero.Name} curated, currently VP: {hero.VP}"); 
                }
            }
        }
        public void DoEncounter()
        {
            //Mientras haya heroes o enemigos
            while (this.heroes.Count > 0 && this.enemies.Count > 0 )
            {
                EnemiesAttack();
                RemoveDeadHeroes();
                HeroesAttack();
                RemoveDeadEnemies();
                CureHero();
            }
        }      
    }
}

