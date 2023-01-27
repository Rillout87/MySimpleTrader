using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleTrader.Domain.Services
{
    internal interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetIndexBinder(int id);
        Task<T> Update(int id, T entity);
        Task<T> Create(T entity);
        Task <bool> Delete(int id);
    }
}
