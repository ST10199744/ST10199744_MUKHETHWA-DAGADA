using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace Dagada_Mukhethwa_ST10199744
    {
        internal class RecipeManager
        {
            //for group
            public string group = "";
            public int count;




            private static List<string> Recipename = new List<string>();
            private static List<string> Ingredientname = new List<string>();
            private static List<int> Caleriescounts = new List<int>();
            private static List<string> Foodgroup = new List<string>();
            private static List<string> Recipedetails = new List<string>();
            private static List<string> steps = new List<string>();
            private static List<string> Ingredients = new List<string>();
            private static List<double> IngredientQuantity = new List<double>();
            private static List<string> Ingredientunits = new List<string>();