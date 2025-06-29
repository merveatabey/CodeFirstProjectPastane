using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstProjectPastane.Models
{
	public class Tedarikci
	{
        [Key]
        public int TedarikciId { get; set; }
        public string? TedarikciFirma { get; set; }
        public string? Adres { get; set; }
        public string? Telefon { get; set; }
        public string? Eposta { get; set; }
        public string? Malzeme { get; set; }
    }
}

