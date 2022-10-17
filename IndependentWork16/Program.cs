using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Unicode;

namespace IndependentWork16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Product[] products = new Product[n];
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Введите Код продукта");
                int productСode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Имя продукта");
                string productName = Console.ReadLine();
                Console.WriteLine("Введите Цену продукта");
                decimal productPric = Convert.ToDecimal(Console.ReadLine());
                products[i] = new Product() { ProductСode = productСode, ProductName = productName, ProductPrice = productPric };
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString=JsonSerializer.Serialize(products, options);

            using (StreamWriter sw = new StreamWriter("../../../Prodcts.json")) 
            {
            sw.WriteLine(jsonString);
            }
        }
    }
}
