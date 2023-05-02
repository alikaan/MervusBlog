using System;
using System.ComponentModel.DataAnnotations;

namespace MervusBlog_API.Models.Dto
{
	public class AuthorCreateDTO
	{
        [Required]
        [MaxLength(30)]
        public string NickName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string? Profile { get; set; }
    }
}

