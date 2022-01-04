using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShop.DB;

namespace MusicShop.Client
{
    public class ShoppingCart :DbObject
    {
        
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public List<ProductsBase> Products { get; set; }


    }
}
