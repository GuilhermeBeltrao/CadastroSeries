using System.Collections.Generic;

namespace CadastroSeries.Interface
{
    public interface IRepository<T>
    {
        List<T> List();
        T ReturnById(int id);
        void Add(T entity);
        void Remove(int id);
        void Update(int id, T entity);
        int NextId();
    }
}