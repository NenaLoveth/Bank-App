using BankApp.CustomerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.AppServices
{
    public class Transfer
    {
        EnumBank Bank;
        public void TransferFund()
        {
            Console.WriteLine
                ("Select Bank: Access = 1,Zenith,EcoBank = 2," +
                "GTB =3,Fidelity=4,Polaris=5," +
                "UBA=6,FCMB=7,FirstBank=8, Union=9,")
                ;
            Bank =(EnumBank)Convert.ToInt32(Console.ReadLine());

            int AccountNumber, Amount;

            Console.WriteLine("Account Number:");
            AccountNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Amount:");
            Amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Comment:");

            string Comment;
            Comment = Console.ReadLine();






        }
    }
}
