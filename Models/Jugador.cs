using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller1__Mauricio_Mora.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        public string Posicion {  get; set; }
        [Range(0, 150)]
        public int Edad {  get; set; }

        public string Equipo { get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
    }
}
