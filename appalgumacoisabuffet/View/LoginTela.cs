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
            //fechar aplicação
            Application.Exit();
        }

        private void Acessar_Click(object sender, EventArgs e)
        {
            // variavel do tipo texto que recebe da ferramenta textBox
            string usuario = txBox_Usuario.Text;
            string senha = txBox_senha.Text;

            // o algoritimo para verificar as credenciais e permitir o acesso
            if (usuario == "admin" && senha == "123")
            {
                this.Hide();
                MenuTela Menu = new MenuTela();
                Menu.FormClosed += (s, args) => this.Close();
                Menu.Show();
            }
            else
            {
                MessageBox.Show("Senha ou usuario Incorretos");
            }
        }
    }
}
