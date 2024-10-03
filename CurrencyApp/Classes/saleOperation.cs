using CurrenyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrenyApp.Classes
{
    public class saleOperation
    {
        CurrencyRateEntities CurrencyRateEntities = new CurrencyRateEntities();
        public void listSale()
        {
            var values = CurrencyRateEntities.TblOperations.Where(x => x.operationType == "Selling").ToList();
            foreach (var value in values)
            {
                Console.WriteLine(value.customenrName + " " + value.customerSurname + " " + value.currencyCode + " " + value.operationType + " " + value.currentValue + " " + value.Amount + " " + value.totalPrice + " " + value.operationDate);
            }
        }

        public void listBuying()
        {
            var values = CurrencyRateEntities.TblOperations.Where(x => x.operationType == "Buying").ToList();
            foreach (var value in values)
            {
                Console.WriteLine(value.customenrName + " " + value.customerSurname + " " + value.currencyCode + " " + value.operationType + " " + value.currentValue + " " + value.Amount + " " + value.totalPrice + " " + value.operationDate);
            }
        }
    }
}
