using System;
using System.Linq;
using System.Collections.Generic;

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
        public static int GetMeals(string dietPlan, int[] protein, int[] carbs, int[] fat, int[] calories)
        {
            int val;
            List<int> item =new List<int>();
            for (int i = 0; i < fat.Length; i++){
                item.Add(i);
            }
            foreach(var x in dietPlan)
            {
                switch( x )
                {
                    case 'P' : 
                        val = FIndMax(protein, item); 
                        item = indices( protein, item, val ); break;
                    case 'p' : 
                        val = FIndMin(protein, item);
                        item = indices( protein, item, val); break;
                    case 'C' : 
                        val = FIndMax(carbs, item);
                        item = indices( carbs, item, val); break;
                    case 'c' : 
                        val = FIndMin(carbs, item);
                        item = indices( carbs, item, val); break;
                    case 'F' : 
                        val = FIndMax(fat, item);
                        item = indices( fat, item, val); break;
                    case 'f' : 
                        val =  FIndMin(fat, item);
                        item = indices( fat, item, val); break;
                    case 'T' : 
                        val = FIndMax(calories, item);
                        item = indices( calories, item, val); break;
                    case 't' : 
                        val = FIndMin(calories, item);
                        item = indices( calories, item, val); break;
                }
            }
            return item[0];
        }
        // To find the index of the val
        public static List<int> indices(int[] arr, List<int> item, int val) {
            List<int> temp = new List<int>();
            foreach (var i in item)
            {
                if (arr[i] == val)
                    temp.Add(i);
            }
            return temp;
        }
        // To find the maximum value of respective item among all
        private static int FIndMax(int[] arr, List<int> item)
        {
            int max= arr[item[0]];
            for(int i = 1 ; i < item.Count ; i++)
            {
                if(arr[item[i]] > max)
                    max= arr[item[i]];
            }          
            return max;
        }
        // To find the minimum value of respective item among all
        private static int FIndMin(int[] arr, List<int> item)
        {
            int min= arr[item[0]];
            for(int i = 1 ; i < item.Count ; i++)
            {
                if(arr[item[i]] < min)
                    min= arr[item[i]];
            }
            return min;
        }     
        public static int[] SelectMeals(int[] protein, int[] carbs, int[] fat, string[] dietPlans)
        {
            //Add  your code here.
            int[] calories = new int[protein.Length];
            int[] result = new int[dietPlans.Length];
            for(int i = 0; i < protein.Length; i++)
                calories[i] = ( protein[i] + carbs[i] ) * 5 + fat[i] *9 ;
            for(int i = 0; i < dietPlans.Length; i++)
                result[i] = GetMeals(dietPlans[i], protein, carbs, fat, calories);
            return result;
            throw new NotImplementedException();
        }        
    }
}

