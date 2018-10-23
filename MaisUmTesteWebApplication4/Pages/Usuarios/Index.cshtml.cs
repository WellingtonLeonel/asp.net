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
    public class IndexModel : PageModel
    {
        private readonly MaisUmTesteWebApplication4.Models.MaisUmTesteWebApplication4Context _context;

        public IndexModel(MaisUmTesteWebApplication4.Models.MaisUmTesteWebApplication4Context context)
        {
            _context = context;
        }

        public IList<Usuario> Usuario { get;set; }

        public async Task OnGetAsync()
        {
            Usuario = await _context.Usuario.ToListAsync();
        }
    }
}
