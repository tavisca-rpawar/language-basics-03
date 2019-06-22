using System;
using System.Collections.Generic;
namespace dir3
{
    class Program
    {
        static List<int> find_carbs(List<int> l, int[] carbs)
        {
            int leng = l.Count;
            int minn = 999999;
            for (int i = 0; i < leng; i++)
            {
                if (minn > carbs[l[i]])
                {
                    minn = carbs[l[i]];
                }
            }
            List<int> n = new List<int>();
            for (int i = 0; i < leng; i++)
            {
                if (carbs[l[i]] == minn)
                    n.Add(l[i]);
            }
            return n;
        }
        static List<int> find_proteins(List<int> l, int[] proteins)
        {
            int leng = l.Count;
            int minn = 999999;
            for (int i = 0; i < leng; i++)
            {
                if (minn > proteins[l[i]])
                {
                    minn = proteins[l[i]];
                }
            }
            List<int> n = new List<int>();
            for (int i = 0; i < leng; i++)
            {
                if (proteins[l[i]] == minn)
                    n.Add(l[i]);
            }
            return n;
        }
        static List<int> find_fats(List<int> l, int[] fats)
        {
            int leng = l.Count;
            int minn = 999999;
            for (int i = 0; i < leng; i++)
            {
                if (minn > fats[l[i]])
                {
                    minn = fats[l[i]];
                }
            }
            List<int> n = new List<int>();
            for (int i = 0; i < leng; i++)
            {
                if (fats[l[i]] == minn)
                    n.Add(l[i]);
            }
            return n;
        }
        static List<int> find_calories(List<int> l, int[] calories)
        {
            int leng = l.Count;
            int minn = 999999;
            for (int i = 0; i < leng; i++)
            {
                if (minn > calories[l[i]])
                {
                    minn = calories[l[i]];
                }
            }
            List<int> n = new List<int>();
            for (int i = 0; i < leng; i++)
            {
                if (calories[l[i]] == minn)
                    n.Add(l[i]);
            }
            return n;
        }
        static List<int> find_Carbs(List<int> l, int[] Carbs)
        {
            int leng = l.Count;
            int maxx = 0;
            for (int i = 0; i < leng; i++)
            {
                if (maxx < Carbs[l[i]])
                {
                    maxx = Carbs[l[i]];
                }
            }
            List<int> n = new List<int>();
            for (int i = 0; i < leng; i++)
            {
                if (Carbs[l[i]] == maxx)
                    n.Add(l[i]);
            }
            return n;
        }
        static List<int> find_Proteins(List<int> l, int[] Proteins)
        {
            int leng = l.Count;
            int maxx = 0;
            for (int i = 0; i < leng; i++)
            {
                if (maxx < Proteins[l[i]])
                {
                    maxx = Proteins[l[i]];
                }
            }
            List<int> n = new List<int>();
            for (int i = 0; i < leng; i++)
            {
                if (Proteins[l[i]] == maxx)
                    n.Add(l[i]);
            }
            return n;
        }
        static List<int> find_Fats(List<int> l, int[] Fats)
        {
            int leng = l.Count;
            int maxx = 0;
            for (int i = 0; i < leng; i++)
            {
                if (maxx < Fats[l[i]])
                {
                    maxx = Fats[l[i]];
                }
            }
            List<int> n = new List<int>();
            for (int i = 0; i < leng; i++)
            {
                if (Fats[l[i]] == maxx)
                    n.Add(l[i]);
            }
            return n;
        }
        static List<int> find_Calories(List<int> l, int[] Calories)
        {
            int leng = l.Count;
            int maxx = 0;
            for (int i = 0; i < leng; i++)
            {
                if (maxx < Calories[l[i]])
                {
                    maxx = Calories[l[i]];
                }
            }
            List<int> n = new List<int>();
            for (int i = 0; i < leng; i++)
            {
                if (Calories[l[i]] == maxx)
                    n.Add(l[i]);
            }
            return n;
        }
        static List<int> SelectMeals(int[] Proteins, int[] Carbs, int[] Fats, string[] dietPlan)
        {
            int leng = dietPlan.Length;
            int lengg = Proteins.Length;
            int[] Calories = new int[lengg];
            List<int> l = new List<int>();
            for (int i = 0; i < lengg; i++)
            {
                l.Add(i);
            }
            List<int> newl = new List<int>();
            for (int i = 0; i < lengg; i++)
            {
                newl.Add(i);
            }
            for (int i = 0; i < lengg; i++)
            {
                Calories[i] = (9 * Fats[i]) + (5 * Carbs[i]) + (5 * Proteins[i]);
            }
            List<int> ans = new List<int>();
            for (int i = 0; i < leng; i++)
            {
                l = newl;
                for (int j = 0; j < dietPlan[i].Length; j++)
                {
                    if (dietPlan[i][j] == 't')
                    {
                        l = find_calories(l, Calories);
                    }
                    else if (dietPlan[i][j] == 'c')
                    {
                        l = find_carbs(l, Carbs);
                    }
                    else if (dietPlan[i][j] == 'p')
                    {
                        l = find_proteins(l, Proteins);
                    }
                    else if (dietPlan[i][j] == 'f')
                    {
                        l = find_fats(l, Fats);
                    }
                    else if (dietPlan[i][j] == 'T')
                    {
                        l = find_Calories(l, Calories);
                    }
                    else if (dietPlan[i][j] == 'C')
                    {
                        l = find_Carbs(l, Carbs);
                    }
                    else if (dietPlan[i][j] == 'P')
                    {
                        l = find_Proteins(l, Proteins);
                    }
                    else if (dietPlan[i][j] == 'F')
                    {
                        l = find_Fats(l, Fats);
                    }
                }
                ans.Add(l[0]);
            }
            return ans;
        }
    }
}
