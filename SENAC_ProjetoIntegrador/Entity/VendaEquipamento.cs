using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAC_ProjetoIntegrador.Entity
{
    public class VendaEquipamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int VendaId { get; set; }
        public virtual Venda Venda { get; set; }
        public int EquipamentoId { get; set; }
        //public virtual Equipamento Equipamento { get; set; }
    }
}
