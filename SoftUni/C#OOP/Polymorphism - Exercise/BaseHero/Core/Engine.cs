using BaseHero.Common;
using BaseHero.Core.Contracts;
using BaseHero.Models;
using BaseHero.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHero.Core
{
    public class Engine : IEngine
    {
        public Engine() 
        {

        }

        public void Run()
        {
            var heroes = new List<IBaseHero>();

            var rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                var personName = Console.ReadLine();
                var heroType = Console.ReadLine();

                IBaseHero hero = null;

                try
                {
                    switch (heroType)
                    {
                        case "Druid":
                            hero = new Druid(personName);
                            break;
                        case "Paladin":
                            hero = new Paladin(personName);
                            break;
                        case "Rogue":
                            hero = new Rogue(personName);
                            break;
                        case "Warrior":
                            hero = new Warrior(personName);
                            break;
                        default: throw new NotImplementedException(ExceptionMessages.InvalidHeroTypeInput);
                    }

                    Console.WriteLine(hero.CastAbility());
                    heroes.Add(hero);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var bossPower = int.Parse(Console.ReadLine());

            var totalHeroPower = 0;

            foreach (var hero in heroes)
            {
                var currentHeroPower = hero.Power;
                totalHeroPower += currentHeroPower;
            }

            if (totalHeroPower > bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
