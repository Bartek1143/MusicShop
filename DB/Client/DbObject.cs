using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MusicShop.DB
{
    public class DbObject
    {
        [Key]
        public int Id { get; set; }
    }
}
