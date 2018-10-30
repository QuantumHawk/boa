using System;
using System.Collections.Generic;

namespace economy
{
    public class AI
    {
        public int a = 0; // для примера
        public string b = "0"; // для примера
    }

    public static class AIs
    {
        static List<AI> ais = new List<AI>();

        public static void GenerateAIs()
        {
            AI ai = new AI();

            ai.a = 1; // для примера
            ai.b = "2"; // для примера

            ais.Add(ai);
        }

        public static AI GetAI(int id)
        {
            return ais[id];
        }
    }
}
