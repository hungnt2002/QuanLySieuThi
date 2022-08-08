using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    internal interface InterfaceDAL<T>
    {
        bool Insert(T t);
        bool Update(T t);
        bool Delete(T t);
        DataTable SelectAll();

    }
}
