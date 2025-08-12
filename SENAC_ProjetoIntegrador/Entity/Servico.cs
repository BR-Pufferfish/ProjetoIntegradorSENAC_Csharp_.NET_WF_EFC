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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public required int Id { get; set; }
        [MaxLength(100)]
        public required string Nome { get; set; }
        public required string Categoria { get; set; }
        public required string Tipo { get; set; }
        public decimal Valor { get; set; }
        public string? Descricao { get; set; }
    }
}
