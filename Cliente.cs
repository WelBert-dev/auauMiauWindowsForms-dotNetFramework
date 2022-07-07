using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;

namespace wfDoutorAuauEMiau
{
    public class Cliente
    {
        private string cpf; // cpf
        private string nome; // nome_completo
        private string dtNasc; // dt_nasc
        private char sexo; // sexo
        private string dtReg; // dt_reg
        private string telCont1; // tel_cont1
        private string telCont2; // tel_cont2
        private string email; // email
        private string pais; // pais
        private string estado; // estado
        private string logradouro; // logradouro
        private string bairro; // bairro
        private string endereco; // endereco 
        private int cep; // cep
        string infosComp; // infosComp
		
        public Cliente(string cc, string cn, string cdn, char cs, string cdr, string ctc1, string ctc2, string cemail, string cp, string cestado,string cl, string cbairro, string cendereco, int ccep, string infos)
        {
            this.cpf = cc;
            this.nome = cn;
            this.dtNasc = cdn;
            this.sexo = cs;
            this.dtReg = cdr;
            this.telCont1 = ctc1;
            this.telCont2 = ctc2;
            this.email = cemail;
            this.pais = cp;
            this.estado = cestado;
            this.logradouro = cl;
            this.bairro = cbairro;
            this.endereco = cendereco;
            this.cep = ccep;
            this.infosComp = infos;

        }
        public static MySqlDataReader getTodosUsuarios()
        {
            bd con = new bd("auaumiau");
            MySqlDataAdapter da = null;
            MySqlDataReader dr = null;
            try
            {
                string sql = "SELECT * FROM cliente";
                MySqlCommand cmd = new MySqlCommand(sql, con.conecta());
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.Text;
                dr = cmd.ExecuteReader();
                dr.Read();
                con.desconecta(con.conecta());
            }
            catch (Exception ex)
            {
                dr = null;
                System.Windows.Forms.MessageBox.Show("Erro ao retornar all ocorrencias Mysql!! Exeção: "+ex.Message);
            }
            return dr;
        }
        public static MySqlDataReader consulta(string sql)
        {
            bd con = new bd("auaumiau");
            MySqlDataReader dr = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, con.conecta());
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.Text;
                dr = cmd.ExecuteReader();
                dr.Read();
                con.desconecta(con.conecta());
            }
            catch (Exception ex)
            {
                dr = null;
                System.Windows.Forms.MessageBox.Show("Erro ao retornar all ocorrencias Mysql!! Exeção: " + ex.Message);
            }
            return dr;
        }
        public static DataTable consultaComRetornoDtTable(string sql)
        {
            bd con = new bd("auaumiau");
            var dt = new DataTable();
            var da = new MySqlDataAdapter();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, con.conecta());
                cmd.Parameters.Clear();
                cmd.CommandType = System.Data.CommandType.Text;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);                
                con.desconecta(con.conecta());

                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao retornar all ocorrencias Mysql!! Exeção: " + ex.Message);
                return null;
            }
       