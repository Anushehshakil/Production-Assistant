using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
	public class Pendinginspection
	{
        [Required]
        [DisplayName("Card Code")]
        public int cardcode { get; set; }

    
        [Required]
        [DisplayName("Card Number")]
        public int cardnumber { get; set; }
       
        [Required]
        [DisplayName("Document Type")]
        public string documenttype { get; set; }
       
        [Required]
        [DisplayName("Document Status")]
        public  string documentstatus { get; set; }
    }
}
