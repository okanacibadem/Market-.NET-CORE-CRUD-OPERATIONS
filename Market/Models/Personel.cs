using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Personel
    {
        [Key]
        public int personelNo { get; set; }

        [Required]
        [StringLength(20)]
        public string adi { get; set; } = "";

        [Required]
        [StringLength(20)]
        public string soyadi { get; set; } = "";
        [Required]
        [StringLength(10)]
        public string Cinsiyet { get; set; } = "";

        [Required]
        [Range(4250, 15000, ErrorMessage = "bu pozisyona maas uygun değil")]
        [DisplayName("maas")]
        public int maas { get; set; }

        [Required]
        [Range(1, 99999, ErrorMessage = "gecersiz")]
        [DisplayName("Reyon Numarası")]
        public int reyonNo { get; set; }


    }
}
