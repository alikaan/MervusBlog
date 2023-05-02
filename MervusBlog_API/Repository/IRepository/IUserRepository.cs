using System;
using MervusBlog_API.Models;
using MervusBlog_API.Models.Dto;

namespace MervusBlog_API.Repository.IRepository
{
	public interface IUserRepository: IRepository<User>
	{
        Task<UserDTO> Register(User entity);
        Task<User> UpdateAsync(User entity);
    }
}

