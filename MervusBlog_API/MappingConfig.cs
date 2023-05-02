using System;
using AutoMapper;
using MervusBlog_API.Models;
using MervusBlog_API.Models.Dto;

namespace MervusBlog_API
{
	public class MappingConfig : Profile
	{
		public MappingConfig()
		{
            CreateMap<Author, AuthorDTO>().ReverseMap();
			CreateMap<Author, AuthorCreateDTO>().ReverseMap();

			CreateMap<User, UserDTO>().ReverseMap();
			CreateMap<User, UserCreateDTO>().ReverseMap();
        }
	}
}

