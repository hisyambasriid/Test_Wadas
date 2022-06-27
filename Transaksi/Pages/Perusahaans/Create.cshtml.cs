using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transaksi.DataAccess;
using Transaksi.DataAccess.Repository.IRepository;
using Transaksi.Models;

namespace Transaksi.Pages.Perusahaans
{
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public Perusahaan Perusahaan { get; set; }
        public CreateModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost(Perusahaan perusahaan)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Perusahaan.Add(perusahaan);
                _unitOfWork.Save();

                TempData["success"] = "Data perusahaan berhasil ditambahkan";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
