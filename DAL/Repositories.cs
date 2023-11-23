using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using LiteDB;

namespace Astana.DAL
{
    class Repositories<T> : IRepository<T>
    {
        public bool Create(T data)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(""))
                {
                    var coll = db.GetCollection<T>(typeof(T).Name);
                    coll.Insert(data);
                }
                return true;
            }
            catch
            {
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
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
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
