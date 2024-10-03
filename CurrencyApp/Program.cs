using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CurrenyApp;
using CurrenyApp.Model;
using CurrenyApp.Classes;

namespace CurrenyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrencyRateEntities db = new CurrencyRateEntities();
            getCurrency get = new getCurrency();
            sale s = new sale();
            saleOperation saleOperation = new saleOperation();

            void currencyList()
            {
                Console.WriteLine();
                Console.WriteLine("Currency List");
                Console.WriteLine();

                var values = db.TblCurrencies.ToList();
                foreach (var value in values)
                {
                    Console.WriteLine(value.currencyId + " " + value.currencyName + " " + value.currnecySymbol);
                }
            }

            void currentCurrency()
            {
                Console.WriteLine();
                Console.WriteLine("Current Currency List");
                Console.WriteLine();

                var values = db.TblCurrencyPrices.ToList();
                foreach (var value in values)
                {
                    Console.WriteLine("Currency: " + value.currencyName + " Buying: " + value.currencyBuying + " Selling: " + value.currencySelling);
                }
            }
            
            void getCurrencyClass()
            {
                get.currencyDollar();
                get.currencyEuro();
                get.currencySterlin();
            }

            Console.WriteLine("Welcome to Currency Operation");
            Console.WriteLine();
            Console.WriteLine("User: Admin" + " Date:" + DateTime.Now.ToString());
            Console.WriteLine();
            Console.WriteLine("Choose ant process you want to do");
            Console.WriteLine();
            Console.WriteLine("1-Currency List");
            Console.WriteLine("2-Up to date rates");
            Console.WriteLine("3-Selling");
            Console.WriteLine("4-Sales operation to customers");
            Console.WriteLine("5-Buying operation to customers");
            Console.WriteLine("6-Save currency rate at database");
            Console.WriteLine("7-Help");
            Console.WriteLine("8-Logout");
            Console.WriteLine();
            Console.Write("Operation no: ");

            string choose = Console.ReadLine();
            if (choose == "1" || choose == "01")
            {
                currencyList();
            }
            else if(choose == "2" || choose == "02")
            {
                currentCurrency();
            }
            else if (choose == "3" || choose == "03")
            {
                Console.WriteLine();
                Console.WriteLine("Customer Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Customer Surname: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Currency Code: ");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose an operation: ");
                string operation = Console.ReadLine();
                Console.WriteLine("Current value: ");
                decimal value = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Amount: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Total price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                s.makeSale(name, surname, code, operation, value, amount, price);
            }
            else if (choose == "4" || choose == "04")
            {
                saleOperation.listSale();
            }
            else if (choose == "5" || choose == "05")
            {
                saleOperation.listBuying();
            }
            else if (choose == "6" || choose == "06")
            {
                getCurrencyClass();
            }
            else if (choose == "7" || choose == "07")
            {
                Console.WriteLine("can reach to us from mail@mail.com");
            }
            else if (choose == "8" || choose == "08")
            {
                Environment.Exit(0);
            }
        }
    }
}
