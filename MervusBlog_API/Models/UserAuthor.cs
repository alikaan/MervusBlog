using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MervusBlog_API.Models
{
	public class UserAuthor
	{
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
    }
}

