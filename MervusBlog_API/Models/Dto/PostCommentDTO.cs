using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MervusBlog_API.Models.Dto
{
	public class PostCommentDTO
	{
        public int Id { get; set; }
        [Required]
        public int PostId { get; set; }
        public bool IsPublished { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime PublishedDate { get; set; }
        [Required]
        public string Content { get; set; }
    }
}

