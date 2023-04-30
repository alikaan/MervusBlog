using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MervusBlog_API.Models
{
	public class PostComment
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		[ForeignKey("Post")]
		public int PostId { get; set; }
		public string Title { get; set; }
		public bool IsPublished { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime PublishedDate { get; set; }
		public string Content { get; set; }
        public bool IsActive { get; set; }
    }
}

