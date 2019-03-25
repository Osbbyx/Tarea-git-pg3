using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace prgramacion3_t6.Models
{
    public class Formulario
    {
        [Required(ErrorMessage = "Por favor colocar su cedula y no usar -")]
        [MaxLength(11, ErrorMessage = "Esta cedula no es valida")]
        public String Cedula { get; set; }
        [Required(ErrorMessage = "Por favor introduzca un nombre")]
        public String Nombre { get; set; }
        [Required(ErrorMessage = "Por favor introduzca un apellido")]
        public String Apellido { get; set; }
        [Range(16, 120, ErrorMessage = "Debe ser mayor de 16")]
        public int Edad { get; set; }
        [MaxLength(10, ErrorMessage = "Numero de telefono invalido")]
        public String Telefono { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public String Email { get; set; }

        public Gender Genero { get; set; }
        public enum Gender
        {
            Masculino, Femenino, Indefinido
        }
        public String EstadoCivil { get; set; }

        public bool Diseñar { get; set; }
        public bool Programar { get; set; }
        public bool Estudiar { get; set; }
        public bool Musica { get; set; }
    }
}