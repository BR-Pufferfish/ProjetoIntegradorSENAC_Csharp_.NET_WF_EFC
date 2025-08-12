using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAC_ProjetoIntegrador.Entity
{
    public class Servico
    {
        public int Id { get; set; }
        [Required]
        public required string Nome { get; set; }
        public required string Categoria { get; set; }
        public required string Tipo { get; set; }
        public decimal Valor { get; set; }
        public string? Descricao { get; set; }
    }
}
