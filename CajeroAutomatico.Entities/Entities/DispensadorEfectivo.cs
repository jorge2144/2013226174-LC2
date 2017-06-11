using CajeroAutomatico.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entities
{
    [Table("DispensadorEfectivos")]
    public class DispensadorEfectivo
    {
        [Key]
        public int dispensadorEfectivoId { get; set; }


        [Required, MaxLength(100)]
        public String ubicacion { get; set; }


        [Required]
        public int dineroTotal { get; set; }


        [Required]
        public int estadoDispensadorId { get; set; }

        [ForeignKey("estadoDispensadorId")]
        public EstadoDispensador EstadoDispensador { get; set; }



    }
}