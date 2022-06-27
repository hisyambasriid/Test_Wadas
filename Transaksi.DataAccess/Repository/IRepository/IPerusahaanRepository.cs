using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Transaksi.Models;

namespace Transaksi.DataAccess.Repository.IRepository
{
    public interface IPerusahaanRepository : IRepository<Perusahaan>
    {
        void Update(Perusahaan perusahaan);
        void Save();
    }
}
