using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges
{
    class ProgramUI
    {
        public MenuRepository _repo = new MenuRepository();
        public void Run()
        {
            Menu();
            SeedContent();
        }
        public void SeedContent()
        {
            Menu happyMeal = new Menu();

        }
        public void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of the option you'd like to select:\n" +
                    "1. Show all items in menu\n" +
                    "2. Find item by title\n" +
                    "3. Add new item to menu\n" +
                    "4. Update existing menu\n" +
                    "5. Remove item from menu\n" +
                    "6. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        ShowMenuByItem();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                        continueToRun = false;
                    default:
                        Console.WriteLine("Please choose a valid option.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public void ShowAllItems()
        {
            Console.Clear();
            List<Menu> listOfContent = _repo.GetContents();
            foreach (Menu content in listOfContent)
            {
                DisplayContent(content);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        //public void UpdateExistingContent()
        public void CreateNewItem()
        {
            Console.Clear();
            Menu newContent = new Menu();
            Console.WriteLine("Please enter a meal name.");
            newContent.MealName = Console.ReadLine();
            Console.WriteLine("Please enter a description.");
            newContent.Description = Console.ReadLine();
            Console.WriteLine("Please enter what you would like on your meal.");
            newContent.Ingredients = Console.ReadLine();
            Console.WriteLine("Please enter an ID number for your meal.");
            string mealIDAsString = Console.ReadLine();
            double mealIDAsDouble = double.Parse(mealIDAsString);
            newContent.MealID = mealIDAsDouble;
            Console.WriteLine("Enter the price for this meal.");
            string priceAsString = Console.ReadLine();
            double priceAsDouble = double.Parse(priceAsString);

        }
        public void DisplayContent(Menu content)
        {
            Console.WriteLine($"MealName: {content.MealName}");
            Console.WriteLine($"Description: {content.Description}");
            Console.WriteLine($"Ingredients: {content.Ingredients}");
            Console.WriteLine($"MealId: {content.MealID}");
            Console.WriteLine($"Price: {content.Price}");
        }
        public void ShowMenuByItem()
        {
            Console.Clear();
            Console.WriteLine("Enter the item from the menu you'd like to see.");
            string item = Console.ReadLine();
            Menu content = _repo.GetContentByMealName(item);
            if (content != null)
            {
                DisplayContent(content);
            }
            else
            {
                Console.WriteLine("That item doesn't exist");
            }
        }
    }
}