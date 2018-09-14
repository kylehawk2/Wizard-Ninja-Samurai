using System;
using System.Collections.Generic;

namespace WNS
{
    public class Wizard: Human{
        public Wizard(string n) : base(n){
            intelligence = 25;
            health = 50;
        }
        public void Heal(){
            health += intelligence * 10;
            int amount = intelligence * 10;
            Console.WriteLine("{0} has been healed for {1} to {2} health", name, amount, health);
        }
        public void Fireball(object target){
            Human enemy = target as Human;
            if(enemy != null)
            {
                Random rand = new Random();
                enemy.health -= rand.Next(20, 50);
            }
        }
    }
}
