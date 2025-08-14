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
                txtLucro.Text = _equipamento.Lucro.ToString("F2");

            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_equipamento == null)
            {
                InserirEquipamentp();
            }
            else
            {
                AtualizarEquipamento();
            }
        }

        private void AtualizarEquipamento()
        {
            using (var banco = new AplicacaoDBContext())
            {
                string nome = txtNome.Text;
                string modelo = txtModelo.Text;
                int ano = int.Parse(txtAno.Text);
                int codBarra = int.Parse(txtCodigodeBarra.Text);
                int nmc = int.Parse(txtNCM.Text);
                decimal custo = decimal.Parse(txtCusto.Text);
                decimal valor = decimal.Parse(txtValor.Text);
                decimal lucro = decimal.Parse(txtLucro.Text);

            }
        }
        private void InserirEquipamentp()
        {
            throw new NotImplementedException();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
