using System;
using System.Collections.Generic;
using System.Text;
using RajinderpalsBooks.DataAccess.Repository.IRepository;
using RajinderpalsBooks.Models;
using RajinderpalsBooks.DataAccess.Data;
using System.Linq;


namespace RajinderpalsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(CoverType coverType)
        {
            //use .Net LINQ to retrive the first or default category object,
            // then pass the id as a genric entity which matches th category ID
            var objFromDb = _db.CoverType.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)      // save changes if not null
            {
                objFromDb.Name = coverType.Name;
                // _db.SaveChanges();
            }
        }
    }
}
