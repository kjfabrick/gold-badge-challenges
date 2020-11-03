using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Greeting
{
    public CustomerContent_Repo _repo = new CustomerContent_Repo();

    public class CustomerContent_Repo
    {
        public CustomerContent_Repo()
        {
        }
    }

    public void Run()
    {
        object p = Menu();
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
                    //FindCustomerbyName();
                    break;
                case "3":
                    // AddNewCustomer);
                    break;
                case "4":
                    // UpdateCustomer();
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
        List<CustomerContent_Repo> listOfContent = _repo.GetContents();
        foreach (CustomerContent_Repo content in listOfContent)
        {
            DisplayContent(content);
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
    public void DisplayContent(CustomerContent_Repo content)
    {
        Console.WriteLine($"Title: {content.FirstName}");
        Console.WriteLine($"Description: {content.LastName}");
        Console.WriteLine($"Star Rating: {content.Type}");
        Console.WriteLine($"Maturity Rating: {content.Email}");
    }
}