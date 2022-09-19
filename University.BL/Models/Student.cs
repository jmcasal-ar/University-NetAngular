using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.BL.Models
{
    [Table("Course", Schema = "dbo")]
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Agregamos relación con la tabla enrollment
        //Estamos diciendo que la tabla/objeto estudiante va a estar muchas veces (eso es ICollection)
        //en la tabla/clase enrollment. Desde afuera el objeto estudiante puede estar en Enrollment
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
