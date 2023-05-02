using System;
using MervusBlog_API.Models;

namespace MervusBlog_API.Repository.IRepository
{
	public interface IPostRepository: IRepository<Post>
	{
        Task<Post> UpdateAsync(Post entity);
    }
}

