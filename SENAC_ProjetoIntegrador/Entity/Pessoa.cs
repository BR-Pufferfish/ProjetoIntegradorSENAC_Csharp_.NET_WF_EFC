using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAC_ProjetoIntegrador.Entity
{
    public class Pessoa
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int AnoNasc { get; set; }
        public string TipoPessoa { get; set; }
        public string Genero { get; set; }
        public string Cpf_cnpj { get; set; }
        public string Razaosoc { get; set; }
        public string Cargo { get; set; }
        public int Cep { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public String Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int DDD { get; set; }
        public int Celular { get; set; }
        public int Fone { get; set; }
        public string Email { get; set; }

    }
}
