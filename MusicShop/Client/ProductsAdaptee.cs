using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Client
{
    public class ProductsAdaptee
    {
        public List<string> GetListOfProducts()
        {
            List<string> products = new List<string>();
            products.Add("T-shirty");
            products.Add("Shoes");
            products.Add("Sunglasses");
            return products;
        }
    }
}
