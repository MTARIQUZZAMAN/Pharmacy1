using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PharmacyIII.DLL
{
    public class GenericDto
    {
        [Key]
        public int GENERIC_ID { get; set; }

        public string GENERIC_NAME { get; set; }

        public bool SHOW { get; set; }
    }
}
