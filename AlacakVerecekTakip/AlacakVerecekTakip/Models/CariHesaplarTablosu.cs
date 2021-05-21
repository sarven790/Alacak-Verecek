using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlacakVerecekTakip.Models
{
    public class CariHesaplarTablosu
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public decimal AlacakMiktar { get; set; }
        public decimal VerecekMiktar { get; set; }
        public string AlacakVerecek { get; set; }
        public bool Durum { get; set; }

        public UyelerTablosu uyelerTablosu { get; set; }

    }
}
