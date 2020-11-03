using CustomerContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GreetingChallengeConsole
{
    class ProgramUI
    {
        public CustomerContent_Repo _repo = new CustomerContent_Repo();
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
            List<CustomerContent> listOfContent = _repo.GetContents();
            foreach (CustomerContent content in listOfContent)
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
            CustomerContent oldItem = _repo.FindPersonByName(firstName);
            if (oldItem == null)
            {
                Console.WriteLine("Person not found, press any key to continue...");
                Console.ReadKey();
                return;
            }
            CustomerContent newItem = new CustomerContent(
                oldItem.FirstName,
                oldItem.LastName,
                oldItem.Type,
                oldItem.Email
            );
            Console.WriteLine("Which property would you like to update:\n" +
                    "1. First Name\n" +
                    "2. Last Name\n" +
                    "3. Type\n" +
                    "4. Email Message\n" +
                    "6. Nevermind");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Enter a new title");
                    string newFirstName = Console.ReadLine();
                    newItem.FirstName = newFirstName;
                    bool wasSuccessful = _repo.UpdateExistingContent(firstName, newItem);
                    if (wasSuccessful)
                    {
                        Console.WriteLine("Name successfully updated");
                    }
                    else
                    {
                        Console.WriteLine($"Error: Could not update {firstName}");
                    }
                    break;
                default:
                    break;
            }

        }
        public void AddNewCustomer()
        {
            Console.Clear();
            CustomerContent newContent = new CustomerContent();
            Console.WriteLine("Please enter a first name.");
            newContent.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter a last name.");
            newContent.LastName = Console.ReadLine();
            Console.WriteLine("Please enter a type for this customer.");
            newContent.Type = Console.ReadLine();
            Console.WriteLine("Please enter message to be sent to customer email.");
            newContent.Email = Console.ReadLine();
        }
        public void FindCustomerByName()
        {
            Console.Clear();

            Console.WriteLine("Enter the name of the person you'd like to find.");
            string firstName = Console.ReadLine();

            CustomerContent content = _repo.FindPersonByName(firstName);

            if (content != null)
            {
                DisplayContent(content);
            }
            else
            {
                Console.WriteLine("That person doesn't exist");
            }
        }
        public void DeleteCustomerByName()
        {
            Console.WriteLine("Enter the name of the person you would like to delete");
            string firstNameToDelete = Console.ReadLine();

            CustomerContent contentToDelete = _repo.FindPersonByName(firstNameToDelete);
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
        public void DisplayContent(CustomerContent content)
        {
            Console.WriteLine($"Title: {content.FirstName}");
            Console.WriteLine($"Description: {content.LastName}");
            Console.WriteLine($"Star Rating: {content.Type}");
            Console.WriteLine($"Maturity Rating: {content.Email}");

        }
    }
}
