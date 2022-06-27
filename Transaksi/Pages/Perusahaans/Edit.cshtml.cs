using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transaksi.DataAccess;
using Transaksi.DataAccess.Repository.IRepository;
using Transaksi.Models;

namespace Transaksi.Pages.Perusahaans
{
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public Perusahaan Perusahaan { get; set; }
        public EditModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet(int id)
        {
            Perusahaan = _unitOfWork.Perusahaan.GetFirstOrDefault(u => u.Id == id);
        }
        public async Task<IActionResult> OnPost(Perusahaan perusahaan)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Perusahaan.Update(perusahaan);
                _unitOfWork.Save();
                TempData["success"] = "Data perusahaan berhasil diupdate";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
