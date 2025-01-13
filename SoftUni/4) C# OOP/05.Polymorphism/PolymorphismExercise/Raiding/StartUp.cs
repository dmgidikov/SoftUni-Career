namespace Raiding
{
    using Models;
    using Raiding.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            var rotations = int.Parse(Console.ReadLine());

            var heroes = new List<IBaseHero>();

            for (int i = 0; i < rotations; i++)
            {
                var name = Console.ReadLine();
                var type = Console.ReadLine();

                try
                {
                    BaseHero hero = type switch
                    {
                        "Druid" => hero = new Druid(type),
                        "Paladin" => hero = new Paladin(type),
                        "Rogue" => hero = new Rogue(type),
                        "Warrior" => hero = new Warrior(type)
                    };

                    heroes.Add(hero);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Hero!");
                }
            }

            var bossPower = int.Parse(Console.ReadLine());

            var heroesPower = 0;

            foreach (var hero in heroes)
            {
                heroesPower += hero.Power;
                Console.WriteLine(hero.CastAbility());
            }

            if (heroesPower >= bossPower)
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