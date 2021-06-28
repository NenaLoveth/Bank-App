using BankApp.CustomerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.AppServices
{
    public class CreateAccount
    {
        EnumSex Sex;
        EnumAcctType AccountType;
        AccountNumberGen YourAccountNumber;

        public CreateAccount()
        {
            Console.WriteLine("Fill out the fields");

        }

        public void RegisterCustomer()
        {
            string Name, Address, NextOfKin;

            int Age;


            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter sex (M = 1; F = 2):");
            Sex =(EnumSex)int.Parse(Console.ReadLine());
           

            Console.WriteLine("Enter Address:");
            Address = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Next of Kin:");
            NextOfKin = Console.ReadLine();


            Console.WriteLine("Select Account type (Savings = 1, Current = 2, Fixed = 3");
            AccountType =(EnumAcctType)int.Parse(Console.ReadLine());

            Console.WriteLine("\t \t**Please wait while the system generates your account number**\t \t");
            Console.WriteLine("Getting Account Number...");

            AccountNumberGen accountNumber =  new AccountNumberGen();
            int YourAccountNumber = accountNumber.GetAccountNumber();

            // Summary
            Console.WriteLine("\t \t ***Summary*** \t \t");

            Console.WriteLine($"Account Name: {Name}");
            Console.WriteLine($"Account Number:{YourAccountNumber}");

        }


    }
}
