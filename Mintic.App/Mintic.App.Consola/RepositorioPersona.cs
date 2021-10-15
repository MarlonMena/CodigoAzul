/*using Mintic.App.Persistencia.AppRepositories;
using Mintic.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Mintic.App.Consola
{
    public class RepositorioPersona : IRepositorioPersona
    {
        public List<Persona> consultarTodos(){
            Conexion conexion = new Conexion();
            List<Persona> listaPersonas;
            return  listaPersonas;
        }


        public int guardarPersona(Persona persona){
            Conexion conexion = new Conexion();
            conexion.Personas.Add(persona);
            conexion.SaveChanges();
            return persona.Id;
        }

         public void eliminarPersona(int Id){
            Conexion conexion = new Conexion();
            Persona persona = conexion.Personas.First(p => p.Id == Id);
            conexion.Personas.Remove(persona);
         }

         public void actualizarPersona(Persona persona){
            Conexion conexion = new Conexion();
            Persona p = conexion.Personas.First(p => p.Id == persona.Id);
            p.Nombres = persona.Nombres;
            p.Apellidos = persona.Apellidos;
            p.Codigo = persona.Codigo;
            p.Edad = persona.Edad;
            p.RolPersona = persona.RolPersona;
            p.Cedula = persona.Cedula;
            p.Email = persona.Email;
            p.Celular = persona.Celular;
            p.Municipio = persona.Municipio;
            p.Departamento = persona.Departamento;
            p.Fijo = persona.Fijo;
            p.Direccion = persona.Direccion;
            conexion.SaveChanges();
         }



    
        
    }
}
*/