using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mintic.App.Dominio;
using Mintic.App.Persistencia.AppRepositories;

namespace Mintic.App.Presentacion.Pages.CrudGrupo
{
    public class CreateModel : PageModel
    {
        private readonly Mintic.App.Persistencia.AppRepositories.Conexion _context;

        public SelectList ListaFormadores;
        public SelectList ListaTutores;
        
        [BindProperty(SupportsGet =true)]
        public int FormadorID {get; set;}

        [BindProperty]
        public int TutorID {get; set;}

        [BindProperty]
        public String Mensaje {get; set;}

        public CreateModel(Mintic.App.Persistencia.AppRepositories.Conexion context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            var ListaFormadoresBD = _context.Personas.Where(p => p.RolPersona.NombreRol == "Formador");
            var ListaTutoresBD = _context.Personas.Where(p => p.RolPersona.NombreRol == "Tutor");

            ListaFormadores = new SelectList(ListaFormadoresBD, nameof(Persona.Id), nameof(Persona.Nombres), nameof(Persona.Apellidos));
            ListaTutores = new SelectList(ListaTutoresBD, nameof(Persona.Id), nameof(Persona.Nombres), nameof(Persona.Apellidos));
            return Page();
        }

        [BindProperty]
        public Grupo Grupo { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //NO FUNCIONA, QUE SE SUPONE QUE HACE??
            Persona Formador = _context.Personas.FirstOrDefault(p => p.Id == FormadorID);
            Persona Tutor = _context.Personas.FirstOrDefault(p => p.Id == TutorID);
            Grupo.Formador = Formador;
            Grupo.Tutor = Tutor;

            _context.Grupos.Add(Grupo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
