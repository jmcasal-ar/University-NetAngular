using University.BL.Models;
using University.BL.Repositories;

namespace University.BL.Services.Implements
{
    public class CourseService : GenericService<Course>, ICourseService
    {
        //recibe un repositorio, pero ya no uno regenerico, sino que el de Cursos
        public CourseService(ICourseRepository courseRepository) : base(courseRepository)
        {

        }
    }
}
