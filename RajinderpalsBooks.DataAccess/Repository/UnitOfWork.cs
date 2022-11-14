using System;
using System.Collections.Generic;
using System.Text;
using RajinderpalsBooks.DataAccess.Repository.IRepository;
using RajinderpalsBooks.DataAccess.Data;

namespace RajinderpalsBooks.DataAccess.Repository
{
    class UnitOfWork // make the method public to access the class
    {
        private readonly ApplicationDbContext _db;   //using statement

        public UnitOfWork(ApplicationDbContext db)  //  constructor to use DI and inject in to the  repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public  ICategoryRepository Category { get;  private set; }

        
            ;
    }
}
