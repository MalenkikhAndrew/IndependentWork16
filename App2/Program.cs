using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace IndependentWork16
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string jsonString=String.Empty;
            using (StreamReader sr = new StreamReader("../../../Prodcts.json")) 
            {
            jsonString = sr.ReadToEnd();
            }
            Product[] products=JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxProduct=products[0];
            foreach (Product p in products) 
            {
                if (p.ProductPrice > maxProduct.ProductPrice) 
                {
                maxProduct=p;
                }
            }
            Console.WriteLine($"{maxProduct.ProductСode}{maxProduct.ProductName}{maxProduct.ProductPrice}");
        }
    }
}
