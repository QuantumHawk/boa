using System;
using System.Collections.Generic;

namespace economy
{
    public class Area
    {
        public Resourses resPrices = new Resourses();
        public Resourses resourses = new Resourses();

        public void ResPriceCalc()
        {
            PriceCalc("wood", "silver");
            PriceCalc("stone", "silver");
            PriceCalc("metal", "silver");
            PriceCalc("water", "silver");
            PriceCalc("food", "silver");
            PriceCalc("ore", "silver");
        }

        public void PriceCalc(string res, string money)
        {
            resPrices.SetRes(res, resourses.GetRes(money) / resourses.GetRes(res));
        }
    }

    public class World : Area
    {
        public List<Player> players = new List<Player>();
        public int day = 0;

        public World()
        {
            ResPriceCalc();
        }

        public void DayCalc()
        {
            foreach (Player player in players)
            {
                player.PlayerCalc();
            }

            Populate();
            ResPriceCalc();
            Calc.market.ResPriceCalc();
            day++;
        }

        public void Populate()
        {
            for (int i = 0; i < Calc.rnd.Next(1, 10); i++)
            {
                Player newplayer = new Player();
                players.Add(newplayer);
            }
        }
    }

    public class Biom : Area
    {

    }

    public class Market : Area
    {
        public Market()
        {
            resourses.AddRes("wood", 80000);
            resourses.AddRes("stone", 80000);
            resourses.AddRes("metal", 80000);
            resourses.AddRes("water", 40000);
            resourses.AddRes("food", 40000);
            resourses.AddRes("ore", 10000);
            resourses.AddRes("silver", 20000);

            ResPriceCalc();
        }
    }
}
