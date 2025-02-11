using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApiPractica.Models
{
    public class equipos
    {
        [Key]  // Define que esta es la clave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_equipos { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public int tipo_equipo_id { get; set; }

        public int marca_id { get; set; }

        [StringLength(50)]
        public string modelo { get; set; }

        public int anio_compra { get; set; }

        [Column(TypeName = "NUMERIC(18,4)")]
        public decimal costo { get; set; }

        public int vida_util { get; set; }

        public int estado_equipo_id { get; set; }

        [Required]
        public char estado { get; set; }
    }
}
