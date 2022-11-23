using System;
using System.Collections.Generic;
using System.Text;

namespace RajinderpalsBooks.DataAccess.Repository.IRepository
{
   public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
        ICoverTypeRepository CoverType { get; }

        void Save();
    }
}
