using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MervusBlog_API.Models.Dto
{
	public class PostDTO
	{
        public int Id { get; set; }
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
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }
    }
}

