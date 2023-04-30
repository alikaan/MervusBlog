using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MervusBlog_API.Models
{
	public class Category
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		public string Title { get; set; }
		public string Context { get; set; }
        public bool IsActive { get; set; }
    }
}

