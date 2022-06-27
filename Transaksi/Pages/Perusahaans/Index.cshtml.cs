using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transaksi.DataAccess;
using Transaksi.DataAccess.Repository.IRepository;
using Transaksi.Models;

namespace Transaksi.Pages.Perusahaans
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public IEnumerable<Perusahaan> Perusahaans { get; set; }
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
            Perusahaans = _unitOfWork.Perusahaan.GetAll();
        }
    }
}
