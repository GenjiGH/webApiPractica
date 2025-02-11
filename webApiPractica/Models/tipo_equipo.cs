using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webApiPractica.Models
{
    public class tipo_equipo
    {
        [Key]  // Define que esta es la clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_tipo_equipo { get; set; }

        [Required]
        [StringLength(50)]

        public string descripcion { get; set; }

        [Required]
        public char estado { get; set; }
    }
}
