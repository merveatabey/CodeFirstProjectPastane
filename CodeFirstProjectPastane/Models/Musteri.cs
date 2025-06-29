using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstProjectPastane.Models
{
	public class Musteri
	{
        [Key]
        public int MusteriId { get; set; }
        public string? AdSoyad { get; set; }
        public string? Adres { get; set; }
        public string? Telefon { get; set; }
        public string? Eposta { get; set; }
    }
}

