using System;
using System.Collections.Generic;

namespace Mini_Project_2.Asset
{
    /// <summary>
    /// Describes a asset
    /// </summary>
    public class Assets
    {
        private static List<Assets> assets = new List<Assets>();
        private DateTime endOfLife = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day).AddYears(-3).AddMonths(-3);
        internal int nr = 0;
        public int Id { get; set; }
        public DateTime purchaseDate { get; set; }
        public int price { get; set; }
        public string type { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string office { get; set; }
        public string currency{ get; set; }

        public void setList(List<Assets> assetList)
        {
            assets = assetList;
        }

        public void printSortedList()
        {
            string outPut = "Nr".PadRight(5) + "Type".PadRight(10) + "Brand".PadRight(10) + "Model".PadRight(15) +
                "Office".PadRight(10) + "Purchase Date".PadRight(16) + "Price in USD".PadRight(15) +
                "Currency".PadRight(10);

            Console.WriteLine(outPut);
            Console.WriteLine("____________________________________________________________________________________");


            //Print assets in red if older than 3 years and 3 month
            //Todo: Add assets in gellow if older than 3 years and 6 month
            foreach (Assets asset in assets)
            {
                int res = DateTime.Compare(endOfLife, asset.purchaseDate);
                if (res < 0) { Console.ForegroundColor = ConsoleColor.White; }
                else { Console.ForegroundColor = ConsoleColor.Red; }
                Console.WriteLine(asset.ToString());
            }

            Console.WriteLine("\n");
        }

        internal void setTempNumber()
        {
            int i = 1;
            // Assign a number
            foreach (Assets asset in assets)
            {
                asset.nr = i;
                ++i;
            }
        }
    }
}