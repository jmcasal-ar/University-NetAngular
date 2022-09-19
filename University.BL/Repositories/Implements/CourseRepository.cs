using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.BL.Data;
using University.BL.Models;

namespace University.BL.Repositories.Implements
{
    public class CourseRepository : GenericRepository<Course>
    {
        //hay que poner que en el constructor debe recibir el contexto de datos 
        //en base le esta diciendo que como estamos heredando, estamos diciendo que la clase padre le va a pasar el contexto y la base de datos
        public CourseRepository(UniversityContext universityContext) : base(universityContext)
        {

        }
    }
}
