using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mintic.App.Dominio;
using Mintic.App.Persistencia.AppRepositories;

namespace Mintic.App.Presentacion.Pages.CrudPersona
{
    public class CreateModel : PageModel
    {
        private readonly Mintic.App.Persistencia.AppRepositories.Conexion _context;

        public CreateModel(Mintic.App.Persistencia.AppRepositories.Conexion context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Persona Persona { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Personas.Add(Persona);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
