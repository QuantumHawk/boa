using System;
using System.Collections.Generic;

namespace economy
{
    public class AI
    {

    }

    public static class AIs
    {
        static List<AI> ais = new List<AI>();

        public static void GenerateAIs()
        {
            AI ai = new AI();
            ais.Add(ai);
        }

        public static AI GetAI(int id)
        {
            return ais[id];
        }
    }
}
