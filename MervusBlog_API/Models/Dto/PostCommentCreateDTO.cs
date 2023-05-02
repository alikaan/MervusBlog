using System;
using System.ComponentModel.DataAnnotations;

namespace MervusBlog_API.Models.Dto
{
	public class PostCommentCreateDTO
	{
        [Required]
        public int PostId { get; set; }
        public bool IsPublished { get; set; }
        [Required]
        public string Content { get; set; }
    }
}

