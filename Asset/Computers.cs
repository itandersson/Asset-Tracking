using System;

namespace Mini_Project_2.Asset
{
    public abstract class Computers : Assets
    {
        public override string ToString()
        {
            string outPut = nr.ToString().PadRight(5) + type.PadRight(10) + brand.PadRight(10) + model.PadRight(15) +
                office.PadRight(10) + purchaseDate.ToString("yy/MM/dd").PadRight(16) +
                price.ToString().PadRight(15) + currency.PadRight(10);

            return outPut;
        }
    }

    public class MacBook : Computers
    {
        public MacBook(DateTime purchaseDate, int price, string type, string brand, string model, string office, string currency)
        {
            base.purchaseDate = purchaseDate;
            base.price = price;
            base.type = type;
            base.brand = brand;
            base.model = model;
            base.office = office;
            base.currency = currency;
        }
    }

    public class Asus : Computers
    {

        public Asus(DateTime purchaseDate, int price, string type, string brand, string model, string office, string currency)
        {
            base.purchaseDate = purchaseDate;
            base.price = price;
            base.type = type;
            base.brand = brand;
            base.model = model;
            base.office = office;
            base.currency = currency;
        }
    }

    public class Lenovo : Computers
    {

        public Lenovo(DateTime purchaseDate, int price, string type, string brand, string model, string office, string currency)
        {
            base.purchaseDate = purchaseDate;
            base.price = price;
            base.type = type;
            base.brand = brand;
            base.model = model;
            base.office = office;
            base.currency = currency;
        }
    }

    public class HP : Computers
    {

        public HP(DateTime purchaseDate, int price, string type, string brand, string model, string office, string currency)
        {
            base.purchaseDate = purchaseDate;
            base.price = price;
            base.type = type;
            base.brand = brand;
            base.model = model;
            base.office = office;
            base.currency = currency;
        }
    }
}
