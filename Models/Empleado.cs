using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AGMBankingV1.Models
{
    //Tabla que guardada los registros de los empleados
    public class Empleado
    {
        [Key]
        public int Id { get; set; }

        //Especificaciones para los campos para la base de datos y los formularios
        [Required  (ErrorMessage ="Este campo es requerido")]
        [MaxLength(25, ErrorMessage ="Este campo solo acepta máximo 25 caracteres")]
        [MinLength (2, ErrorMessage ="Este campo solo acepta minimo 2 caracteres" )]
        //[RegularExpression]     Investigar copmo usar
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(25, ErrorMessage = "Este campo solo acepta máximo 25 caracteres")]
        [MinLength(2, ErrorMessage = "Este campo solo acepta minimo 2 caracteres")]
        public string Apellido { get; set; }
        
        public int Edad { get; set; }
    }
}
