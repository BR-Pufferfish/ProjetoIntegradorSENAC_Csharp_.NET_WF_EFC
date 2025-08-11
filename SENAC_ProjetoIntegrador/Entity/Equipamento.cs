using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAC_ProjetoIntegrador.Entity
{
    public class Equipamento
    {
        public int Id { get; set; }
        [Required]
        public required string Nome { get; set; }
        public string Modelo { get; set; } = string.Empty;
        public int Ano { get; set; }
        public int CodBarra { get; set; }
        public int NCM { get; set; }
        public decimal Custo { get; set; }
        public decimal Valor { get; set; }
        public string Lucro { get; set; }
    }
}
