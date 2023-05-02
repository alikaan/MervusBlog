using System;
using MervusBlog_API.Data;
using MervusBlog_API.Models;
using MervusBlog_API.Repository.IRepository;

namespace MervusBlog_API.Repository
{
	public class PostRepository : Repository<Post>, IPostRepository
	{
        private readonly ApplicationDbContext _db;
		public PostRepository(ApplicationDbContext db) : base (db)
		{
            _db = db;
		}

        public Task<Post> UpdateAsync(Post entity)
        {
            throw new NotImplementedException();
        }
    }
}

