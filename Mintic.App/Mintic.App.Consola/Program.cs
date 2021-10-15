using System;
using Mintic.App.Dominio;
using Mintic.App.Persistencia.AppRepositories;
using System.Linq;

namespace Mintic.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexion conexion = new Conexion();
            Rol r1 = new Rol(){
                NombreRol = "Tutor",
                CodigoRol = "T-001"
            };
            conexion.Roles.Add(r1);
            conexion.SaveChanges();

            Persona p1 = new Persona(){
                Nombres = "Memo",
                Apellidos = "Baquero",
                RolPersona = r1
            };
            conexion.Personas.Add(p1);
            conexion.SaveChanges();

            Rol r2 = new Rol(){
                NombreRol = "Formador",
                CodigoRol = "F-002"
            };
            conexion.Roles.Add(r2);
            conexion.SaveChanges();

            Persona p2 = new Persona(){
                Nombres = "Pepe",
                Apellidos = "Eraso",
                RolPersona = r2
            };
            conexion.Personas.Add(p2);
            conexion.SaveChanges();


            Grupo g = new Grupo(){
                Tutor = p1,
                Formador = p2
            };
            conexion.Grupos.Add(g);
            conexion.SaveChanges();

            Estudiante e = new Estudiante(){
                Nombres = "Soy Estudiante",
                GrupoEstudiante = g
            };
            conexion.Estudiantes.Add(e);
            conexion.SaveChanges();



            /*RepositorioPersona repositorioPersona = new RepositorioPersona();
            repositorioPersona.consultarTodos();
            repositorioPersona.guardarPersona(new Persona ());
            repositorioPersona.eliminarPersona(4);
            repositorioPersona.actualizarPersona(new Persona());
            */
            
            
            /*Conexion conexion = new Conexion();
            int id = 5;
            Persona persona = conexion.Personas.First(p => p.Id == id);
            persona.Nombres = "Pascualito";
            conexion.SaveChanges();
            */



            
        }





        public void codigosPersona()
        {
            //editar
            /*Conexion conexion = new Conexion();
            Rol rol = new Rol();
            rol.NombreRol = "Tutor";
            rol.CodigoRol = "T-002";
            conexion.Roles.Add(rol);
            conexion.SaveChanges();

            Persona persona = new Persona();
            persona.Nombres = "Miguelito";
            persona.Apellidos = "Apellidos de Miguelito";
            persona.Email = "miguelito@miguelito";
            persona.RolPersona = rol;
            conexion.Personas.Add(persona);
            conexion.SaveChanges();
            */



            //eliminar

            /*Conexion conexion = new Conexion();
            int id = 4;
            Persona persona = conexion.Personas.First(p => p.Id == id);
            System.Console.WriteLine(persona.Nombres);
            conexion.Personas.Remove(persona);
            conexion.SaveChanges();
            */


            //Crear

            /*Conexion conexion = new Conexion();
            Persona persona = new Persona();
            persona.Nombres = "Pascual";
            persona.Apellidos ="Bravo";
            persona.Cedula = "qwer";
            persona.Email = "pascual@bbravo.com";
            conexion.Personas.Add(persona);
            conexion.SaveChanges();
            */

        }

            
            

        
    }
}
