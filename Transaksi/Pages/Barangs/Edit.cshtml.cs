using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transaksi.DataAccess;
using Transaksi.DataAccess.Repository.IRepository;
using Transaksi.Models;

namespace Transaksi.Pages.Barangs
{
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public Barang Barang { get; set; }
        public EditModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet(int id)
        {
            Barang = _unitOfWork.Barang.GetFirstOrDefault(u => u.Id == id);
        }
        public async Task<IActionResult> OnPost(Barang barang)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Barang.Update(barang);
                _unitOfWork.Save();
                TempData["success"] = "Data barang berhasil diupdate";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
