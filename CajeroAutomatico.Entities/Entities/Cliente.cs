using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities.Entities
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int clienteId { get; set; }

        [Required, MaxLength(150), DisplayName("Nombres")]
        public String nomcliente { get; set; }

        [Required, MaxLength(150), DisplayName("Correo electrónico")]
        public String correoCliente { get; set; }

        [MaxLength(150), DisplayName("Dirección")]
        public String direcCliente { get; set; }

        [MaxLength(20), DisplayName("Teléfono")]
        public String telCliente { get; set; }


    }
}
