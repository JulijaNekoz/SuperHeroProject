using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroProject
{
    internal class District
    {
        public string Title { get; set; }

        public string City { get; set; }

        public int DistrinctId { get; set; }

        public List<Person> HeroesInTheDistrict { get; set; }


        public District(string title, string city, int distrinctId, List<Person> heroesInTheDistrict)
        {
            Title = title;
            City = city;
            DistrinctId = distrinctId;
            HeroesInTheDistrict = heroesInTheDistrict;
        }

        public void AddHero(Person hero)
        {
            Console.WriteLine($"We added the person {hero.Nickname} to District {Title} of {City}.");
            HeroesInTheDistrict.Add(hero);
        }

        public void RemoveHero(int position)
        {
            Console.WriteLine($"We removed the person {HeroesInTheDistrict[position].Name} from District {Title}");
            HeroesInTheDistrict.RemoveAt(position);
        }

        public float CalculateAvgLevelInDistrict()
        {
            float totalHeroLevel = 0f;
            foreach (Hero hero in HeroesInTheDistrict)
            {
                totalHeroLevel += hero.CalculateLevel();
            }
            float averageLevelInDistrict = totalHeroLevel / HeroesInTheDistrict.Count;

            return averageLevelInDistrict;
        }

        public void PrintInformationAboutDistrict()
        {
            Console.WriteLine($"======={City}=======");
            Console.WriteLine();
            Console.WriteLine($"District: {Title}");
            Console.WriteLine($"Id : {DistrinctId}");
            Console.WriteLine();
            Console.WriteLine($"Heroes:");
            foreach (Hero hero in HeroesInTheDistrict)
            {
                Console.WriteLine(hero.PrintInfo());
            }
        }
    }
}
