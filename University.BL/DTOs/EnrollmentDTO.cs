using University.BL.Models;

namespace University.BL.DTOs
{
    public enum Grade
    {
        //Decimos q A vale 0, B vale 1, etc
        A, B, C, D, E
    }
    public class EnrollmentDTO
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade Grade { get; set; }

        //ACA DECIMOS QUE HAY QUE NAVEGAR A LOS DTOs
        public CourseDTO Course { get; set; }
        public StudentDTO Student { get; set; }
    }
}
