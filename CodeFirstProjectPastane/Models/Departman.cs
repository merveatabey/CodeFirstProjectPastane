using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstProjectPastane.Models
{
	public class Departman
	{
       
            [Key]
            public int DepartmanId { get; set; }
            public string? DepartmanAdi { get; set; }
            public int PersonelSayisi { get; set; }

            public virtual ICollection<Personel> Personel { get; set; }
        }
}

