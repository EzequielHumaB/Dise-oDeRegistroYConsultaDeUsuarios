using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RegistroUsuarios.Data;
using RegistroUsuarios.Models;

namespace RegistroUsuarios
{
    public class IndexModel : PageModel
    {
        private readonly RegistroUsuarios.Data.RegistroUsuariosContext _context;

        public IndexModel(RegistroUsuarios.Data.RegistroUsuariosContext context)
        {
            _context = context;
        }

        public IList<Categoria> Categoria { get;set; }

        public async Task OnGetAsync()
        {
            Categoria = await _context.Categoria.ToListAsync();
        }
    }
}
