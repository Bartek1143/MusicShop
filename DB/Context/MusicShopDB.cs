using System;
using System.Linq;
using DB.Products;
using Microsoft.EntityFrameworkCore;
using MusicShop.DB;

namespace MusicShop
{
    public class MusicShopDB : DbContext
    {
        // Your context has been configured to use a 'MusicShopDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MusicShop.MusicShopDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MusicShopDB' 
        // connection string in the application configuration file.
        

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

   
        public virtual DbSet<ProductsBase> Products { get; set; }

        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=MusicShop;Integrated Security=True");
        } 
    }
 
}