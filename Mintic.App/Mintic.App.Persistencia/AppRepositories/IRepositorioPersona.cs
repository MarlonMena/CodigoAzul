using System.Collections.Generic;
using System.Linq;
using Mintic.App.Dominio;

namespace Mintic.App.Persistencia.AppRepositories
{
    public interface IRepositorioPersona
    {
        public List<Persona> consultarTodos();
        
        public int guardarPersona(Persona persona);

         public void eliminarPersona(int Id);

         public void actualizarPersona(Persona persona);

         
    }
}