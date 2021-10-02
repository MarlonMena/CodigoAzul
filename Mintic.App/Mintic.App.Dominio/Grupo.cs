namespace Mintic.App.Dominio
{
    public class Grupo
    {
        public int Id{get;set;}
        public Persona Formador{get;set;}
        public Persona Tutor{get;set;}
        public string CodigoGrupo{get;set;}
        public Ciclo CicloGrupo{get;set;}
    }
}