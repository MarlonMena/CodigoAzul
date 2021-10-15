using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mintic.App.Dominio;
using Mintic.App.Persistencia.AppRepositories;

namespace Mintic.App.Presentacion.Pages.CrudNota
{
    public class CreateModel : PageModel
    {
        private readonly Mintic.App.Persistencia.AppRepositories.Conexion _context;

        public CreateModel(Mintic.App.Persistencia.AppRepositories.Conexion context)
        {
            _context = context;
        }

        public SelectList Estudiantes;

        public IActionResult OnGet()
        {
            var ListadoEstudiantes = _context.Estudiantes.ToList();
            Estudiantes = new SelectList(ListadoEstudiantes, nameof(Estudiante.Id), nameof(Estudiante.Apellidos),
            nameof(Estudiante.Apellidos), nameof(Estudiante.Cedula));
            return Page();
        }

        [BindProperty]
        public Nota Nota { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Notas.Add(Nota);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
