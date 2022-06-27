using System.ComponentModel.DataAnnotations;

namespace Transaksi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nama { get; set; }
        [Required]
        public string Password { get; set; }
    }
}