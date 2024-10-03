using CurrenyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CurrenyApp.Classes
{
    public class getCurrency
    {
        CurrencyRateEntities db = new CurrencyRateEntities();
        string link = "https://www.tcmb.gov.tr/kurlar/today.xml";

        public void currencyDollar()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(link);
            string dollarBuying = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;

            string dollarSelling = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;

            TblCurrencyPrice tblCurrencyPrice = new TblCurrencyPrice();
            tblCurrencyPrice.currencyName = 1;
            tblCurrencyPrice.currencyBuying = decimal.Parse(dollarBuying);
            tblCurrencyPrice.currencySelling = decimal.Parse(dollarSelling);
            tblCurrencyPrice.date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyPrices.Add(tblCurrencyPrice);
            db.SaveChanges();
        }

        public void currencyEuro()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(link);
            string euroBuying = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;

            string euroSelling = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

            TblCurrencyPrice tblCurrencyPrice = new TblCurrencyPrice();
            tblCurrencyPrice.currencyName = 2;
            tblCurrencyPrice.currencyBuying = decimal.Parse(euroBuying);
            tblCurrencyPrice.currencySelling = decimal.Parse(euroSelling);
            tblCurrencyPrice.date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyPrices.Add(tblCurrencyPrice);
            db.SaveChanges();
        }

        public void currencySterlin()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(link);
            string sterlinBuying = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;

            string sterinSelling = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;

            TblCurrencyPrice tblCurrencyPrice = new TblCurrencyPrice();
            tblCurrencyPrice.currencyName = 4;
            tblCurrencyPrice.currencyBuying = decimal.Parse(sterlinBuying);
            tblCurrencyPrice.currencySelling = decimal.Parse(sterinSelling);
            tblCurrencyPrice.date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TblCurrencyPrices.Add(tblCurrencyPrice);
            db.SaveChanges();
        }
    }
}
