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
        public EquipamentoCad()
        {
            InitializeComponent();
        }


        public EquipamentoCad(Equipamento equipamento)
        {
            InitializeComponent();

            CarredaDadosEquipamento(equipamento);
        }

        private void CarredaDadosEquipamento(Equipamento equipamento)
        {
            textBoxNome.Text = equipamento.Nome;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
