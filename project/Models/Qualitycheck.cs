using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace project.Models
{
    public class Qualitycheck
    {
        [Required]
        [DisplayName("Item Code")]
        public int itemcode { get; set; }
      
        [Required]
        [DisplayName("Item Name")]
        public string itemname { get; set; }

        [Required]
        [DisplayName("Request Number")]
        public  int requestnumber { get; set; }

        [Required]
        [DisplayName("Base Document Number")]
        public int basedocumentnumber { get; set; }

        [Required]
        [DisplayName("Stage")]
        public string stage{ get; set; }
       
        [Required]
        [DisplayName("Inspector Code")]
        public int inspectorcode{ get; set; }
       
        [Required]
        [DisplayName("Inspector Date")]
        public int inspectordate { get; set; }

        [Required]
        [DisplayName("Inspector Name")]
        public string inspectorname { get; set; }
       
        [Required]
        [DisplayName("Quality")]
        public int quality { get; set; }
       
        [Required]
        [DisplayName("Accepted Quality")]
        public int acceptedquality { get; set; }

        [Required]
        [DisplayName("Rejected Quality")]
        public int rejectedquality { get; set; }
    }
}
