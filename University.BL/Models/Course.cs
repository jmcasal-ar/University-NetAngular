using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //esto mapea la clase a la tabla de la DB

namespace University.BL.Models
{
    [Table("Course", Schema = "dbo")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//indicamos q no es autoincremental
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //Agregamos relación con la tabla enrollment
        //Estamos diciendo que la tabla/objeto estudiante va a estar muchas veces (eso es ICollection)
        //en la tabla/clase enrollment. Desde afuera el objeto estudiante puede estar en Enrollment
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}

