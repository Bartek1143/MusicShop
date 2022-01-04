using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Client
{
    class ProductsAdapter : IProducts
    {
        public List<string> GetProducts()
        {
            ProductsAdaptee adaptee = new ProductsAdaptee();
            return adaptee.GetListOfProducts();
        }
    }
}
