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
    }
}
