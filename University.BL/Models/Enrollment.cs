﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.BL.Models
{
    //Creamos un enumerador para enviar los valores posibles de la tabla
    public enum Grade
    {
        //Decimos q A vale 0, B vale 1, etc
        A, B, C, D, E
    }

    [Table("Enrollment", Schema = "dbo")]
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        [ForeignKey("Course")]
        public int CourseID { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Grade Grade { get; set; }

        //relacionar tablas
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
