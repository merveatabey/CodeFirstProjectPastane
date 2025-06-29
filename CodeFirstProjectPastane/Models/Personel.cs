using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstProjectPastane.Models
{
	public class Personel
	{
        [Key]
        public int PersonelId { get; set; }
        public string? AdSoyad { get; set; }
        public int Yas { get; set; }
        public int Deneyim { get; set; }
        public string? Adres { get; set; }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }
        public string Cinsiyet { get; set; }

        [ForeignKey("Departman")]
        public int DepartmanId { get; set; }

        public virtual Departman Departman { get; set; }
    }
}

