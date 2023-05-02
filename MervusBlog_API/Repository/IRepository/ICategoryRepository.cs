using System;
using MervusBlog_API.Models;

namespace MervusBlog_API.Repository.IRepository
{
	public interface ICategoryRepository : IRepository<Category>
	{
        Task<Category> UpdateAsync(Category entity);
    }
}

