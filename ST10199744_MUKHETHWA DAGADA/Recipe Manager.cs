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
        int counts = 0;
        int size = 0;
        int zero = 1;
        public static double totalCalorie()
        {
            double total = 0;
            for (int i = 0; i < Caleriescounts.Count; i++)
            {
                total += Caleriescounts[i];
            }


            if (total > 300)
            {

                Console.WriteLine("number of calories have exceeded the maximum");
            }
            else
            {
                Console.WriteLine("total number of calories is " + total);
            }
            return total;
        }
        //
        private delegate void NotifyExceededCalories(int totalCalories);

        public RecipeManager()
        {

        }

        public void EnterRecipeDetails()
        {
            Console.Write("Enter recipe name: ");
            string name = Console.ReadLine();
            Recipename.Add(name);



            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());

            size = ingredientCount;

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Enter details for ingredient #{i + 1}");
                Console.Write("Name: ");
                string ingredientName = Console.ReadLine();
                Ingredientname.Add(ingredientName);


                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                IngredientQuantity.Add(quantity);

                Console.Write("Unit of measurement: ");
                string unit = Console.ReadLine();
                Ingredientunits.Add(unit);




                Console.WriteLine("Choose the food group:");

                Console.WriteLine("1.Dairy \n" + "2.Starch \n" + "3.Vegetables \n" + "4.Grains \n" + "5.Proteins");

                int food = int.Parse(Console.ReadLine());


                zero++;
                if (food == 1)
                {
                    group = "Dairy";
                }
                else if (food == 2)
                {
                    group = "Stach";
                }
                if (food == 3)
                {
                    group = "Vegetables";
                }
                if (food == 4)
                {
                    group = "Grains";
                }
                if (food == 5)
                {
                    group = "Protein";
                }

                Foodgroup.Add(group);





                Console.Write("Enter the number of calories: ");
                int Count = int.Parse(Console.ReadLine());
                Caleriescounts.Add(Count);
            }

            Console.Write("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Enter step #{i + 1}");
                string step = Console.ReadLine();
                steps.Add(step);
            }


            Console.WriteLine("Recipe added successfully!");
        }
    }
}