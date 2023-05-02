using System;
using AutoMapper;
using MervusBlog_API.Data;
using MervusBlog_API.Models;
using MervusBlog_API.Models.Dto;
using MervusBlog_API.Repository.IRepository;

namespace MervusBlog_API.Repository
{
	public class UserRepository : Repository<User>, IUserRepository
	{
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public UserRepository(ApplicationDbContext db, IMapper mapper) : base (db)
		{
            _db = db;
            _mapper = mapper;
		}

        public async Task<UserDTO> Register(User entity)
        {
            User user = entity;
            _db.Add(user);
            await _db.SaveChangesAsync();
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<User> UpdateAsync(User entity)
        {
            entity.UpdatedDate = DateTime.UtcNow;
            _db.Users.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

    }
}

