using System;
using System.ComponentModel.DataAnnotations;

namespace MervusBlog_API.Models.Dto
{
	public class PostCreateDTO
	{
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        [Required]
        public string Summary { get; set; }
        public bool IsPublished { get; set; }
        public string Content { get; set; }
    }
}

