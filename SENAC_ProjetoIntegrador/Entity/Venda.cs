using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAC_ProjetoIntegrador.Entity
{
    public class Venda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Cliente { get; set; }
        public required string CpfCnpj { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorTotal { get; set; }
        public DateTime DtInclusao { get; set; }
    }
}
