using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SENAC_ProjetoIntegrador
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public Menu(string nome, string senha)
        {
            InitializeComponent();
            lblHome.Text = "Usuário: " + nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formOrdemServico = new OrdemServicoManutencao();
            formOrdemServico.Show();
        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            var formPessoa = new PessoaManutencao();
            formPessoa.Show();
        }

        private void btnEquipamento_Click(object sender, EventArgs e)
        {
            var formEquipamento = new EquipamentoManutencao();
            formEquipamento.Show();
        }

        private void btnPecaItem_Click(object sender, EventArgs e)
        {
            var formPecaItem = new PecaItemManutencao();
            formPecaItem.Show();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            var formServico = new ServicoManutencao();
            formServico.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
