using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace deneme
{
   public class PersonRepository
    {
        SQLiteConnection conn;
        static object locker = new object();
      
        public PersonRepository(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<People>();

          

        }

        public IEnumerable<People> GetItems()
        {
            lock (locker)
            {
                return (from i in conn.Table<People>() select i).ToList();
            }
        }

        public People GetItem(string email)
        {
            lock (locker)
            {
                return conn.Table<People>().FirstOrDefault(x => x.Email == email);
            }
        }
        public People Getuserid(int id,string email)
        {
            lock (locker)
            {
                return conn.Table<People>().Where(x => x.Email==email).FirstOrDefault(x => x.ID == id);
            }
        }
        public People GetItem(string email, string password)
        {
            lock (locker)
            {
                return conn.Table<People>().FirstOrDefault(x => x.Email == email && x.Password == password);
            }
        }
        public int SaveItem(People item)
        {
            lock (locker)
            {
                if (item.ID != 0)
                {
                    //Update Item  
                    conn.Update(item);
                    return item.ID;
                }
                else
                {
                    //Insert item  
                    return conn.Insert(item);
                }
            }
            
        }
      

        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return conn.Delete<People>(id);
            }
        }
    }
}