using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto3Camadas.CODE.BLL;
using Projeto3Camadas.CODE.DTO;

namespace Projeto3Camadas.UI
{
    public partial class login : Form
    {
        loginbll loginbll = new loginbll();
        logindto logindto = new logindto();
        public login()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            //Capturar dados da tela
            logindto.Email = txtemail.Text;
            logindto.Senha = txtsenha.Text;


            //Chamada do método para verificar o acesso: 
            if (loginbll.RealizarLogin(logindto) == true)
            {

                Form1 frm_rede = new Form1();
                frm_rede.ShowDialog();
            }
            else
            {
                //Mensagem de sucesso
                MessageBox.Show("Verifique e-mail e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
