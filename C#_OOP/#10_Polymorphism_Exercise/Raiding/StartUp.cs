﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();

            int numberOfHeroes = int.Parse(Console.ReadLine());

            while (heroes.Count != numberOfHeroes)
            {
                string name = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (heroType == "Paladin")
                {
                    heroes.Add(new Paladin(name));
                }
                else if (heroType == "Druid")
                {
                    heroes.Add(new Druid(name));
                }
                else if (heroType == "Rogue")
                {
                    heroes.Add(new Rogue(name));
                }
                else if (heroType == "Warrior")
                {
                    heroes.Add(new Warrior(name));
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            int heroPowerSum = heroes.Sum(x => x.Power);

            if (heroPowerSum >= bossPower)
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
