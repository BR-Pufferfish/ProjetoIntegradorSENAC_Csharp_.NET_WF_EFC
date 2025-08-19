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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool loginValido = ValidarLogin(txtUsuario.Text, txtSenha.Text);
            if (loginValido)
            {
                this.Hide();
                var frmPrincipal = new Menu(txtUsuario.Text, txtSenha.Text);
                frmPrincipal.Show();
            }
        }

        private bool ValidarLogin(string nome, string senha)
        {
            bool usuarioValido = false;
            //Conecta no banco se o mesmo estiver acessivel.
            using (var bd = new AplicacaoDBContext())
            {
                // Verifica se o usuário existe no banco de dados
                var usuario = bd.Pessoas.FirstOrDefault(u => u.Nome == nome && u.Senha == senha);
                if (usuario != null)
                {
                    usuarioValido = true;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // SE email e senha forem validos
            if (usuarioValido)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorreto(s)");
            }
            return false;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuário")
                txtUsuario.Text = string.Empty;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
                txtUsuario.Text = "Usuário";
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
                txtSenha.Text = string.Empty;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == string.Empty)
                txtSenha.Text = "Senha";
        }
    }
}
