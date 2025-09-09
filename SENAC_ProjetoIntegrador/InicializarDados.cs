
using SENAC_ProjetoIntegrador.Entity;

namespace SENAC_ProjetoIntegrador;

public static class InicializarDados
{
    public static void Inicializar()
    {
        using (var db = new AplicacaoDBContext())
        {
            db.Database.EnsureCreated();

            if(!db.Servicos.Any())
            {
                db.Servicos.Add(new Servico
                {
                    Categoria = "Manutenção",
                    Nome = "Manutenção Preventiva",
                    Situacao = "Ativo",
                    Tipo = "Preventiva",
                    Valor = 150.00M,
                    Descricao = "Serviço de manutenção preventiva para equipamentos eletrônicos.",
                    DtInclusao = DateTime.Now,
                });
            }

            if (!db.Pessoas.Any())
            {
                db.Pessoas.Add(new Pessoa
                {
                    AnoNasc = 1990,
                    Cargo = "Técnico",
                    Cpf_cnpj = "123.456.789-00",
                    Celular = 912345678,
                    Cidade = "São Paulo",
                    Complemento = "Apto 101",
                    DDD = 11,
                    Email = "",
                    Endereco = "Rua das Flores, 123",
                    Estado = "SP",
                    Nome = "João Silva",
                    Numero = 123,
                    Fone = 123 ,
                    Pais = "Brasil",
                    Situacao = "Ativo",
                    TipoPessoa = "Física",
                    DtInclusao = DateTime.Now,
                    Bairro = "Centro",
                    Genero = "Masculino",
                    Razaosoc = null,
                    Senha = "senha123",
                    Cep = 12345678
                });
            }
            db.SaveChanges();
        }
    }
}
