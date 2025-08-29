using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAC_ProjetoIntegrador.Entity
{
    public class Servico
    {
        public Servico()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Situacao { get; set; }
        public required string Nome { get; set; }
        public required string Categoria { get; set; }
        public required string Tipo { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }
        public string? Descricao { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtEncerramento { get; set; }
    }
}
