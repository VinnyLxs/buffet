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
    public partial class LoginTela : Form
    {
        
        public LoginTela()
        {
            InitializeComponent();
            
        }

        private void LoginTela_Load(object sender, EventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Acessar_Click(object sender, EventArgs e)
        {
            string usuario = txBox_Usuario.Text;
            string senha = txBox_senha.Text;

            if(usuario == "admin" && senha == "123") 
            {
                this.Visible = false;
                MenuTela Menu = new MenuTela();
                Menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha ou usuario Incorretos");
            }
        }
    }
}
