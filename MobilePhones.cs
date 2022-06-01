using System;

namespace Mini_Project_2
{

	public abstract class MobilePhones : Assets
	{
		public override string ToString()
		{
			string outPut = (this.type).PadRight(10) + (this.brand).PadRight(10) + (this.model).PadRight(15) +
				(this.office).PadRight(10) + (this.purchaseDate).ToString("yy/MM/dd").PadRight(16) +
				(this.price).ToString().PadRight(15) + (this.currency).PadRight(10);

			return outPut;
		}
	}

	public class Iphone : MobilePhones
	{

		public Iphone(DateTime purchaseDate, int price, string type, string brand, string model, string office, string currency)
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

	public class Samsung : MobilePhones
	{

		public Samsung(DateTime purchaseDate, int price, string type, string brand, string model, string office, string currency)
		{
			base.purchaseDate = purchaseDate;
			base.price = price;
			base.type = type;
			base.brand = brand;
			base.model = model;
			this.office = office;
			base.currency = currency;
		}
	}

	public class Nokia : MobilePhones
	{

		public Nokia(DateTime purchaseDate, int price, string type, string brand, string model, string office, string currency)
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

	public class Motorola : MobilePhones
	{

		public Motorola(DateTime purchaseDate, int price, string type, string brand, string model, string office, string currency)
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
