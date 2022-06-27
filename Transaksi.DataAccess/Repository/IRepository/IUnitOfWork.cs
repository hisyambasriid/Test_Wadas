﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaksi.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IBarangRepository Barang { get; }
        IPerusahaanRepository Perusahaan { get; }
        void Save();
    }
}
