using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Reyonlar
    {

        [Key]
        public int reyonNo { get; set; }

        [Required]
        [StringLength(20)]
        public string reyonAdi { get; set; } = "";
    }
}
