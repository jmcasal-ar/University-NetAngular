using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //usamos los datata annotations

namespace University.BL.DTOs
{
    public class CourseDTO
    {
        //Agregamos las propiedades que había en el modelo
        [Required(ErrorMessage ="The field Course ID is required")]
        public int CourseID { get; set; }
        [Required(ErrorMessage = "The field Title is required")]
        [StringLength(50)]
        public string Title { get; set; }
        [Required(ErrorMessage = "The field Credits is required")]
        public int Credits { get; set; }

        //Podemos agregar propiedades que no pertenezcan al modelo, sino que solo al DTO.
        //El DTO no guarda ninguna relación las tablas. Ejemplo:
        //public string Description { get; set; }

    }
}
