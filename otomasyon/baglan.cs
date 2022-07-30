using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace otomasyon
{
    public class baglan
    {
       public static SQLiteConnection connection = new SQLiteConnection("Data source=arabalar.db; Version=3");    
    }
}
