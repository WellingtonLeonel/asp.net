using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaisUmTesteWebApplication4.Data;
using MaisUmTesteWebApplication4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaisUmTesteWebApplication4.Pages.Usuarios
{
    
    public class CadastrarModel : PageModel
    {
        private MaisUmTesteWebApplication4Context _context;

        MaisUmTesteWebApplication4Context _context;

            public CadastrarModel(MaisUmTesteWebApplication4Context context)
        {
            _context = context;

        }
      
       

        [BindProperty(SupportsGet = true)]
        public Usuario usuario { get; set; }
        public void OnGet(string nome, string senha)
        {
            if (usuario == null)
            {
                usuario = new Usuario();

            }
        }
        [HttpPost]
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Usuario.Add(usuario);
                _context.SaveChanges();
            }
        }
    }
}