using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mintic.App.Dominio;
using Mintic.App.Persistencia.AppRepositories;

namespace Mintic.App.Presentacion.Pages.CrudGrupo
{
    public class IndexModel : PageModel
    {
        private readonly Mintic.App.Persistencia.AppRepositories.Conexion _context;

        public IndexModel(Mintic.App.Persistencia.AppRepositories.Conexion context)
        {
            _context = context;
        }

        public IList<Grupo> Grupo { get;set; }

        public async Task OnGetAsync()
        {
            Grupo = await _context.Grupos.Include(g => g.Formador).Include(g => g.Tutor).ToListAsync();
        }
    }
}
