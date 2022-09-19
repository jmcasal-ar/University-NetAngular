using AutoMapper;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using University.BL.Data;
using University.BL.DTOs;
using University.BL.Models;
using University.BL.Repositories.Implements;
using University.BL.Services.Implements;

namespace University.API.Controllers
{
    public class CoursesController : ApiController
    {
        //para gestionar la conexion modelos-dto
        private IMapper mapper;
        //vamos a inicializar el servicio. El servicio necesita que mandemos de parametro el Repositorio, y el repositorio el Context para que se cree
        private readonly CourseService courseService = new CourseService(new CourseRepository(UniversityContext.Create()));

        //construimos el constructor del controlador
        public CoursesController()
        {
            //con esto creamos el mapeo
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        //creamos el get. Ahora estamos trabajando con HTTP Action Result
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            //vamos a dar una lista. El await es porque es el metodo asincrono
            var courses = await courseService.GetAll();
            //por cada registro que encuentre en la lista de cursos.
            //x va a representar a cada curso. Indicamos cual es es el destino y cual es el origen de la informacion
            var coursesDTO = courses.Select(x => mapper.Map <CourseDTO>(x));
            //la información que vamos a reternar es el courseDTO

            //aparte del OK también podemos devolver datos
            return Ok(coursesDTO);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetByID(int id)
        {
            //vamos a dar una lista. El await es porque es el metodo asincrono
            var course = await courseService.GetById(id);

            //hacemos la validacion del nulo
            //si el curso es nulo
            if (course == null)
                return NotFound(); //devolvemos 404

            var courseDTO = mapper.Map<CourseDTO>(course);
            return Ok(courseDTO);
        }

        //Importante: el consumo ya no es por nombre sino por tipo de metodo, lo consumimos por parametro
        [HttpPost]
        public async Task<IHttpActionResult> Post(CourseDTO courseDTO)
        {
            //chequeo si los datos del modelo son validos. Si el modelo no es valido
            if (!ModelState.IsValid)
                //retorna error 400 con los datos del modelo
                return BadRequest(ModelState);


            //control k s subrayando la linea de codigo para hacer un try catch
            try
            {
                var course = mapper.Map<Course>(courseDTO); //hacermos la conversion de un DTO a un curso
                course = await courseService.Insert(course); //luego hacemos el respectivo insert a traves del servicio y el repositorio
                return Ok(course);
            }
            catch (Exception ex) { return InternalServerError(ex); }

        }
    }
}
