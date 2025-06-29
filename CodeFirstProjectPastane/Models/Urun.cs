using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstProjectPastane.Models
{
	public class Urun
	{
        [Key]
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
        public string Kategori { get; set; }
    }
}

