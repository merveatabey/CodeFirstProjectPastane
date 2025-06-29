using System;
namespace CodeFirstProjectPastane.Models.ViewModel
{
	public class ReportViewModel
	{
        public string? SecilenRapor { get; set; }
        public List<Urun>? Urunler { get; set; }
        public List<Musteri>? Musteriler { get; set; }
        public List<Personel>? Personeller { get; set; }
    }
}

