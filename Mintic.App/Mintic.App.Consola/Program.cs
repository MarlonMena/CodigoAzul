using System;
using Mintic.App.Dominio;
using Mintic.App.Persistencia.AppRepositories;
using System.Linq;

namespace Misiontic.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexion conexion = new Conexion();

            Rol r = conexion.Roles.First(r => r.Id ==1);
            
            Estudiante e = new Estudiante();
            e.Nombres = "Soy Angel el Estudiante";
            e.Apellidos = "Marquez Perezz";
            e.Cedula = "1000002";
            /*e.RolPersona = r;*/
            conexion.Estudiantes.Add(e);
            conexion.SaveChanges();
            System.Console.WriteLine("Persona ingresada con Id: "+e.Id);



            
            /*RepositorioPersona repositorioPersona = new RepositorioPersona();
            repositorioPersona.consultarTodos();
            repositorioPersona.guardarPersona();
            repositorioPersona.eliminarPersona(4);
            repositorioPersona.actualizarPersona(new Persona());*/



        }



        /*public void codigosPersona(string[] args)
        {
            Conexion conexion = new Conexion();

            Rol r = new Rol();
            r.NombreRol ="Formador";
            r.CodigoRol ="F-001";
            conexion.Roles.Add(r);
            conexion.SaveChanges();
            System.Console.WriteLine("Rol guardado con el Id: "+ r.Id);

            Persona p = new Persona();
            p.Nombres = "Miguel Angel";
            p.Apellidos = "Ortiz Velez";
            p.Cedula = "109087431";
            p.Email = "miguel@angel.com";
            p.Celular = "3002132211";
            p.Municipio = "Medellin";
            p.Departamento = "Antioquia";
            p.Fijo = "2145532";
            p.Direccion = "Calle 3 # 12 B";
            p.RolPersona = r;
            conexion.Personas.Add(p);
            conexion.SaveChanges();
            System.Console.WriteLine("Persona guardada con el Id: " + p.Id);
        }*/
    }
}
