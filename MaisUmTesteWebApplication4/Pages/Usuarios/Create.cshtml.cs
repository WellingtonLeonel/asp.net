using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MaisUmTesteWebApplication4.Data;
using MaisUmTesteWebApplication4.Models;

namespace MaisUmTesteWebApplication4.Pages.Usuarios
{
    public class CreateModel : PageModel
    {
        private readonly MaisUmTesteWebApplication4.Models.MaisUmTesteWebApplication4Context _context;

        public CreateModel(MaisUmTesteWebApplication4.Models.MaisUmTesteWebApplication4Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Usuario Usuario { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Usuario.Add(Usuario);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}