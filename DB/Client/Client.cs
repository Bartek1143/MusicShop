using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter;
using Microsoft.EntityFrameworkCore;
using MusicShop.DB;

namespace MusicShop.DB
{
    public class Client :DbObject
    {
        [MaxLength(30)]
        public string Surname { get; set; }

        [MaxLength(15)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Age { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Login { get; set; }
    }
}
