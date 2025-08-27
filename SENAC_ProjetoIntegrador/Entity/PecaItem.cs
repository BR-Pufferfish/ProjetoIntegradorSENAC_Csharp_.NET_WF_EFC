using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAC_ProjetoIntegrador.Entity
{
    public class PecaItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public required string Nome { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Custo { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }
        
        public int Estoque { get; set; }
        public int CodBarras { get; set; }
        public int NCM { get; set; }
        public string? Descricao { get; set; }
        public int Ano { get; set; }
        public string Tipo { get; set; }
        public string TipoEquipamento { get; set; }

    }
}
