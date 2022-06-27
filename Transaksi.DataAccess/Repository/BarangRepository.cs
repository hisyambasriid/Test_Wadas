using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaksi.DataAccess.Repository.IRepository;
using Transaksi.Models;

namespace Transaksi.DataAccess.Repository
{
    public class BarangRepository : Repository<Barang>, IBarangRepository
    {
        private readonly ApplicationDbContext _db;
        public BarangRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        void IBarangRepository.Save()
        {
            _db.SaveChanges();
        }

        void IBarangRepository.Update(Barang barang)
        {
            var ObjFromDb = _db.Barang.FirstOrDefault(u => u.Id == barang.Id);
            ObjFromDb.Nama = barang.Nama;
            ObjFromDb.Harga = barang.Harga;
            ObjFromDb.Satuan = barang.Satuan;           

        }
    }
}
