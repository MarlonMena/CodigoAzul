namespace Mintic.App.Dominio
{
    public class Persona
    {
        public int Id {get; set;}

        public string Nombres {get; set;}
        public string Apellidos {get; set;}
        public string Codigo {get; set;}
        public int Edad {get; set;}
        public Rol RolPersona {get; set;}
        public string Cedula{get;set;}
        public string Email{get;set;}
        public string Celular{get;set;}
        public string Municipio{get;set;}
        public string Departamento{get;set;}
        public string Fijo{get;set;}
        public string Direccion{get;set;}
        public string Usuario{get;set;}
        public string Password{get;set;}

        
    }
}