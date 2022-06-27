using System.ComponentModel.DataAnnotations;

namespace Transaksi.Models
{
    public class Perusahaan
    {
        [Key]
        public int Id { get; set; }
        
        public string Nama { get; set; }
       
        public string Alamat { get; set; }
     
        public string NoTelpon { get; set; }
       
        public string Fax { get; set; }
       
        public string BidangUsaha { get; set; }
    }
}