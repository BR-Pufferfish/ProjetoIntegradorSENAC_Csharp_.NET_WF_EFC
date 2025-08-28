using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAC_ProjetoIntegrador.Entity
{
    public class Equipamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Nome { get; set; }
        public string Modelo { get; set; }

        [Range(1900, 2100)]
        public int Ano { get; set; }


        public int CodBarra { get; set; }


        public int NCM { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Custo { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }

        [Range(0, 10000)]
        public int Estoque { get; set; }

        public DateTime DtInclusao { get; set; }
        public DateTime DtEncerramento { get; set; }
    }
}
