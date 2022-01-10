using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShop.Pages;

namespace MusicShop.Pages
{
     public abstract class Clothes
    {


        protected abstract string GetSeparator();
        protected abstract string KindOfProduct();
        
        public string Material(string Cotton, string Polyester)
        {
            return KindOfProduct() + Cotton + GetSeparator() + Polyester;
        }
       


    }
     public class Tshirt : Clothes
    {
        protected override string GetSeparator()
        {
            return " and ";
        }

        protected override string KindOfProduct()
        { 
            return "Product have "; 
        }
            
        


    }
    public class Jacket : Clothes
    {
        protected override string GetSeparator()
        {
            return "-";
        }
        protected override string KindOfProduct()
        {
            return "Product have ";
        }
        
    }
}
