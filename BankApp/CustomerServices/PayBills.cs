using BankApp.CustomerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.AppServices
{
    public class PayBills
    {
        EnumBills UtilityBill;


        public void PayUtilityBills()
        {
            Console.WriteLine("Select bill (GOTV=1,DSTV=2,EEDC=3,FG Tax=4");
            UtilityBill = (EnumBills)int.Parse(Console.ReadLine());

            Console.WriteLine("Amount:");
            int BillAmount = int.Parse(Console.ReadLine());

            // Summary
            Console.WriteLine("\t \t ***Summary*** \t \t");

            Console.WriteLine($"Bill to be paid: {UtilityBill}");
            Console.WriteLine($"Amount:{BillAmount}");
            Console.WriteLine("Please wait...");
            Console.WriteLine("\t \t ** Payment Successful ** \t \t");








        }
    }
}
