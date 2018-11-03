using System;
using System.Collections.Generic;

namespace economy
{
    public class Calc
    {
        public static Random rnd = new Random();
        public static World world = new World();
        public static Market market = new Market();

        public static void Main(string[] args)
        {
            string str;

            AIs.GenerateAIs();

            for (int i = 0; i < 10; i++)
            {
                world.DayCalc();

                str = "World prices: ";
                foreach (string res in world.resPrices.GetResList())
                {
                    str += res + " " + world.resPrices.GetRes(res) + ", ";
                }
                Console.WriteLine(str);
                str = "Market prices: ";
                foreach (string res in market.resPrices.GetResList())
                {
                    str += res + " " + market.resPrices.GetRes(res) + ", ";
                }
                Console.WriteLine(str);
            }

            int j = 0;
            foreach (Player player in world.players)
            {
                str = "Player #" + j + ": regday " + player.day + ", level " + player.level + ", ";
                foreach (string res in player.resourses.GetResList())
                {
                    str += res + " " + player.resourses.GetRes(res) + ", ";
                }
                Console.WriteLine(str);

                j++;
            }

            str = "World: ";
            foreach (string res in world.resourses.GetResList())
            {
                str += res + " " + world.resourses.GetRes(res) + ", ";
            }
            Console.WriteLine(str);
        }
    }
}
