using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ostoslista
{
    // Voidaan luoda ostoslistoja eri kaupoille.
    // Tuote lisätessä listaan "haetaan" tuotteen hinta.


    class ShoppinList
    {
        // Properties
        public string ShopName  { get; set; }
        private List<Product> Products { get; set; }
        public decimal sum { get; set; }

        // Constructors

        public ShoppinList(string shopName)
        {
            ShopName = shopName;
            sum = 0;
            Products = new List<Product>();
        }

        // Methods
        public void addProduct(string productName)
        {
            Product temp = new Product(productName);
            Products.Add(temp);
            sum += temp.Price;
        }
        public void PrintProduct()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine($"{i+1}. {Products[i].Name}\t\t\t{Products[i].Price}");
            }
        }
    }
}
