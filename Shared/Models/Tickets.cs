using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsConDetalles.Shared.Models
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }

        [Required(ErrorMessage = "Debe de agregar una Fecha")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El campo Solicitado Por es obligatorio")]
        [StringLength(35, ErrorMessage = "Has ingresadp mas de {0} caracteres")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "El campo SolicitadoPor solo debe de contener caracteres alfabeticos")]
        public string SolicitadoPor { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Asunto es obligatorio")]
        [StringLength(75, ErrorMessage = "Has ingresado mas de {0} caracteres")]
        public string Asunto { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Descripcion es obligatorio")]
        [StringLength(75, ErrorMessage = "Has ingresado mas de {0} caracteres")]
        public string Descripcion { get; set; } = string.Empty;

        [ForeignKey("TicketId")]
        public ICollection<TicketsDetalle> TicketsDetalle { get; set; } = new List<TicketsDetalle>();
    }
}
