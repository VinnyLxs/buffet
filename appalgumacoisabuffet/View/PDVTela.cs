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
    public partial class PDVTela : Form
    {
        int totalfinal = 0;
        public PDVTela()
        {
            InitializeComponent();
        }

        private void PDVTela_Load(object sender, EventArgs e)
        {

        }

        private void btn_pastel_Click(object sender, EventArgs e)
        {
            string registroPastel = "12";
            txb_codigo.Text = registroPastel;
        }

        private void btn_coxinha_Click(object sender, EventArgs e)
        {
            string registroCoxinha = "13";
            txb_codigo.Text += registroCoxinha; 
        }

        private void btn_esfiha_Click(object sender, EventArgs e)
        {
            string registroEsfiha = "14";
            txb_codigo.Text= registroEsfiha;
        }

        private void btn_bqueijo_Click(object sender, EventArgs e)
        {
            string registrobqueijo = "15";
            txb_codigo.Text = registrobqueijo;
        }

        private void btn_cafe_Click(object sender, EventArgs e)
        {
            string registroCafe = "16";
            txb_codigo.Text = registroCafe;
        }

        private void btn_refri_Click(object sender, EventArgs e)
        {
            string registroRefri = "17";
            txb_codigo.Text = registroRefri;
        }

        private void btn_suco_Click(object sender, EventArgs e)
        {
            string registrosSucos = "18";
            txb_codigo.Text = registrosSucos;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            lbl_valorTotal.Text = string.Empty;
            txb_codigo.Text = string.Empty;
            numericUpDown1.Value = 0;
            dataGridView1.Rows.Clear();
            totalfinal = 0;
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            fecharTela telaFechar = new fecharTela();
            telaFechar.Show();              
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txb_codigo.Text);
            int qtd = ((int)numericUpDown1.Value);


            string[] itens = { "Pastel", "Coxinha", "Esfiha", "Bolinho", "Sucos", "Refrigerante", "Cafe" };
            int[] valor = {8, 8, 8, 8, 12, 10, 15 };
            int total = qtd * valor[codigo - 12];
            totalfinal += total;
            dataGridView1.Rows.Add(itens[codigo - 12], qtd, valor[codigo -11], total);
            lbl_valorTotal.Text = "R$" + totalfinal.ToString() + ",00";
        }
    }
}
