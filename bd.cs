using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace wfDoutorAuauEMiau
{
    public class bd
    {
        protected string serv = "localhost";
        protected string usuario = "root";
        protected string senha = "";
        private string banco;
        public bd(string pbd)
        {
            banco = pbd;
        }
        private string monta_string()
        {
            return "Persist Security Info=False; server=" + this.serv + ";database=" + this.banco + ";uid=" + this.usuario + ";password=" + this.senha + ";convert zero datetime=True";
        }

        // Metodo de conexão
        public MySqlConnection conecta()
        {
            MySqlConnection con = new MySqlConnection(this.monta_string());
            con.Open();
            return con;

        }
        // Metodo para desconectar

        public void desconecta(MySqlConnection con)
        {
            con.Close();
        }
    }
}
