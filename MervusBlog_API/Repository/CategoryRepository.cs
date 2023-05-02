using System;
using MervusBlog_API.Data;
using MervusBlog_API.Models;
using MervusBlog_API.Repository.IRepository;

namespace MervusBlog_API.Repository
{
	public class CategoryRepository : Repository<Category>, ICategoryRepository
	{
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base (db)
		{
			_db = db;
		}

        public Task<Category> UpdateAsync(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}

