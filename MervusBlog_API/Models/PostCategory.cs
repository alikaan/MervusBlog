using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MervusBlog_API.Models
{
	public class PostCategory
	{
        [ForeignKey("Post")]
        public int PostId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
	}
}

