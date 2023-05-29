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


        public void DisplayRecipe()
        {
            //if (Recipename != null)
            //{
            Console.ForegroundColor = ConsoleColor.Red;
            Recipename.Sort();
            for (int i = 0; i < Recipename.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + Recipename[i]);
            }
            //Console.WriteLine("Enter the name of recipe you want to view");
            //int ans = int.Parse(Console.ReadLine());

            Console.WriteLine("ENTER THE NAME OF RECIPE YOU WANT TO DISPLAY");
            string name = Console.ReadLine();

            Console.WriteLine((1) + "Recipe name:" + name);
            for (int m = 0; m < Ingredientname.Count; m++)
            {
                //if (Ingredientname.Contains(name) && Foodgroup.Contains(name))
                // {


                Console.WriteLine("Ingredient name: " + Ingredientname[m]);
                Console.WriteLine("Ingredient Quantity: " + IngredientQuantity[m]);
                Console.WriteLine("Ingredient unit " + Ingredientunits[m]);
                Console.WriteLine("Food group: " + Foodgroup[m]);
                Console.WriteLine("Caleries:" + Caleriescounts[m]);
                Console.WriteLine("total calories" + (Caleriescounts[m] + Caleriescounts[m]));








                for (int sps = 0; sps < steps.Count; sps++)
                {

                    Console.WriteLine((sps + 1) + ": " + steps[sps]);
                }

                //}
                //else
                //{
                //    Console.WriteLine("No recipe to display. Please enter a recipe first.");
            }
        }

        public void ScaleRecipe()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("====================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wtite your scale as \n-|>for half,enter 1\n-|>for double enter 2\n-|>for thriple, enter 3");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("=============================================");
            Console.ForegroundColor = ConsoleColor.White;

            String chose = Console.ReadLine();


            if (chose == "1")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("=============================================");
                Console.WriteLine("scale recipe");
                Console.WriteLine("=============================================");
                Console.ForegroundColor = ConsoleColor.White;
                for (int c = 1; c < Recipename.Count; c++)
                {

                    Console.WriteLine((c) + ": " + Recipename[c]);


                }
                //select the number to display names
                string prompt_number = "";
                string get_name = "";
                do
                {


                    //prompt the user for number
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("=============================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("choose recipe");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("=============================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    prompt_number = Console.ReadLine();

                    //get to search if theres number not letters
                    if (!Regex.IsMatch(prompt_number, @"^\d+$"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("=============================================");
                        Console.WriteLine("enter a digits");
                        Console.WriteLine("=============================================");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        //get the name
                        get_name = Recipename[int.Parse(prompt_number)];

                    }

                } while (!Regex.IsMatch(prompt_number, @"^\d+$"));


                Console.ForegroundColor = ConsoleColor.White;

                //output using the ingredient generic
                for (int x = 0; x < Ingredientname.Count; x++)
                {

                    //compare or check
                    if (Ingredientname[x].Contains(get_name))
                    {




                        IngredientQuantity[x] = IngredientQuantity[x] * 0.5;


                    }


                }
                Console.WriteLine("=============================================");
                Console.WriteLine(" scale done");
                Console.WriteLine("=============================================");
            }
            else if (chose == "2")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("=============================================");
                Console.WriteLine("scale recipe");
                Console.WriteLine("=============================================");
                Console.ForegroundColor = ConsoleColor.White;
                for (int c = 1; c < Recipename.Count; c++)
                {

                    Console.WriteLine((c) + ": " + Recipename[c]);


                }
                //select the number to display names
                string prompt_number = "";
                string get_name = "";
                do
                {


                    //prompt the user for number
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("=============================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("choose recipe");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("=============================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    prompt_number = Console.ReadLine();

                    //get to search if theres number not letters
                    if (!Regex.IsMatch(prompt_number, @"^\d+$"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("=============================================");
                        Console.WriteLine("enter a digits");
                        Console.WriteLine("=============================================");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        //get the name
                        get_name = Recipename[int.Parse(prompt_number)];

                    }

                } while (!Regex.IsMatch(prompt_number, @"^\d+$"));


                Console.ForegroundColor = ConsoleColor.White;

                //output using the ingredient generic
                for (int x = 0; x < Ingredientname.Count; x++)
                {

                    //compare or check
                    if (Ingredientname[x].Contains(get_name))
                    {




                        IngredientQuantity[x] = IngredientQuantity[x] * 2;


                    }


                }
                Console.WriteLine("=============================================");
                Console.WriteLine(" scale done");
                Console.WriteLine("=============================================");
            }
            else if (chose == "3")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("=============================================");
                Console.WriteLine("scale recipe");
                Console.WriteLine("=============================================");
                Console.ForegroundColor = ConsoleColor.White;
                for (int c = 1; c < Recipename.Count; c++)
                {

                    Console.WriteLine((c) + ": " + Recipename[c]);


                }
                //select the number to display names
                string prompt_number = "";
                string get_name = "";
                do
                {


                    //prompt the user for number
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("=============================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("choose recipe");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("=============================================");
                    Console.ForegroundColor = ConsoleColor.White;
                    prompt_number = Console.ReadLine();

                    //get to search if theres number not letters
                    if (!Regex.IsMatch(prompt_number, @"^\d+$"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("=============================================");
                        Console.WriteLine("enter a digits");
                        Console.WriteLine("=============================================");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        //get the name
                        get_name = Recipename[int.Parse(prompt_number)];

                    }

                } while (!Regex.IsMatch(prompt_number, @"^\d+$"));


                Console.ForegroundColor = ConsoleColor.White;

                //output using the ingredient generic
                for (int x = 0; x < Ingredientname.Count; x++)
                {

                    //compare or check
                    if (Ingredientname[x].Contains(get_name))
                    {




                        IngredientQuantity[x] = IngredientQuantity[x] * 3;


                    }


                }
                Console.WriteLine("=============================================");
                Console.WriteLine(" scale done");
                Console.WriteLine("=============================================");
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}