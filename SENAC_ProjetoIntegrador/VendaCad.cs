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
    public partial class VendaCad : Form
    {
        private Venda _venda;
        public VendaCad()
        {
            InitializeComponent();
        }

        public VendaCad(VendaCad vendaSelecionada)
        {
            _venda = vendaSelecionada;
            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            if (_venda != null)
            {
                txtCliente.Text = _venda.Cliente;
                txtCpfCnpj.Text = _venda.CpfCnpj;

            }
        }
    }
}
