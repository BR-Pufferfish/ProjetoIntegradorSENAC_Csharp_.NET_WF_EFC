using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAC_ProjetoIntegrador.Entity
{
    public class PecaItem
    {
        public int Id { get; set; }
        [Required]
        public required string Nome { get; set; }
        public decimal Custo { get; set; }
        public decimal Valor { get; set; }
        public decimal Lucro { get; set; }
        public int CodBarras { get; set; }
        public int NCM { get; set; }
        public string Descricao { get; set; }


    }
}
