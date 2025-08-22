using SENAC_ProjetoIntegrador.Entity;
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
    private Pessoa _pessoa;
    public partial class PessoaCad : Form
    {
        public PessoaCad()
        {
            InitializeComponent();
        }

        public PessoaCad(Pessoa pessoa)
        {
            _pessoa = pessoa;
            InitializeComponent();

            CarregarDadosPessoa();
        }

        private void CarregarDadosPessoa()
        {
            if(_pessoa != null)
            {
                txtNome.Text = _pessoa.Nome;
                txtCpfCnpj.Text = _pessoa.CPF;
                txtDataNascimento.Text = _pessoa.DataNascimento.ToString("dd/MM/yyyy");
                txtEmail.Text = _pessoa.Email;
                txtTelefone.Text = _pessoa.Telefone;
                txtEndereco.Text = _pessoa.Endereco;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
