using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webApiPractica.Models
{
    public class marcas
    {
        [Key]  // Define que esta es la clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_marcas { get; set; }

        [Required]
        [StringLength(50)]

        public string nombre_marca { get; set; }

        [Required]
        public char estado { get; set; }
    }

    //Hola
}
