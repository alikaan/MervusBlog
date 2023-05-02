using MervusBlog_API.Models;

namespace MervusBlog_API.Repository.IRepository
{
	public interface IAuthorRepository : IRepository<Author>
	{
        Task<Author> UpdateAsync(Author entity);
    }
}

