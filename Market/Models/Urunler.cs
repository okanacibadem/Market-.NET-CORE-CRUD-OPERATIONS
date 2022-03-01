using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Urunler
    {



        [Key]
        public int urunNo { get; set; }

        [Required]
        [StringLength(20)]
        public string urunAd { get; set; } = "";

        [Required]
        [Range(1, 99999, ErrorMessage = "Bu alış fiyatı uygun değil")]
        public int alisFiyati { get; set; }

        [Required]
        [Range(1, 99999, ErrorMessage = "Bu satış fiyatı yaş uygun değil")]
        public int satisFiyati { get; set; }

        [Required]
        public DateTime gelisTarihi { get; set; }

        [Required]
        [Range(1, 2500, ErrorMessage = "gecersiz")]
        [DisplayName("Toplam Miktar")]

        public int miktar { get; set; }
    }
}
