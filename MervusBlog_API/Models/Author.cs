using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MervusBlog_API.Models
{
	public class Author
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string NickName { get; set; }
		public string Mobile { get; set; }
		public string Email { get; set; }
        public DateTime UpdatedDate { get; set; }
		public string? Profile { get; set; }
		public bool IsActive { get; set; }
	}
}

