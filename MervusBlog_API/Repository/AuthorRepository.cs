using System;
using MervusBlog_API.Data;
using MervusBlog_API.Models;
using MervusBlog_API.Repository.IRepository;

namespace MervusBlog_API.Repository
{
	public class AuthorRepository : Repository<Author>, IAuthorRepository
	{
        private readonly ApplicationDbContext _db;
		public AuthorRepository(ApplicationDbContext db): base (db)
		{
            _db = db;
		}

        public async Task<Author> UpdateAsync(Author entity)
        {
            entity.UpdatedDate = DateTime.UtcNow;
            _db.Authors.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

