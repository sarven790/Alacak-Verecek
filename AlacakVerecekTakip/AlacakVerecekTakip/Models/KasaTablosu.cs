using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlacakVerecekTakip.Models
{
    public class KasaTablosu
    {
        [Key]
        public int ID { get; set; }
        public int UyeID { get; set; }
        public string IslemTuru { get; set; }
        public string KisiAdSoyad { get; set; }
        public decimal GirisTutari { get; set; }
        public decimal CikisTutari { get; set; }
        public decimal Bakiye { get; set; }



    }
}
