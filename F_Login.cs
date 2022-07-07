using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace wfDoutorAuauEMiau
{
    public partial class F_Login : Form
    {
        F_home f_home;
        MySqlDataReader mysqlReader;
        public F_Login(F_home f)
        {
            InitializeComponent();
            f_home = f;
        }
        private void F_Login_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Para logar é necessário reiniciar o app!!");
            return;
        }
        private void logar()
        {
            string username = tb_login.Text;
            string senha = tb_senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuário e ou senha inválidos!");
                tb_login.Focus();
                return;
            }
            try
            {
                bd con = new bd("auaumiau");
                string sql = "SELECT * FROM usuario WHERE username ='" + username + "'AND senha ='" + senha + "'";
                
                
                var dt = new DataSet();
                var da = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand(sql, con.conecta());
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.Text;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                con.desconecta(con.conecta());

                MessageBox.Show(dt.Tables[0].Rows[2].Table.Rows[0].ToString());
                for (int i = 0; i < dt.Tables.Count; i++)
                {
                    if (i > 0) // se entrar é pq leu +d 1 ocorrências logo == bug
                    {

                    }
                    else

                    {
                        
                        foreach(var x in dt.Tables)
                        {
                            MessageBox.Show(x.ToString()); 
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao retornar all ocorrencias Mysql!! Exeção: " + ex.Message);

                if (ex.Message == "Referência de objeto não definida para uma instância de um objeto.")
                {
                    DialogResult result = System.Windows.Forms.MessageBox.Show(@"Verifique os campos e/ou Verifique se o MySQL está rodando!\nSe o MySQL estiver rodando selecione [SIM], se não selecione [NÂO]", "Error MySQL", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result.ToString().ToUpper() == "NO")
                    {
                        System.Diagnostics.Process.Start(@"C:\xampp\mysql\bin\mysql.exe", "-u root");
                    }
                    else
                    {
                        this.Refresh();
                    }
                    return;
                }
                else
                {
                    DialogResult result = System.Windows.Forms.MessageBox.Show("ERROR ao Fazer consulta!\nPrecione [SIM] para reiniciar o app, ou [NÂO] para fechar!", "ERROR Desconhecido!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result.ToString().ToUpper() == "YES")
                    {
                        this.Refresh();
                    }
                    else
                    {
                        this.Close();
                    }
                    return;
                }
            }
        }
        private void btn_logar_Click(object sender, EventArgs e)
        {
            logar();
        }
        private void F_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13) //13 é a tecla enter
            {
                logar();
            }
        }
    }
}
