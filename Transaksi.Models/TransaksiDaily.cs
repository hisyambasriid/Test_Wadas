using System.ComponentModel.DataAnnotations;

namespace Transaksi.Models
{
    public class TransaksiDaily
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Tanggal { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
        public int BarangId { get; set; }
        public int UserId { get; set; }
        public int PerusahaanId { get; set; }
    }
}