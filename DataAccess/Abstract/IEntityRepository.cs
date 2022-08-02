using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Generic Constraint
    //class : referans tip olabilir demek.
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //IEntity işimize yaramayacağı için onu devre dışı bırakmak istiyorum.
    //Bunun içinde new derim interface newlenemeyeceği için IEntity kendisini tip olarak veremeyiz.

    public interface IEntityRepository <T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
