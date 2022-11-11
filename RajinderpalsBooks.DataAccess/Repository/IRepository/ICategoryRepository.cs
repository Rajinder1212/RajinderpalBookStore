using System;
using System.Collections.Generic;
using System.Text;
using RajinderpalsBooks.Models;


namespace RajinderpalsBooks.DataAccess.Repository.IRepository
{
    public  interface ICategoryRepository : IRepository<Category>

    {
        void Update(Category category);
    }

}
