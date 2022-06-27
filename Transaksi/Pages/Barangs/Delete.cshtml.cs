using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transaksi.DataAccess;
using Transaksi.DataAccess.Repository.IRepository;
using Transaksi.Models;

namespace Transaksi.Pages.Barangs
{
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public Barang Barang { get; set; }
        public DeleteModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet(int id)
        {
            Barang = _unitOfWork.Barang.GetFirstOrDefault(u => u.Id == id);
        }
        public async Task<IActionResult> OnPost()
        {
           
            var BarangFromDb = _unitOfWork.Barang.GetFirstOrDefault(u => u.Id == Barang.Id);
            if (BarangFromDb != null)
            {
                _unitOfWork.Barang.Remove(BarangFromDb);
                _unitOfWork.Save();
                TempData["success"] = "Data barang berhasil dihapus";
                return RedirectToPage("Index");
            }              
                        
            return Page();
        }
    }
}
