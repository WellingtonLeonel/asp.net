using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MaisUmTesteWebApplication4.Data;
using MaisUmTesteWebApplication4.Models;

namespace MaisUmTesteWebApplication4.Pages.Usuarios
{
    public class DetailsModel : PageModel
    {
        private readonly MaisUmTesteWebApplication4.Models.MaisUmTesteWebApplication4Context _context;

        public DetailsModel(MaisUmTesteWebApplication4.Models.MaisUmTesteWebApplication4Context context)
        {
            _context = context;
        }

        public Usuario Usuario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Usuario = await _context.Usuario.FirstOrDefaultAsync(m => m.UsuarioId == id);

            if (Usuario == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
