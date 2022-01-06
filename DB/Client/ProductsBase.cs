using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.DB
{
    public class ProductsBase : DbObject
    {
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("ShoppingCart")]
        public int? ShoppingCartId { get; set; }
       // nastepnie robic dzialania z koszykiem 

    }


}
