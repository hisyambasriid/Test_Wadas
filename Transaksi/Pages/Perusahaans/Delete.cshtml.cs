using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transaksi.DataAccess;
using Transaksi.DataAccess.Repository.IRepository;
using Transaksi.Models;

namespace Transaksi.Pages.Perusahaans
{
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public Perusahaan Perusahaan { get; set; }
        public DeleteModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet(int id)
        {
            Perusahaan = _unitOfWork.Perusahaan.GetFirstOrDefault(u => u.Id == id);
        }
        public async Task<IActionResult> OnPost()
        {
           
            var BarangFromDb = _unitOfWork.Barang.GetFirstOrDefault(u => u.Id == Perusahaan.Id);
            if (BarangFromDb != null)
            {
                _unitOfWork.Barang.Remove(BarangFromDb);
                _unitOfWork.Save();
                TempData["success"] = "Data perusahaan berhasil dihapus";
                return RedirectToPage("Index");
            }              
                        
            return Page();
        }
    }
}
