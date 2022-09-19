using System.Data.Entity;
using University.BL.Models;


namespace University.BL.Data
{
    //DbContext permite trabajar con EF
    public class UniversityContext : DbContext
    {
        //vamos a crear una variable privada estática de tipo university context para aplicar Singleton
        private static UniversityContext universityContext = null;
        //iniciar los datos
        public UniversityContext()
            : base("UniversityContext")
        {

        }

        //como ya tenemos los objetos mapeados en Models, vinculamos las tablas con las clases
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        //creamos metodo estatico para obtener el metodo sin instanciar la clase
        //con el objetivo de trabajar con el patron singleton
        public static UniversityContext Create()
        {
            //si este universitYContext la primera vez es nulo, instancie de forma estatica
            //Estamos diciendo que la segunda vez que llamemos al create la variable ya no debería
            //de ser nula, entonces tiene un valor instanciado y trabajamos con eso
            
            return new UniversityContext();
        }
    }
}