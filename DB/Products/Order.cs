using MusicShop.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Products
{
    public class Order 
    {
        [Key]
        public int ProductId { get; set; }

        public int clientId { get; set; }

        public int OrderId { get; set; }
    }
}
