using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsConDetalles.Shared.Models
{
    public class TicketsDetalle
    {
        [Key]
        public int DetalleId { get; set; }

        [ForeignKey("TicketId")]
        public int TicketId { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [StringLength(35, ErrorMessage = "El Emisor es muy largo. Excede los {0} caracteres")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "El campo Emisor solo debe de contener caracteres alfabeticos")]
        public string Emisor { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Mensaje es obligatorio")]
        [StringLength(75, ErrorMessage = "Has ingresado mas de {0} caracteres")]
        public string Mensaje { get; set; } = string.Empty;
    }
}
