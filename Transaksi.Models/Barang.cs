using System.ComponentModel.DataAnnotations;

namespace Transaksi.Models
{
    public class Barang
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nama Barang")]
        public string Nama { get; set; }
        [Required]
        public double Harga { get; set; }
        [Required]
        public string Satuan { get; set; }
    }
}