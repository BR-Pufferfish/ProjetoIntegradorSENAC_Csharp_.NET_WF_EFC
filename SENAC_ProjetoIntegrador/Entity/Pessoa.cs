using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAC_ProjetoIntegrador.Entity
{
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public required string Nome { get; set; }
        public required int AnoNasc { get; set; }
        public required string TipoPessoa { get; set; }
        public string? Genero { get; set; }
        public required string Cpf_cnpj { get; set; }
        public required string Razaosoc { get; set; }
        public required string Cargo { get; set; }
        public int Cep { get; set; }
        public string? Pais { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public required string Endereco { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public int DDD { get; set; }
        public int Celular { get; set; }
        public int Fone { get; set; }
        public required string Email { get; set; }
    }
}
