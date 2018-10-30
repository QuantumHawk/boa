using System;
using System.Collections.Generic;

namespace economy
{
    public class Resourses
    {
        Dictionary<string, double> resourses = new Dictionary<string, double>
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

        public double GetRes(string res)
        {
            return resourses[res];
        }

        public void AddRes(string res, double q)
        {
            resourses[res] += q;
        }

        public void SetRes(string res, double q)
        {
            resourses[res] = q;
        }

        public void RemoveRes(string res, double q)
        {
            resourses[res] -= q;
            if (resourses[res] < 0) resourses[res] = 0;
        }

        public List<string> GetResList()
        {
            List<string> l = new List<string>();
            foreach(string res in resourses.Keys)
            {
                l.Add(res);
            }
            return l;
        }
    }
}
