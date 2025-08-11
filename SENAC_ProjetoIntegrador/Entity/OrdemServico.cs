using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAC_ProjetoIntegrador.Entity
{
    public class OrdemServico
    {
        public int Id { get; set; }
        [Required]
        public required string Equipamento { get; set; }
        public string Modelo { get; set; }
        public string Cliente { get; set; }
        public int CpfCnpj { get; set; }
        public string DescricaoGeral { get; set; }
        public string DescricaoEncerramento { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
