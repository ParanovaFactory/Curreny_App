using CurrenyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrenyApp.Classes
{
    public class sale
    {
        CurrencyRateEntities db = new CurrencyRateEntities();

        public void makeSale(string customerName, string customerSurname, int currencyCode, string operationType, decimal currentValue, decimal amount, decimal totalPrice)
        {
            TblOperation operation = new TblOperation();
            operation.customenrName = customerName;
            operation.customerSurname = customerSurname;
            operation.currencyCode = currencyCode;
            operation.operationType = operationType;
            operation.currentValue = currentValue;
            operation.Amount = amount;
            operation.totalPrice = totalPrice;
            operation.operationDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblOperations.Add(operation);
            db.SaveChanges();
            Console.WriteLine("Operation succesfull");
        }
    }
}
