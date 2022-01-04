using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MusicShop.Client;
using MusicShop.DB;

namespace MusicShop
{
    public class MusicShopDB : Microsoft.EntityFrameworkCore.DbContext
    {
        // Your context has been configured to use a 'MusicShopDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MusicShop.MusicShopDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MusicShopDB' 
        // connection string in the application configuration file.
        

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual Microsoft.EntityFrameworkCore.DbSet<ShoppingCart> ShoppingCarts { get; set; }
       
        public virtual Microsoft.EntityFrameworkCore.DbSet<ProductsBase> Products { get; set; }

         public virtual Microsoft.EntityFrameworkCore.DbSet<Client.Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=NT-27.WWSI.EDU.PL,1601;Database=KASETY_Z501_17;User Id=Z501_17;Password=Z501_17;");
        } 
       

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}