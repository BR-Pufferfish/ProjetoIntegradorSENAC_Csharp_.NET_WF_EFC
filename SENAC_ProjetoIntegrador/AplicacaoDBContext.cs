using Microsoft.EntityFrameworkCore;
using SENAC_ProjetoIntegrador.Entity;

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
            var conexao = "Server=localhost;Database=senacprojetointegrador;User=root;Password=";

            // 2.2 - Configuração do provedor de banco de dados
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
        }

        // definindo casas decimais no banco de dados
        //override protected void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Equipamento>()
        //        .Property(os => os.Estoque)
        //        .HasColumnType("decimal(10,2)");
        //}
        public DbSet<Equipamento> Equipamentos { get; set; }

        public DbSet<OrdemServico> OrdemServicos { get; set; }

        public DbSet<OrdemServicoPecaItem> OrdemServicoPecaItem { get; set; }

        public DbSet<OrdemServicoServico> OrdemServicoServico { get; set; }

        public DbSet<PecaItem> PecaItems { get; set; }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Servico> Servicos { get; set; }

        public DbSet<Venda> Venda { get; set; }

        public DbSet<VendaEquipamento> VendaEquipamento { get; set; }


    }
}
