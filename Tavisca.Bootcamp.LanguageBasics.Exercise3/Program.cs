using System;
using System.Linq;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Test(
                new[] { 3, 4 }, 
                new[] { 2, 8 }, 
                new[] { 5, 2 }, 
                new[] { "P", "p", "C", "c", "F", "f", "T", "t" }, 
                new[] { 1, 0, 1, 0, 0, 1, 1, 0 });
            Test(
                new[] { 3, 4, 1, 5 }, 
                new[] { 2, 8, 5, 1 }, 
                new[] { 5, 2, 4, 4 }, 
                new[] { "tFc", "tF", "Ftc" }, 
                new[] { 3, 2, 0 });
            Test(
                new[] { 18, 86, 76, 0, 34, 30, 95, 12, 21 }, 
                new[] { 26, 56, 3, 45, 88, 0, 10, 27, 53 }, 
                new[] { 93, 96, 13, 95, 98, 18, 59, 49, 86 }, 
                new[] { "f", "Pt", "PT", "fT", "Cp", "C", "t", "", "cCp", "ttp", "PCFt", "P", "pCt", "cP", "Pc" }, 
                new[] { 2, 6, 6, 2, 4, 4, 5, 0, 5, 5, 6, 6, 3, 5, 6 });
            Console.ReadKey(true);
        }

        private static void Test(int[] protein, int[] carbs, int[] fat, string[] dietPlans, int[] expected)
        {
            var result = SelectMeals(protein, carbs, fat, dietPlans).SequenceEqual(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"Proteins = [{string.Join(", ", protein)}]");
            Console.WriteLine($"Carbs = [{string.Join(", ", carbs)}]");
            Console.WriteLine($"Fats = [{string.Join(", ", fat)}]");
            Console.WriteLine($"Diet plan = [{string.Join(", ", dietPlans)}]");
            Console.WriteLine(result);
        }
        public static List<int> find_carbs(List<int> l, int[] carbs)
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
        public static List<int> find_proteins(List<int> l, int[] proteins)
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
        public static List<int> find_fats(List<int> l, int[] fats)
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
        public static List<int> find_calories(List<int> l, int[] calories)
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
        public static List<int> find_Carbs(List<int> l, int[] Carbs)
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
        public static List<int> find_Proteins(List<int> l, int[] Proteins)
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
        public static List<int> find_Fats(List<int> l, int[] Fats)
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
        public static List<int> find_Calories(List<int> l, int[] Calories)
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
        public static int[] SelectMeals(int[] protein, int[] carbs, int[] fat, string[] dietPlans)
        {
            int leng = dietPlans.Length;
            int lengg = protein.Length;
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
                Calories[i] = (9 * fat[i]) + (5 * carbs[i]) + (5 * protein[i]);
            }
            List<int> ans = new List<int>();
            for (int i = 0; i < leng; i++)
            {
                l = newl;
                for (int j = 0; j < dietPlans[i].Length; j++)
                {
                    if (dietPlans[i][j] == 't')
                    {
                        l = find_calories(l, Calories);
                    }
                    else if (dietPlans[i][j] == 'c')
                    {
                        l = find_carbs(l, carbs);
                    }
                    else if (dietPlans[i][j] == 'p')
                    {
                        l = find_proteins(l, protein);
                    }
                    else if (dietPlans[i][j] == 'f')
                    {
                        l = find_fats(l, fat);
                    }
                    else if (dietPlans[i][j] == 'T')
                    {
                        l = find_Calories(l, Calories);
                    }
                    else if (dietPlans[i][j] == 'C')
                    {
                        l = find_Carbs(l, carbs);
                    }
                    else if (dietPlans[i][j] == 'P')
                    {
                        l = find_Proteins(l, protein);
                    }
                    else if (dietPlans[i][j] == 'F')
                    {
                        l = find_Fats(l, fat);
                    }
                }
                ans.Add(l[0]);
            }
            int[] ansAr = new int[ans.Count];
            for (int i = 0; i < ans.Count; i++)
                ansAr[i] = ans[i];
            return ansAr;
            throw new NotImplementedException();
        }
    }
}
