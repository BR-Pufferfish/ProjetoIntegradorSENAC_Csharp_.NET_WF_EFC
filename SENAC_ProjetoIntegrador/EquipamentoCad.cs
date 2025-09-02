using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SENAC_ProjetoIntegrador.Entity;

namespace SENAC_ProjetoIntegrador
{
    public partial class EquipamentoCad : Form
    {
        private Equipamento _equipamento;
        public EquipamentoCad() 
        {
            InitializeComponent();
        }

        public EquipamentoCad(Equipamento equipamento)
        {
            _equipamento = equipamento;
            InitializeComponent();

            CarregaDadosEquipamento();
        }

        private void CarregaDadosEquipamento()
        {
            if (_equipamento != null)
            {
                txtNome.Text = _equipamento.Nome;
                txtModelo.Text = _equipamento.Modelo;
                txtAno.MaxLength = 4;
                txtCodigodeBarra.Text = _equipamento.CodBarra.ToString();
                txtNCM.Text = _equipamento.NCM.ToString();
                txtCusto.Text = _equipamento.Custo.ToString("F2");
                txtValor.Text = _equipamento.Valor.ToString("F2");
                txtEstoque.Text = _equipamento.Estoque.ToString("F2");

            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_equipamento == null)
            {
                InserirEquipamento();
            }
            else
            {
                AtualizarEquipamento();
            }
        }

        private void AtualizarEquipamento()
        {
            using (var bd = new AplicacaoDBContext())
            {
                if (bd.Equipamentos.Any(e => e.Nome == txtNome.Text && e.Id != _equipamento.Id))
                {
                    MessageBox.Show("Já existe um equipamento com esse nome.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                string nome = txtNome.Text;
                string modelo = txtModelo.Text;
                string situacao = cbbSituacao.Text;
                int ano = int.Parse(txtAno.Text);
                int codBarra = int.Parse(txtCodigodeBarra.Text);
                int ncm = int.Parse(txtNCM.Text);
                decimal custo = decimal.Parse(txtCusto.Text);
                decimal valor = decimal.Parse(txtValor.Text);
                int estoque = int.Parse(txtEstoque.Text);

                var equipamento = bd.Equipamentos.First(x => x.Id == _equipamento.Id);
                equipamento.Nome = nome;
                equipamento.Modelo = modelo;
                equipamento.Situacao = situacao;
                equipamento.Ano = ano;
                equipamento.CodBarra = codBarra;
                equipamento.NCM = ncm;
                equipamento.Custo = custo;
                equipamento.Valor = valor;
                equipamento.Estoque = estoque;

                bd.Equipamentos.Update(equipamento);
                bd.SaveChanges();
            }
            MessageBox.Show("Equipamento atualizado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }
        private void InserirEquipamento()
        {
            using (var bd = new AplicacaoDBContext())
            {
                var nomeEquip = txtNome.Text;

                if (bd.Equipamentos.Any(e => e.Nome == nomeEquip))
                {
                    MessageBox.Show("Já existe um equipamento com esse nome.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                string nome = txtNome.Text;
                string modelo = txtModelo.Text;
                string situacao = cbbSituacao.Text;
                int ano = int.Parse(txtAno.Text);
                int codBarra = int.Parse(txtCodigodeBarra.Text);
                int ncm = int.Parse(txtNCM.Text);
                decimal custo = decimal.Parse(txtCusto.Text);
                decimal valor = decimal.Parse(txtValor.Text);
                int estoque = int.Parse(txtEstoque.Text);

                var criarNovoEquipamento = new Equipamento()
                {
                    Nome = nome,
                    Modelo = modelo,
                    Situacao = situacao,
                    Ano = ano,
                    CodBarra = codBarra,
                    NCM = ncm,
                    Custo = custo,
                    Valor = valor,
                    Estoque = estoque
                };

                bd.Equipamentos.Add(criarNovoEquipamento);
                bd.SaveChanges();
            }
            MessageBox.Show("Equipamento salvo com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

    }
}
