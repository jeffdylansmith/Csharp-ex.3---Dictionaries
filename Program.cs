using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("ULH", "Universal Truckload Services");
            stocks.Add("SNE", "Sony");
            

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GM", shares: 150, price: 34.94));
            purchases.Add((ticker: "CAT", shares: 150, price: 106.92));
            purchases.Add((ticker: "ULH", shares: 150, price: 15.20));
            purchases.Add((ticker: "SNE", shares: 150, price: 37.77));
            purchases.Add((ticker: "SNE", shares: 150, price: 37.77));

            Dictionary<string, double> report = new Dictionary<string, double>();
            
            foreach((string ticker, int shares, double price) element in purchases) {
                double purchaseTotal = element.shares * element.price;
                if (report.ContainsKey($"{stocks[$"{element.ticker}"]}")){
                    report[stocks[$"{element.ticker}"]] += purchaseTotal;
                    Console.WriteLine($"{stocks[$"{element.ticker}"]}, {report[stocks[$"{element.ticker}"]]}");
                }
                if(!report.ContainsKey($"{stocks[$"{element.ticker}"]}")){
                    Console.WriteLine($"{stocks[$"{element.ticker}"]}, {purchaseTotal}");
                    report.Add($"{stocks[$"{element.ticker}"]}", purchaseTotal);
                }
            } 
        }
    }
}

