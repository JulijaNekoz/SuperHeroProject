using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroProject
{
    internal class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Nickname { get; set; }

        public Person(string name, string surname, string nickname)
        {
            Name = name;
            Surname = surname;
            Nickname = nickname;
        }

        public virtual string PrintInfo() 
        {
            return Name + Surname;
        }
    }
    public enum HeroType
    {
        Hero,
        Villain
    }

    internal class Hero : Person
    {
        public int HeroId { get; set; }

        public HeroType Type { get; }

        public int DeedTime { get; set; }

        public Hero(string name, string surname, string nickname,
            int heroId, int deedTime) : base(name, surname, nickname)
        {
            Type = HeroType.Hero;
            HeroId = heroId;
            Type = HeroType.Hero;
            DeedTime = deedTime;
        }

        public override string PrintInfo()
        {
            return $" Name: {Name}\n Surname: {Surname}" +
                $"\n Nickname: {Nickname}\n HeroID: {HeroId} " +
                $"\n Type : {Type} \n Deedtime: {DeedTime} hours";
        }

        public int CalculateLevel()
        {
            int level = 0;
            if (DeedTime < 20)
            {
                level = 1;
            }
            if (DeedTime >= 20 && DeedTime <= 40)
            {
                level = 2;
            }
            if (DeedTime > 40)
            {
                level = 3;
            }

            return level;
        }
    }
    internal class Villain : Person
    {

        public int VillainId { get; set; }

        public HeroType Type { get; }

        public int CrimeTime { get; set; }

        public Villain(string name, string surname, string nickname,
            int villainId, int crimeTime) : base(name, surname, nickname)
        {
            Type = HeroType.Villain;
            VillainId = villainId;
            Type = HeroType.Villain;
            CrimeTime = crimeTime;
        }

        public override string PrintInfo()
        {
            return $" Name: {Name}\n Surname: {Surname}" +
                $"\n Nickname: {Nickname}\n VillainID: {VillainId} " +
                $"\n Type : {Type} \n Crimetime: {CrimeTime} hours";
        }
    }

}
