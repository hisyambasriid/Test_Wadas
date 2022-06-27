using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaksi.DataAccess.Repository.IRepository;

namespace Transaksi.DataAccess.Repository
{      
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Barang = new BarangRepository(_db);
        }
        public IBarangRepository Barang { get; private set; }
        public IPerusahaanRepository Perusahaan { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
