using System;
using System.Collections.Generic;

namespace economy
{
    public static class Constants
    {
        static Dictionary<string, double> resBase = new Dictionary<string, double>
        {
            {"wood", 800},
            {"stone", 800},
            {"metal", 800},
            {"water", 400},
            {"food", 400},
            {"ore", 100},
            {"silver", 200},
            {"gold", 0}
        };

        public static double GetResBase(string res)
        {
            return resBase[res];
        }

        public static Dictionary<string, Dictionary<int, double>> resIncome = new Dictionary<string, Dictionary<int, double>>
        {
            {"wood", new Dictionary<int, double>{{1, resBase["wood"] * 1 },{ 2, resBase["wood"] * 2 },{ 3, resBase["wood"] * 3 },{ 4, resBase["wood"] * 4 },{ 5, resBase["wood"] * 5 } }},
            {"stone", new Dictionary<int, double>{{1, resBase["stone"] * 1 },{ 2, resBase["stone"] * 2 },{ 3, resBase["stone"] * 3 },{ 4, resBase["stone"] * 4 },{ 5, resBase["stone"] * 5 } }},
            {"metal", new Dictionary<int, double>{{1, resBase["metal"] * 1 },{ 2, resBase["metal"] * 2 },{ 3, resBase["metal"] * 3 },{ 4, resBase["metal"] * 4 },{ 5, resBase["metal"] * 5 } }},
            {"water", new Dictionary<int, double>{{1, resBase["water"] * 1 },{ 2, resBase["water"] * 2 },{ 3, resBase["water"] * 3 },{ 4, resBase["water"] * 4 },{ 5, resBase["water"] * 5 } }},
            {"food", new Dictionary<int, double>{{1, resBase["food"] * 1 },{ 2, resBase["food"] * 2 },{ 3, resBase["food"] * 3 },{ 4, resBase["food"] * 4 },{ 5, resBase["food"] * 5 } }},
            {"ore", new Dictionary<int, double>{{1, resBase["ore"] * 1 },{ 2, resBase["ore"] * 2 },{ 3, resBase["ore"] * 3 },{ 4, resBase["ore"] * 4 },{ 5, resBase["ore"] * 5 } }},
            {"silver", new Dictionary<int, double>{{1, resBase["silver"] * 1 },{ 2, resBase["silver"] * 2 },{ 3, resBase["silver"] * 3 },{ 4, resBase["silver"] * 4 },{ 5, resBase["silver"] * 5 } }},
            {"gold", new Dictionary<int, double>{{1, resBase["gold"] * 1 },{ 2, resBase["gold"] * 2 },{ 3, resBase["gold"] * 3 },{ 4, resBase["gold"] * 4 },{ 5, resBase["gold"] * 5 } }}
        };

        public static double GetResIncome(string res, int level)
        {
            return resIncome[res][level];
        }
    }
}
