using System;
using System.Collections.Generic;
using System.Text;
using RajinderpalsBooks.DataAccess.Repository.IRepository;
using RajinderpalsBooks.Models;
using RajinderpalsBooks.DataAccess.Data;
using System.Linq;


namespace RajinderpalsBooks.DataAccess.Repository
{
    public class CategoryRepository :  Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
            
            public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Category category)
        {
            //use .Net LINQ to retrive the first or default category object,
            // then pass the id as a genric entity which matches th category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)      // save changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
