namespace SuperHeroProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hero1 = new Hero("Bruce", "Wayne", "Batman", 1, 3);
            var hero2 = new Hero("Helen", "Parr", "Elastigirl", 2, 2);
            var hero3 = new Hero("I am Groot", "I am Groot", "Groot", 3, 4);
            var hero4 = new Hero("James", "Howlett", "Wolverine", 4, 2);
            var hero5 = new Hero("Buttercup", "Powerpuff", "Toughest Fighter", 5, 1);
            var hero6 = new Hero("Hiro", "Hamada", "Big Hero Guy", 6, 5);
            var hero7 = new Hero("Diana", "Prince", "Wonderwoman", 7, 3);

            var district1 = new District("Naujamiestis", "Vilnius", 03122, new List<Person>());
            var district2 = new District("Debrecenas", "Klaipeda", 94187, new List<Person>());

            district2.AddHero(hero1);
            district2.AddHero(hero2);
            district2.AddHero(hero4);
            district1.AddHero(hero3);
            district1.AddHero(hero5);
            district1.AddHero(hero6);
            district1.AddHero(hero7);

            Console.WriteLine();

            district1.PrintInformationAboutDistrict();
            Console.WriteLine();
            district2.PrintInformationAboutDistrict();

            Console.WriteLine();
            Console.WriteLine();

            var villains = new List<Villain>
            {
                new Villain("Arthur", "Fleck", "Joker", 1, 2),
                new Villain("Priscilla", "Rich", "Cheetah", 2, 4),
                new Villain("Lotso", "Huggin' Bear", "Furry Air Freshener", 3, 7),
            };
            
            var totalCrimeTime = 0;
            var worstCriminal = new Villain("", "", "", 0, 0);
            foreach (var villain in villains)
            {
                totalCrimeTime += villain.CrimeTime;
                
                if (worstCriminal.CrimeTime < villain.CrimeTime)
                {
                    worstCriminal = villain;
                }
            }
            Console.WriteLine($"Total crime time of all {villains.Count} villains is {totalCrimeTime} hours.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"The worst criminal is: \n{worstCriminal.PrintInfo()}");

            /*
            int worstCriminalIndex = 0;
            int worstCriminalCrimeTime = 0;
            for (int i = 0; i < villains.Count; i++)
            {
                var villain = villains[i];
                if (villain.CrimeTime > worstCriminalCrimeTime)
                {
                    worstCriminalIndex = i;
                    worstCriminalCrimeTime = villain.CrimeTime;
                }
            }
            */
        }
    }
}
