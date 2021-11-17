using Login3A1BRUNO06.Code.BLL;
using Login3A1BRUNO06.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login3A1BRUNO06
{
    public partial class Form1 : Form
    {


        LoginBLL loginBBL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            if ( loginBBL.RealizarLogin( loginDTO) == true)
            {
                MessageBox.Show("Login foi um sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao Logar, verique email ou senha.");
            }
        }
    }
}
