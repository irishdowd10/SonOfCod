using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCod.Models
{
	[Table("Newsletter")]
	public class Newsletter
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		
	}
}
