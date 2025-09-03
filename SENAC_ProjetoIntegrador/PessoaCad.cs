using SENAC_ProjetoIntegrador.Entity;
using SENAC_ProjetoIntegrador.Enum;
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
    public partial class PessoaCad : Form
    {
        private Pessoa _pessoa;
        public PessoaCad()
        {
            InitializeComponent();
        }

        public PessoaCad(Pessoa pessoa)
        {
            _pessoa = pessoa;
            InitializeComponent();

            CarregarDadosPessoa();
            CarregarCbbSituacao();
        }

        private void CarregarCbbSituacao()
        {
            var situacoes = new List<Situacao>();

            situacoes = System.Enum.GetValues(typeof(Situacao)).Cast<Situacao>().ToList();
        }

        private void CarregarDadosPessoa()
        {
            if (_pessoa != null)
            {
                cbbSituacao.Text = _pessoa.Situacao;
                txtNome.Text = _pessoa.Nome;
                txtCpfCnpj.Text = _pessoa.Cpf_cnpj;
                txtAnoNasc.MaxLength = 4;
                txtAnoNasc.Text = _pessoa.AnoNasc.ToString();
                txtRazaoSoc.Text = _pessoa.Razaosoc;
                txtCargo.Text = _pessoa.Cargo;
                txtCep.Text = _pessoa.Cep.ToString();
                txtPais.Text = _pessoa.Pais;
                txtEstado.Text = _pessoa.Estado;
                txtCidade.Text = _pessoa.Cidade;
                txtBairro.Text = _pessoa.Bairro;
                txtEndereco.Text = _pessoa.Endereco;
                txtNumero.Text = _pessoa.Numero.ToString();
                txtComplemento.Text = _pessoa.Complemento;
                txtDDD.Text = _pessoa.DDD.ToString();
                txtCelular.Text = _pessoa.Celular.ToString();
                txtFone.Text = _pessoa.Fone.ToString();
                txtEmail.Text = _pessoa.Email;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (_pessoa == null)
            {
                InserirPessoa();
            }
            else
            {
                AtualizarPessoa();
            }
        }

        private void AtualizarPessoa()
        {
            using (var bd = new AplicacaoDBContext())
            {
                if (bd.Pessoas.Any(p => p.Nome == txtNome.Text && p.Cpf_cnpj == _pessoa.Cpf_cnpj))
                {
                    MessageBox.Show("Já existe uma pessoa com esse nome ou CPF/CNPJ.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                string situacao = cbbSituacao.Text;
                string nome = txtNome.Text;
                int anoNasc = int.Parse(txtAnoNasc.Text);
                //string tipoPessoa = cbbTipoPessoa.Text;
                string genero = txtGenero.Text;
                string cpfCnpj = txtCpfCnpj.Text;
                string razaoSoc = txtRazaoSoc.Text;
                string cargo = txtCargo.Text;
                string senha = txtSenha.Text;
                int cep = int.Parse(txtCep.Text);
                string pais = txtPais.Text;
                string estado = txtEstado.Text;
                string cidade = txtCidade.Text;
                string bairro = txtBairro.Text;
                string endereco = txtEndereco.Text;
                int numero = int.Parse(txtNumero.Text);
                string complemento = txtComplemento.Text;
                int ddd = int.Parse(txtDDD.Text);
                int celular = int.Parse(txtCelular.Text);
                int fone = int.Parse(txtFone.Text);
                string email = txtEmail.Text;

                var pessoa = bd.Pessoas.First(x => x.Id == _pessoa.Id);
                pessoa.Situacao = situacao;
                pessoa.Nome = nome;
                pessoa.AnoNasc = anoNasc;
                //pessoa.TipoPessoa = tipoPessoa;
                pessoa.Genero = genero;
                pessoa.Cpf_cnpj = cpfCnpj;
                pessoa.Razaosoc = razaoSoc;
                pessoa.Cargo = cargo;
                pessoa.Senha = senha;
                pessoa.Cep = cep;
                pessoa.Pais = pais;
                pessoa.Estado = estado;
                pessoa.Cidade = cidade;
                pessoa.Bairro = bairro;
                pessoa.Endereco = endereco;
                pessoa.Numero = numero;
                pessoa.Complemento = complemento;
                pessoa.DDD = ddd;
                pessoa.Celular = celular;
                pessoa.Fone = fone;
                pessoa.Email = email;

                bd.Pessoas.Update(pessoa);
                bd.SaveChanges();

            }
            MessageBox.Show("Pessoa atualizada com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirPessoa()
        {
            using (var bd = new AplicacaoDBContext())
            {
                var nomePessoa = txtNome.Text;

                if (bd.Pessoas.Any(p => p.Nome == txtNome.Text && p.Cpf_cnpj == _pessoa.Cpf_cnpj))
                {
                    MessageBox.Show("Já existe uma pessoa com esse nome ou CPF/CNPJ.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                string nome = txtNome.Text;
                string situacao = cbbSituacao.Text;
                int anoNasc = int.Parse(txtAnoNasc.Text);
                string tipoPessoa = cbbTipoPessoa.Text;
                string genero = txtGenero.Text;
                string cpfCnpj = txtCpfCnpj.Text;
                string razaoSoc = txtRazaoSoc.Text;
                string cargo = txtCargo.Text;
                string senha = txtSenha.Text;
                int cep = int.Parse(txtCep.Text);
                string pais = txtPais.Text;
                string estado = txtEstado.Text;
                string cidade = txtCidade.Text;
                string bairro = txtBairro.Text;
                string endereco = txtEndereco.Text;
                int numero = int.Parse(txtNumero.Text);
                string complemento = txtComplemento.Text;
                int ddd = int.Parse(txtDDD.Text);
                int celular = int.Parse(txtCelular.Text);
                int fone = int.Parse(txtFone.Text);
                string email = txtEmail.Text;

                var criarPessoa = new Pessoa()
                {
                    Nome = nome,
                    Situacao = situacao,
                    AnoNasc = anoNasc,
                    TipoPessoa = "",
                    Genero = genero,
                    Cpf_cnpj = cpfCnpj,
                    Razaosoc = razaoSoc,
                    Cargo = cargo,
                    Senha = senha,
                    Cep = cep,
                    Pais = pais,
                    Estado = estado,
                    Cidade = cidade,
                    Bairro = bairro,
                    Endereco = endereco,
                    Numero = numero,
                    Complemento = complemento,
                    DDD = ddd,
                    Celular = celular,
                    Fone = fone,
                    Email = email
                };

                bd.Pessoas.Add(criarPessoa);
                bd.SaveChanges();

            }
            MessageBox.Show("Pessoa salva com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void PessoaCad_Load(object sender, EventArgs e)
        {
            CarregarCbbTipoPessoa();
        }

        private void CarregarCbbTipoPessoa()
        {
            var tipoPessoa = new List<TipoPessoa>();

            // ober o valores do enum TipoPessoa
            string[] tipoPessoas = System.Enum.GetNames(typeof(TipoPessoa));
            cbbTipoPessoa.Items.AddRange(tipoPessoas);
            
        }
    }
}
