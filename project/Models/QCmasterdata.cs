using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace project.Models
{
    public class QCmasterdata
    {
       // [Key]
      //  public int id { get; set; }

        [Required]
        [DisplayName ("Item Code")]
        public int itemcode { get; set; }
       
        [Required]
        [DisplayName ("Code")]
        public int code { get; set; }
        
        [Required]
        [DisplayName ("Description")] 
        public string description { get; set; }
       
        [Required]
        [DisplayName ("Name")]
        public string name { get; set; }
        
        [Required]
        [DisplayName ("Stage")]
        public string stage { get; set; }
        
        [Required]
        [DisplayName ("UOM")]
        public string uom { get; set; }
        
        [Required]
        [DisplayName ("Parameter")]
        public int parameter { get; set; }
        
        [Required]
        [DisplayName ("Parameter Name")]
        public string parametername { get; set; }
        
        [Required]
        [DisplayName ("Minimum Value")]
        public int minimumvalue { get; set; }
        
        [Required]
        [DisplayName ("Maximum Value")]
        public int maximumvalue { get; set; }
        
        [Required]
        [DisplayName ("standard value")]
        public int stdvalue { get; set; }
    }

}
