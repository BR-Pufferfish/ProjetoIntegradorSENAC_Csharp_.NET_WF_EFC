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
        public required string Nome { get; set; }

        [Range(1900, 2100)]
        public required int AnoNasc { get; set; }
        public required string TipoPessoa { get; set; }
        public string? Genero { get; set; }
        public required string Cpf_cnpj { get; set; }
        public string? Razaosoc { get; set; }
        public required string Cargo { get; set; }
        public string? Senha { get; set; }

        [Range(10000000, 99999999)]
        public int Cep { get; set; }
        public required string Pais { get; set; }
        public required string Estado { get; set; }
        public required string Cidade { get; set; }
        public string? Bairro { get; set; }
        public required string Endereco { get; set; }

        [Range(1, 99999)]
        public required int Numero { get; set; }
        public string? Complemento { get; set; }
        public required int DDD { get; set; }
        public required int Celular { get; set; }
        public int Fone { get; set; }
        public required string Email { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtEncerramento { get; set; }
    }
}
