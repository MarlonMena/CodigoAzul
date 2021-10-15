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
    public class DeleteModel : PageModel
    {
        private readonly Mintic.App.Persistencia.AppRepositories.Conexion _context;

        public DeleteModel(Mintic.App.Persistencia.AppRepositories.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
        public Grupo Grupo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grupo = await _context.Grupos.FirstOrDefaultAsync(m => m.Id == id);

            if (Grupo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grupo = await _context.Grupos.FindAsync(id);

            if (Grupo != null)
            {
                _context.Grupos.Remove(Grupo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
