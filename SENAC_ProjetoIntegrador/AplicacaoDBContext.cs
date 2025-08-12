using Microsoft.EntityFrameworkCore;
using SENAC_ProjetoIntegrador.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENAC_ProjetoIntegrador
{
    public class AplicacaoDBContext : DbContext
    {
        // 1 - Construtor do banco de dados
        public AplicacaoDBContext() : base()
        {
        
        }

        // 2 - Construtor com opções de configuração
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 2.1 - Configuração da string de conexão
            var conexao = "Server=localhost;Database=SENACProjetoIntegrador;User=root;Password=";

            // 2.2 - Configuração do provedor de banco de dados
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
        }

        public DbSet<Equipamento> Equipamentos { get; set; }

        public DbSet<OrdemServico> OrdemServicos { get; set; }

        public DbSet<PecaItem> PecaItems { get; set; }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Servico> Servicos { get; set; }
    }
}
