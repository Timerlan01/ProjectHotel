using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using LiteDB;

namespace Astana.DAL
{
    public class Repositories<T> : IRepository<T>
    {
        public bool Create(T data)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(@"C:\Temp\hotel.db"))
                {
                    var coll = db.GetCollection<T>(typeof(T).Name);
                    coll.Insert(data);
                }
                return true;
            }
            catch (LiteException ex)
            {
                ///TODO
                return false;
            }
            catch(Exception ex)
            {
                ///TODO
                return false;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(""))
                {
                    var coll = db.GetCollection<T>(typeof(T).Name);
                    coll.Delete(Id);
                }
                return true;
            }
            catch(Exception ex)
            {

            }
            return true;
        }

        public List<T> GetAll()
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(@"C:\Temp\hotel.db"))
                {
                    var collection = db.GetCollection<T>(typeof(T).Name);

                    return collection.FindAll().ToList();
                }//Dispose()
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public T GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Update(T data)
        {
            throw new NotImplementedException();
        }
    }
}
