using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Game
    {
        int heroBullets;
        int villainBullets;
        int heroSpeed = 1;
        int villainSpeed;
        int heroHealth = 100;
        int villainHealth = 100;
        public Game(int heroBullets, int villainBullets, int villainSpeed)
        {
            this.heroBullets = heroBullets;
            this.villainBullets = villainBullets;
            this.villainSpeed = villainSpeed;
        }
        public void StartGame()
        {
            int loopStopper = Math.Min(this.heroBullets, this.villainBullets / this.villainSpeed);
            for (int i = 0; i < loopStopper; i++)
            {
                this.heroHealth -= this.villainSpeed;
                this.villainHealth-=1;
                this.heroBullets-=1;
                this.villainBullets-=this.villainSpeed;
                if(this.heroHealth <= 0)
                {
                    Console.WriteLine("villian Won the Game!");
                    return;
                }
                if (this.villainHealth <= 0 )
                {
                    Console.WriteLine("Hero Won the Game!");
                    return;
                }
                
                int heroShot = i + 1;
                int villainShot = (i+1)*this.villainSpeed;
                Console.Write($"step {i+1} => ");
                Console.WriteLine($"Hero shoot {heroShot} bullet & villain shoot {villainShot} bullet");
            }
            if (this.heroHealth > this.villainHealth)
            {
                Console.WriteLine("Hero Won the Game!");
            }else if (this.heroHealth < this.villainHealth)
            {
                
                    Console.WriteLine("Villain Won the Game!");
                
            }
        }
    }
    internal class HeroVillianGame
    {
        public static void main(string[] args)
        {
            Game g1 = new Game(120, 30, 2);
            g1.StartGame();
        }
    }
}
