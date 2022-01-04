using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShop.DB;

namespace MusicShop.Client
{
    public class Client : DbObject
    {
        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(15)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        protected string Address { get; }

        public int PhoneNumber { get; set; }

        public int Age { get; set; }
    }
}
