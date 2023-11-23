using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IRepository<T>
    {
        bool Create(T data);
        bool Update(T data);
        bool Delete(int Id);
        List<T> GetAll();
        T GetById(int Id);

    }
}
