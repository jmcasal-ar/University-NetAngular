using System;
using System.ComponentModel.DataAnnotations;

namespace University.BL.DTOs
{
    public class StudentDTO
    {
        
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }

        //hacemos una propiedad personalizada, de consulta, para no hacer en pantalla la contatenación
        public string FullName
        {
            //unicamente con un get
            get { return string.Format("{0} {1}", LastName, FirstName); }
        }
    }
}
