using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyII.BLL.Models
{
    public class GenericModel
    {
        [Key]
        public int GenericId { get; set; }

        [Required]
        [Display(Name = "Generic Name")]
        public string GenericName { get; set; }

        public bool IsShow { get; set; }
    }
}
