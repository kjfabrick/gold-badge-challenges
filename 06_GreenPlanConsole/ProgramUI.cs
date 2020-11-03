using _06_GreenPlanRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _06_GreenPlanRepository.GreenPlan_Repo;

namespace _06_GreenPlanConsole
{
    public class ProgramUI
    {
        public GreenPlanContent_Repo _repo = new GreenPlanContent_Repo();
        public void Run()
        {
            Menu();
        }
        public void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Enter the option you'dlike to selec:\n" +
                    "1.View customer database\n" +
                    "2.Find customer by name\n" +
                    "3.Add new customer\n" +
                    "4.Update customer profile\n" +
                    "5 Delete customer profile\n" +
                    "6.Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ShowAllCustomers();
                        break;
                    case "2":
                        FindCustomerByName();
                        break;
                    case "3":
                        AddNewCustomer();
                        break;
                    case "4":
                        UpdateExistingContent();
                        break;
                    case "5":
                        // DeleteCustomer();
                        break;
                    case "6":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public void ShowAllCustomers()
        {
            Console.Clear();
            List<GreenPlanContent_Repo> listOfContent = _repo.GetContents();
            foreach (GreenPlanContent_Repo content in listOfContent)
            {
                DisplayContent(content);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        public void UpdateExistingContent()
        {

            Console.Clear();
            Console.WriteLine("Enter the name of the person's data you'd like to update.");
            string firstName = Console.ReadLine();
            object hybridCar = null;
            GreenPlanContent_Repo oldItem = _repo.FindCarByName(hybridCar);
            if (oldItem == null)
            {
                Console.WriteLine("Person not found, press any key to continue...");
                Console.ReadKey();
                return;
            }
            GreenPlanContent_Repo newItem = new GreenPlanContent_Repo();
                oldItem.HybridCar
                oldItem.ElectricCar;
            Console.WriteLine("Which property would you like to update:\n" +
                    "1. Hybrid Car\n" +
                    "2. Electric Car\n" +
                    "6. Nevermind");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Enter a new title");
                    string newFirstName = Console.ReadLine();
                    newItem.HybridCar = new hybridCar;
                    bool wasSuccessful = _repo.UpdateExistingContent(hybridCar, newCar);
                    if (wasSuccessful)
                    {
                        Console.WriteLine("Name successfully updated");
                    }
                    else
                    {
                        Console.WriteLine($"Error: Could not update {hybridCar}");
                    }
                    break;
                default:
                    break;
            }

        }
        public void AddNewCustomer()
        {
            Console.Clear();
            GreenPlanContent_Repo newContent = new GreenPlanContent_Repo();
            Console.WriteLine("Please enter a hybrid car.");
            newContent.HybridCar = Console.ReadLine();
            Console.WriteLine("Please enter an electric car.");
            newContent.ElectricCar = Console.ReadLine();
            Console.WriteLine("Please enter a type for this car.");
        }
        public void FindCustomerByName()
        {
            Console.Clear();

            Console.WriteLine("Enter the name of the person you'd like to find.");
            string hybridCar = Console.ReadLine();

            GreenPlanContent_Repo content = _repo.FindCarByName(hybridCar);

            if (content != null)
            {
                DisplayContent(content);
            }
            else
            {
                Console.WriteLine("That person doesn't exist");
            }
        }

        private void DisplayContent(GreenPlanContent_Repo content)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomerByName()
        {
            Console.WriteLine("Enter the name of the person you would like to delete");
            string firstNameToDelete = Console.ReadLine();

            GreenPlanContent contentToDelete = _repo.FindPersonByName(firstNameToDelete);
            bool wasDeleted = _repo.DeleteCustomerByName(contentToDelete);

            if (wasDeleted)
            {
                Console.WriteLine("This content was successfully deleted");
            }
            else
            {
                Console.WriteLine("Content could not be deleted");
            }
        }
        public void DisplayContent(GreenPlanContent content)
        {
            Console.WriteLine($"Title: {content.HybridCar}");
            Console.WriteLine($"Description: {content.ElectricCar}");

        }
    }
}
