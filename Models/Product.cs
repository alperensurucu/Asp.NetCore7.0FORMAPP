using System.ComponentModel.DataAnnotations;

namespace Asp.NetCore7._0FORMAPP.Models
{
    public class Product
    {
        [Display(Name="Urun Id")]
        public int ProductId { get; set; }

        [Display(Name = "Urun Adı")]
        public string Name { get; set; } = string.Empty;

        [Display(Name="Fiyat")]
        public decimal Price { get; set; }

        [Display(Name = "Resim")]
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }     
    }
}
