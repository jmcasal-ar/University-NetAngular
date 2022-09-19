using AutoMapper;
using University.BL.Models;

namespace University.BL.DTOs
{
    public class MapperConfig
    {
        //va a ofrecer un metodo estatico que va a devolver un mapper configuration
        //no recibe paremetros
        public static MapperConfiguration MapperConfiguration()
        {
            //usamos expresion lambda cfg 
            return new MapperConfiguration(cfg =>
            {
                //mapea: cuando recibe un curso debe hacer la homologacion a un curso DTO
                cfg.CreateMap<Course, CourseDTO>(); //GET
                cfg.CreateMap<CourseDTO, Course>(); //Metodos POST - PUT

                cfg.CreateMap<Student, StudentDTO>();
                cfg.CreateMap<StudentDTO, Student>();

                cfg.CreateMap<Enrollment, EnrollmentDTO>();
                cfg.CreateMap<EnrollmentDTO, Enrollment>();
            });
        }
    }
}
