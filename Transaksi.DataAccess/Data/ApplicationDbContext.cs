using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Transaksi.Models;

namespace Transaksi.DataAccess
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Barang> Barang { get; set; }
        public DbSet<Perusahaan> Perusahaan { get; set; }
        public DbSet<TransaksiDaily> Transaksi { get; set; }
        
    }
}