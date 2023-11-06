using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appalgumacoisabuffet.View
{
    public partial class fecharTela : Form
    {
        public fecharTela()
        {
            InitializeComponent();
        }

        private void fecharTela_Load(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToString();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
