using Astana.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Service<T>
    {
        protected Repositories<T> db = null;
        public Service()
        {
            db = new Repositories<T>();
        }
    }
}
