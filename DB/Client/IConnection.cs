using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShop.DB;


namespace MusicShop.DB
{
    public interface IConnection
    {
           
          void DisplayData();
          void SaveData(Client SaveToDate); 
         List<Client> ReturnList();

    }
}
