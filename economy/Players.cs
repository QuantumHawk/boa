using System;
using System.Collections.Generic;

namespace economy
{
    public class Player
    {
        public Resourses resourses = new Resourses();
        public int day;
        public int level;
        public AI ai = new AI();

        public Player()
        {
            level = 1;
            day = Calc.world.day;
            ai = AIs.GetAI(Calc.rnd.Next(0, 0));
        }

        public void PlayerCalc()
        {
            foreach (string res in resourses.GetResList())
            {
                double q = Constants.GetResIncome(res, level);
                resourses.AddRes(res, q);
                Calc.world.resourses.AddRes(res, q);
            }

            if(Calc.rnd.NextDouble() >= 0.8) level++;
        }
    }
}
