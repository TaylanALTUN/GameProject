using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class EntityManagerBase<TEntity> : IEntityManagerBase<TEntity> where TEntity : class, IEntity, new()
    {
        public virtual string Add(TEntity entity)
        {
            string result = "";
            if (entity !=null)
            {
                result = "Ekleme başarılı.";
            }
            else
            {
                result = "Ekleme başarısız.";
            }

            return result;
        }

        public virtual string Update(TEntity entity)
        {
            string result = "";
            if (entity != null)
            {
                result = "Güncelleme başarılı.";
            }
            else
            {
                result = "Güncelleme başarısız.";
            }
            return result;
        }

        public string Delete(TEntity entity)
        {
            string result = "";
            if (entity != null)
            {
                result = "Silme başarılı.";
            }
            else
            {
                result = "Silme başarısız.";
            }
            return result;
        }
    }
}
