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
        public PessoaCad()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
