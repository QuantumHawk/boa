using System;
using System.Collections.Generic;

namespace economy
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            World world = new World();
            Market market = new Market();
            world.Populate();
        }
    }

    public class World
    {
        public List<Player> players = new List<Player>();

        public Resourses resourses = new Resourses();

        public void Populate()
        {
            Player newplayer = new Player();
            players.Add(newplayer);
        }
    }

    public class Market
    {
        public Resourses resourses = new Resourses();
    }

    public class Player
    {
        public Resourses resourses = new Resourses();

        public int level = 1;

        public AI ai = new AI();

        public Player()
        {
            resourses.AddRes("wood", Constants.income["wood"][level]);
            Console.WriteLine(resourses.GetRes("wood"));
        }
    }

    public class Resourses
    {
        private Dictionary<string, int> resourses = new Dictionary<string, int>
        {
            {"wood", 0},
            {"stone", 0},
            {"metal", 0},
            {"water", 0},
            {"food", 0},
            {"ore", 0},
            {"silver", 0},
            {"gold", 0}
        };

        public int GetRes(string res)
        {
            return resourses[res];
        }

        public void AddRes(string res, int q)
        {
            resourses[res] += q;
        }

        public void RemoveRes(string res, int q)
        {
            resourses[res] -= q;
            if (resourses[res] < 0) resourses[res] = 0;
        }
    }

    public static class Constants
    {
        public static Dictionary<string, int> resBase = new Dictionary<string, int>
        {
            {"wood", 800},
            {"stone", 800},
            {"metal", 800},
            {"water", 400},
            {"food", 400},
            {"ore", 100},
            {"silver", 200},
            {"gold", 1}
        };

        public static Dictionary<string, Dictionary<int, int>> income = new Dictionary<string, Dictionary<int, int>>
        {
            {"wood", new Dictionary<int, int>{{1, resBase["wood"] * 1 },{ 2, resBase["wood"] * 2 },{ 3, resBase["wood"] * 3 },{ 4, resBase["wood"] * 4 },{ 5, resBase["wood"] * 5 } }},
            {"stone", new Dictionary<int, int>{{1, resBase["stone"] * 1 },{ 2, resBase["stone"] * 2 },{ 3, resBase["stone"] * 3 },{ 4, resBase["stone"] * 4 },{ 5, resBase["stone"] * 5 } }},
            {"metal", new Dictionary<int, int>{{1, resBase["metal"] * 1 },{ 2, resBase["metal"] * 2 },{ 3, resBase["metal"] * 3 },{ 4, resBase["metal"] * 4 },{ 5, resBase["metal"] * 5 } }},
            {"water", new Dictionary<int, int>{{1, resBase["water"] * 1 },{ 2, resBase["water"] * 2 },{ 3, resBase["water"] * 3 },{ 4, resBase["water"] * 4 },{ 5, resBase["water"] * 5 } }},
            {"food", new Dictionary<int, int>{{1, resBase["food"] * 1 },{ 2, resBase["food"] * 2 },{ 3, resBase["food"] * 3 },{ 4, resBase["food"] * 4 },{ 5, resBase["food"] * 5 } }},
            {"ore", new Dictionary<int, int>{{1, resBase["ore"] * 1 },{ 2, resBase["ore"] * 2 },{ 3, resBase["ore"] * 3 },{ 4, resBase["ore"] * 4 },{ 5, resBase["ore"] * 5 } }},
            {"silver", new Dictionary<int, int>{{1, resBase["silver"] * 1 },{ 2, resBase["silver"] * 2 },{ 3, resBase["silver"] * 3 },{ 4, resBase["silver"] * 4 },{ 5, resBase["silver"] * 5 } }},
            {"gold", new Dictionary<int, int>{{1, resBase["gold"] * 1 },{ 2, resBase["gold"] * 2 },{ 3, resBase["gold"] * 3 },{ 4, resBase["gold"] * 4 },{ 5, resBase["gold"] * 5 } }}
        };
    }

    public class AI
    {

    }
}
