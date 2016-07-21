using BasicAuth.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourTube.Repositories
{
    public interface IRepository<TModel, TId>
    {
        IQueryable<TModel> AsQuerable();
        TModel RetrieveById(TId id);
        AddDTO Create(TModel newItem);
        SuccessDTO Update(TId id, Func<TModel, TModel> getNew);
        SuccessDTO Delete(TId id);
    }
}
