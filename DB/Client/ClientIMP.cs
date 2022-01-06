using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MusicShop.DB
{
    public class ClientIMP : IConnection
    {
        void IConnection.DisplayData()
        {
            using (MusicShopDB context = new MusicShopDB())
            {
                List<Client> DisplayClient = context.Clients.ToList();
            }
        }

        public List<Client> ReturnList()
        {
            using (MusicShopDB context = new MusicShopDB())
            {
                List<Client> ReturnListClients = context.Clients.ToList();
                return ReturnListClients;

            }
        }

        void IConnection.SaveData(Client SaveToDate)
        {
            using (MusicShopDB context = new MusicShopDB())
            {
                context.Clients.Add(SaveToDate);

                context.SaveChanges();
               
            }

        }


    }
}
