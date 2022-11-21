using System;
using System.Collections.Generic;
using System.Text;
using RajinderpalsBooks.DataAccess.Repository.IRepository;
using RajinderpalsBooks.DataAccess.Data;

namespace RajinderpalsBooks.DataAccess.Repository
{
     public class UnitOfWork : IUnitOfWork     // make the method public to access the class
    {
        private readonly ApplicationDbContext _db;   //using statement

        public UnitOfWork(ApplicationDbContext db)  //  constructor to use DI and inject in to the  repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public  ICategoryRepository Category { get;  private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()  // all changes will be savwed when the save metgod is called parent level
        {
            _db.SaveChanges();
        }

        
            
    }
}
