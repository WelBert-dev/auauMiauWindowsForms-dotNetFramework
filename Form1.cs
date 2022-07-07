using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfDoutorAuauEMiau
{
    public partial class F_home : Form
    {
        public F_home()
        {
            InitializeComponent();
            this.Text += Globais.versão.ToString();
            //F_Login f_Login = new F_Login(this);
           // f_Login.ShowDialog();
        }
        private void btn_cliente_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                F_Cliente f_Cliente = new F_Cliente();
                f_Cliente.Show();
            }
            else
            {
                MessageBox.Show("Para prosseguir é necessário realizar login!! ;-;");
                return;
            }
        }
    }
}
