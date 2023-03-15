using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
	public class Admin
	{
        [Required]
        [DisplayName("email Address")]
        public string email { get; set; }

        [Required]
        [DisplayName("Password")]
        public string password{ get; set; }


    }
}
