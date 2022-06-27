using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transaksi.DataAccess;
using Transaksi.DataAccess.Repository.IRepository;
using Transaksi.Models;

namespace Transaksi.Pages.Barangs
{
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public Barang Barang { get; set; }
        public CreateModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost(Barang barang)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Barang.Add(barang);
                _unitOfWork.Save();

                TempData["success"] = "Data barang berhasil ditambahkan";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
