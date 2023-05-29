using Dagada_Mukhethwa_ST10199744;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10199744_MUKHETHWA_DAGADA
{
  
        class Program
        {
            static void Main(string[] args)
            {
                RecipeManager recipeManager = new RecipeManager();
                bool exit = false;

                while (!exit)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("==================================================");
                    Console.WriteLine("Recipe App");
                    Console.WriteLine("==================================================");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("1. Enter a new recipe");
                    Console.WriteLine("2. Display recipe");
                    Console.WriteLine("3. Scale recipe");
                    Console.WriteLine("4. Reset quantities");
                    Console.WriteLine("5. Clear all data");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("===================================================");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            recipeManager.EnterRecipeDetails();
                            break;
                        case "2":
                            recipeManager.DisplayRecipe();
                            break;
                        case "3":
                            recipeManager.ScaleRecipe();
                            break;
                        case "4":
                            recipeManager.ResetQuantities();
                            break;
                        case "5":
                            recipeManager.ClearData();
                            break;
                        case "6":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;

                    }
                }
            }
        }
    }

