using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaksi.DataAccess.Repository.IRepository;
using Transaksi.Models;

namespace Transaksi.DataAccess.Repository
{
    public class PerusahaanRepository : Repository<Perusahaan>, IPerusahaanRepository
    {
        private readonly ApplicationDbContext _db;
        public PerusahaanRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        void IPerusahaanRepository.Save()
        {
            _db.SaveChanges();
        }

        void IPerusahaanRepository.Update(Perusahaan perusahaan)
        {
            var ObjFromDb = _db.Perusahaan.FirstOrDefault(u => u.Id == perusahaan.Id);
            ObjFromDb.Nama = perusahaan.Nama;
            ObjFromDb.Alamat = perusahaan.Alamat;
            ObjFromDb.NoTelpon = perusahaan.NoTelpon;
            ObjFromDb.Fax = perusahaan.Fax;
            ObjFromDb.BidangUsaha = perusahaan.BidangUsaha;
           

        }
    }
}
