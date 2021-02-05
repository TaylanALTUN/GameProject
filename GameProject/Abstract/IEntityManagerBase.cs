using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IEntityManagerBase<T> where T:class, IEntity, new()
    {
        string Add(T entity);
        string Update(T entity);
        string Delete(T entity);
    }
}
