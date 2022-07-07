using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using Correios;

namespace wfDoutorAuauEMiau
{
    public partial class F_Cliente : Form
    {
        public F_Cliente()
        {
            InitializeComponent();

            Globais.setDiaDeHoje_cb(comboBox15);
            Globais.setMesDeHoje_cb(cb_mesReg);
            cb_anoReg.SelectedItem = "2022";
            cb_anoReg.Text = "2022";
            cb_pais.SelectedItem = cb_pais.Items[0];
            cb_pais.SelectedIndex = 0;
            cb_pais.Text = "Brasil";
        }
        private void button1_Click(object sender, EventArgs e) // Botão Registro
        {
            btn_registrar.Enabled = false;
            btn_atualizar.Enabled = true;
            btn_excluir.Enabled = true;

            if (tb_nome.Text != "" && mtb_cpf.Text != "" && mtb_dtNasc.Text != "INVÁLIDO" || mtb_dtNasc.Text != "  /  /")
            {
                mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string cpf = mtb_cpf.Text;
                string nome = tb_nome.Text.ToLower();       //0123456789
                string dtNasc = mtb_dtNasc.Text; // 22/12/1999
                int cont = 0;
                string diaNasc = "";
                string mesNasc = "";
                string anoNasc = "";
                foreach (var l in dtNasc)
                {
                    if (cont < 2)
                    {
                        diaNasc += l.ToString();
                    }
                    else if (cont < 5 && l != '/')
                    {
                        mesNasc += l.ToString();
                    }
                    else if (cont <= 9 && l != '/')
                    {
                        anoNasc += l.ToString();
                    }
                    cont ++;
                }
                dtNasc = "'"+anoNasc+"-"+mesNasc+"-"+diaNasc+"'";
                char sexo = 'F';
                if (rb_masculino.Checked) { sexo = 'M';}
                string dtReg = "'2022-"+cb_mesReg.SelectedItem+"-"+comboBox15.SelectedItem+"'";
                mtb_telCont1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telCont1 = mtb_telCont1.Text;
                mtb_telCont2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string telCont2 = mtb_telCont2.Text;
                string email = tb_email.Text;
                string pais = cb_pais.Text;
                string estado = cb_estado.Text;
                string logradouro = cb_logradouro.Text;
                string bairro = tb_bairro.Text;
                string endereco = tb_endereco.Text;
                mtb_cep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                int cep;
                if (mtb_cep.Text != "" || mtb_cep.Text != "INVÁLIDO!") { cep = Int32.Parse(mtb_cep.Text);}
                else{ cep = 0; }
                string infos = tb_infos.Text;

                Cliente cli = new Cliente(cpf, nome, dtNasc, sexo, dtReg, telCont1, telCont2, email, pais, estado, logradouro, bairro, endereco, cep, infos);
               
                if (cli.inCliente(this))
                {
                    MessageBox.Show("Cliente registrado com SUCESSO! ;D");
                    return;
                }
                else
                {
                    MessageBox.Show("Ocorreu um ERRO ao inserir!! ;-;");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Campo obrigatório não preenchido!");
                return;
            }
        }
        private void btn_limpar_Click(object sender, EventArgs e) // CLEAR + RESET BUTTONS
        {
            btn_limpar.Enabled = false;
            btn_registrar.Enabled = false;
            btn_atualizar.Enabled = false;
            btn_excluir.Enabled = false;

            tb_nome.Text = "";
            mtb_cpf.Text = "";
            mtb_cpf.Mask = "";
            mtb_dtNasc.Text = "";
            mtb_dtNasc.Mask = "";
            mtb_telCont1.Text = "";
            mtb_telCont1.Mask = "";
            mtb_telCont2.Text = "";
            mtb_telCont2.Mask = "";
            tb_email.Text = "";
            tb_infos.Text = "";
            cb_pais.Text = "";
            cb_pais.SelectedItem = null;
            cb_pais.SelectedIndex = -1;
            cb_estado.Text = "";
            cb_estado.SelectedItem = null;
            cb_estado.SelectedIndex = -1;
            cb_logradouro.Text = "";
            cb_logradouro.SelectedItem = null;
            cb_logradouro.SelectedIndex = -1;
            tb_bairro.Text = "";
            tb_endereco.Text = "";
            mtb_cep.Text = "";
            mtb_cep.Mask = "";
        }
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            btn_atualizar.Enabled = false;
            if (tb_nome.Text != "" && mtb_cpf.Text.Length == 11 && mtb_dtNasc.Text.Length == 10)
            {
                mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; 
                string sql = "SELECT cpf FROM cliente WHERE cpf ="+mtb_cpf.Text; // verifica se existe um registro para atualizar
                MySqlDataReader res;
                res = Cliente.consulta(sql);
                if (res.HasRows)
                {                                                                // se existir ele atualiza
                    string cpf = mtb_cpf.Text;
                    string nome = tb_nome.Text.ToLower();       
                    string dtNasc = mtb_dtNasc.Text;
                    int cont = 0;
                    string diaNasc = "";
                    string mesNasc = "";
                    string anoNasc = "";
                    foreach (var l in dtNasc)
                    {
                        if (cont < 2)
                        {
                            diaNasc += l.ToString();
                        }
                        else if (cont < 5 && l != '/')
                        {
                            mesNasc += l.ToString();
                        }
                        else if (cont <= 9 && l != '/')
                        {
                            anoNasc += l.ToString();
                        }
                        cont++;
                    }
                    dtNasc = "'" + anoNasc + "-" + mesNasc + "-" + diaNasc + "'";
                    char sexo = 'F';
                    if (rb_masculino.Checked) { sexo = 'M'; }
                    string dtReg = "'2022-" + cb_mesReg.SelectedItem + "-" + comboBox15.SelectedItem + "'";
                    mtb_telCont1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    string telCont1 = mtb_telCont1.Text;
                    mtb_telCont2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    string telCont2 = mtb_telCont2.Text;
                    string email = tb_email.Text;
                    string pais = cb_pais.Text;
                    string estado = cb_estado.Text;
                    string logradouro = cb_logradouro.Text;
                    string bairro = tb_bairro.Text;
                    string endereco = tb_endereco.Text;
                    mtb_cep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    int cep;
                    if (mtb_cep.Text != "INVÁLIDO!") { cep = Int32.Parse(mtb_cep.Text); }
                    else { cep = 0; }
                    string infos = tb_infos.Text;

                    Cliente cli = new Cliente(cpf, nome, dtNasc, sexo, dtReg, telCont1, telCont2, email, pais, estado, logradouro, bairro, endereco, cep, infos);

                    if (cli.atCliente(this))
                    {
                        MessageBox.Show("Cliente ATUALIZADO com SUCESSO! ;D");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um ERRO ao ATUALIZAR! ;-;");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!!");
                return;
            }
        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (mtb_cpf.Text.Length == 11) // 496.473.198-78 11 chars
            {
                string query = @"SELECT nome_completo, cpf FROM cliente WHERE cpf = @FLAG;";
                var resultQuery = Cliente.consultComWhere(query, mtb_cpf.Text);
                if (resultQuery.HasRows)
                {
                    string nome = "";
                    string cpf = "";         
                    int cont = 0;
                    while (resultQuery.Read())
                    {
                        if (cont == 0)
                        {
                            nome = resultQuery.GetString(0);
                            cpf = resultQuery.GetString(1);
                        }
                        cont ++;
                    }
                    DialogResult result = MessageBox.Show("Deseja [EXCLUIR] o registro :\nNome: " + nome + "\nCPF: " + cpf + "\nPrecione [OK] para continuar operação, ou [CANCEL]\n\n", "EXCLUIR Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (result.ToString().ToUpper() == "OK")
                    {
                        Cliente.exCliente(mtb_cpf.Text);
                    }
                }
                else
                {
                    btn_limpar.Enabled = false;
                    btn_registrar.Enabled = false;
                    btn_atualizar.Enabled = false;
                    btn_excluir.Enabled = false;
                    tb_nome.Text = "";
                    mtb_cpf.Text = "";
                    mtb_cpf.Mask = "";
                    mtb_dtNasc.Text = "";
                    mtb_dtNasc.Mask = "";
                    mtb_telCont1.Text = "";
                    mtb_telCont1.Mask = "";
                    mtb_telCont2.Text = "";
                    mtb_telCont2.Mask = "";
                    tb_email.Text = "";
                    tb_infos.Text = "";
                    cb_pais.Text = "";
                    cb_pais.SelectedItem = null;
                    cb_pais.SelectedIndex = -1;
                    cb_estado.Text = "";
                    cb_estado.SelectedItem = null;
                    cb_estado.SelectedIndex = -1;
                    cb_logradouro.Text = "";
                    cb_logradouro.SelectedItem = null;
                    cb_logradouro.SelectedIndex = -1;
                    tb_bairro.Text = "";
                    tb_endereco.Text = "";
                    mtb_cep.Text = "";
                    mtb_cep.Mask = "";
                }
            }
        }
        private void diaCorrespondente(ComboBox ano, ComboBox mes, ComboBox dia) // calcula e retorna quantos dias tem
        {                                                                        // no mex x (de acordo com ano e mes);
            if (ano.SelectedItem != null && mes.SelectedItem != null)            // exemplo: dezembro tem 30 dias
            {
                int m, a;
                m = Convert.ToInt32(mes.Items[mes.SelectedIndex]);
                a = Convert.ToInt32(ano.Items[ano.SelectedIndex]);
                int nDeDias = DateTime.DaysInMonth(a, m);
                for (int i = nDeDias; i > 0; i--)
                {
                    if (i < 10)
                    {
                        dia.Items.Add("0"+i.ToString());
                    }
                    else
                    {
                        dia.Items.Add(i.ToString());
                    }
                }
            }
            else
            {
                if (mes.SelectedItem != null)
                {
                    ano.Focus();
                    MessageBox.Show("É preciso selecionar um ano valido para poder selecionar o dia correspondente!");
                    return;
                }
                else
                {
                    mes.Focus();
                    MessageBox.Show("É preciso selecionar um mes válido para poder selecionar um dia correspondente!");
                    return;
                }
            }
        }
        private void comboBox15_Click(object sender, EventArgs e) // diaReg
        {
            // diaCorrespondente(cb_anoReg, cb_mesReg, comboBox15);
        }
        private void rb_masculino_CheckedChanged(object sender, EventArgs e) // garante que só uma das opções de sexo
        {
            if (rb_feminino.Checked)
            {
                rb_feminino.Checked = false;
                return;
            }
            else
            {
                if (rb_masculino.Checked)
                {
                    return;
                }
                else
                {
                    rb_masculino.Checked = true;
                }
            }
        }
        private void rb_feminino_CheckedChanged(object sender, EventArgs e) // garante que só uma das opções de sexo
        {
            if (rb_masculino.Checked)
            {
                rb_masculino.Checked = false;
                return;
            }
            else
            {
                if (rb_feminino.Checked)
                {
                    return;
                }
                else
                {
                    rb_feminino.Checked = true;
                }
            }
        }
        private void cb_logradouro_Click(object sender, EventArgs e)
        {
            Globais.setLogradouroCorreto_cb(this.cb_estado, this.cb_logradouro);
        }
        
        // AREA DOS EVENTOS ENTER E LEAVE
        private void atualizaEnabledDoRegEdoAtualiza()
        {
            if (tb_nome.Text == "" || mtb_cpf.Text.Length < 11 || mtb_dtNasc.Text.Length < 10)
            {
                btn_registrar.Enabled = false;
                btn_atualizar.Enabled = false;
            }
            else
            {
                btn_limpar.Enabled = true;

                mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string sql = "SELECT cpf FROM cliente WHERE cpf =" + mtb_cpf.Text; // verifica se existe um registro para atualizar
                MySqlDataReader res;
                res = Cliente.consulta(sql);
                if (res.HasRows)
                {
                    btn_atualizar.Enabled = true;
                    btn_registrar.Enabled = false;
                }
                else
                {
                    btn_atualizar.Enabled = false;
                    btn_registrar.Enabled = true;
                }
            }
        }
        private void mtb_cpf_Enter(object sender, EventArgs e) // entrada cpf
        {
            mtb_cpf.BackColor = Color.LightGreen;
            mtb_cpf.Mask = "000.000.000-00";
        }
        private void mtb_cpf_Leave(object sender, EventArgs e) // saida cpf
        {
            mtb_cpf.BackColor = Color.White;
            if (mtb_cpf.Text == "   ,   ,   -")
            {
                mtb_cpf.Mask = "";
                btn_excluir.Enabled = false;
                btn_registrar.Enabled = false;
                btn_atualizar.Enabled = false;
            }
            else if (mtb_cpf.Text.Length < 11)
            {
                btn_excluir.Enabled = false;
                btn_registrar.Enabled = false;
                btn_atualizar.Enabled = false;
                btn_limpar.Enabled = true;
            }
            else
            {
                btn_limpar.Enabled = true;

                mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string sql = "SELECT cpf FROM cliente WHERE cpf =" + mtb_cpf.Text; // verifica se existe um registro para atualizar
                MySqlDataReader res;
                res = Cliente.consulta(sql);

                if (tb_nome.Text == "" || mtb_dtNasc.Text.Length < 10)
                {
                    btn_registrar.Enabled = false;
                    btn_atualizar.Enabled = false;
                    if (res.HasRows)
                    {
                        btn_excluir.Enabled = true;
                    }
                    else
                    {
                        btn_excluir.Enabled = false;
                    }
                }
                else
                {
                    if (res.HasRows)
                    {
                        btn_atualizar.Enabled = true;
                        btn_registrar.Enabled = false;
                        btn_excluir.Enabled = true;
                    }
                    else
                    {
                        btn_atualizar.Enabled = false;
                        btn_registrar.Enabled = true;
                        btn_excluir.Enabled = false;
                    }
                }        
            }
        }
        private void tb_nome_Enter(object sender, EventArgs e)  // entrada nome
        {
            Globais.formataEntrada_tb(this.tb_nome);
        }
        private void tb_nome_Leave(object sender, EventArgs e)  // saida nome
        {
            // formata saida simples
            Globais.formataSaida_tb(this.tb_nome);
            if (tb_nome.Text.Length > 0)
            {
                btn_limpar.Enabled = true;
            }
            atualizaEnabledDoRegEdoAtualiza();
        }
        private void mtb_dtNasc_Enter(object sender, EventArgs e)  // entrada dataNasc
        {
            Globais.formataEntrada_mtbDt(this.mtb_dtNasc);
        }
        private void mtb_dtNasc_Leave(object sender, EventArgs e)  // saida dataNasc
        {
            Globais.formataSaida_mtbDt(this.mtb_dtNasc);
            atualizaEnabledDoRegEdoAtualiza();
        }
        private void mtb_telCont1_Enter(object sender, EventArgs e)
        {
            Globais.formataEntrada_mtbTelCont(this.mtb_telCont1);
        }
        private void mtb_telCont1_Leave(object sender, EventArgs e)
        {
            Globais.formataSaida_mtbTelCont(this.mtb_telCont1);
            if (mtb_telCont1.TextLength > 0)
            {
                btn_limpar.Enabled = true;
            }
            atualizaEnabledDoRegEdoAtualiza();
        }
        private void mtb_telCont2_Enter(object sender, EventArgs e)
        {
            Globais.formataEntrada_mtbTelCont(this.mtb_telCont2);
        }
        private void mtb_telCont2_Leave(object sender, EventArgs e)
        {
            Globais.formataSaida_mtbTelCont(this.mtb_telCont2);
            if (mtb_telCont2.Text.Length > 0)
            {
                btn_limpar.Enabled = true;
            }
            atualizaEnabledDoRegEdoAtualiza();
        }
        private void tb_email_Enter(object sender, EventArgs e)
        {
            Globais.formataEntrada_tb(this.tb_email);
        }
        private void tb_email_Leave(object sender, EventArgs e)
        {
            Globais.formataSaida_tb(this.tb_email);
            if (tb_email.Text.Length > 0)
            {
                btn_limpar.Enabled = true;
            }
            atualizaEnabledDoRegEdoAtualiza();
        }
        private void tb_infos_Enter(object sender, EventArgs e)
        {
            Globais.formataEntrada_tb(this.tb_infos);
        }
        private void tb_infos_Leave(object sender, EventArgs e)
        {
            Globais.formataSaida_tb(this.tb_infos);
            if (tb_infos.Text.Length > 0)
            {
                btn_limpar.Enabled = true;
            }
            atualizaEnabledDoRegEdoAtualiza();
        }
        private void cb_pais_Enter(object sender, EventArgs e)
        {
            Globais.formataEntrada_cb(this.cb_pais);
        }
        private void cb_pais_Leave(object sender, EventArgs e)
        {
            Globais.formataSaida_cb(this.cb_pais);
            if (cb_pais.Text.Length > 0)
            {
                btn_limpar.Enabled = true;
            }
            atualizaEnabledDoRegEdoAtualiza();
        }
        private void cb_estado_Enter(object sender, EventArgs e)
        {
            Globais.formataEntrada_cb(this.cb_estado);
        }
        private void cb_estado_Leave(object sender, EventArgs e)
        {
            Globais.formataSaida_cb(this.cb_estado);
            if (cb_estado.Text.Length > 0)
            {
                btn_limpar.Enabled = true;
            }
            atualizaEnabledDoRegEdoAtualiza();
        }
        private void cb_logradouro_Enter(object sender, EventArgs e)
        {
            Globais.formataEntrada_cb(this.cb_logradouro);
        }
        private void cb_logradouro_Leave(object sender, EventArgs e)
        {
            Globais.formataSaida_cb(this.cb_logradouro);
            if (cb_logradouro.Text.Length > 0)
            {
                btn_limpar.Enabled = true;
            }
            atualizaEnabledDoRegEdoAtualiza();
        }
        private void tb_bairro_Enter(object sender, EventArgs e)
        {
            Globais.formataEntrada_tb(this.tb_bairro);
        }
        private void tb_bairro_Leave(object sender, EventArgs e)
        {
            Globais.formataSaida_tb(this.tb_bairro);
            if (tb_bairro.Text.Length > 0)
            {
                btn_limpar.Enabled = true;
            }
            atualizaEnabledDoRegEdoAtualiza();
        }
        private void tb_endereco_Enter(object sender, EventArgs e)
        {
            Globais.formataEntrada_tb(this.tb_endereco);
        }
        private void tb_endereco_Leave(object sender, EventArgs e)
        {
            Globais.formataSaida_tb(this.tb_endereco);
            if (tb_endereco.Text.Length > 0)
            {
                btn_limpar.Enabled = true;
            }
            atualizaEnabledDoRegEdoAtualiza();
        }
        private void mtb_cep_Enter(object sender, EventArgs e)
        {
            mtb_cep.BackColor = Color.LightGreen;
            mtb_cep.Mask = "00000-000";
        }
        private void mtb_cep_Leave(object sender, EventArgs e)
        {
            mtb_cep.BackColor = Color.White;
            if (mtb_cep.Text == "     -") // se o usuário não digitou nada apenas sai e reset a mask
            {
                mtb_cep.Mask = "";
                return;
            }
            else if (mtb_cep.Text.Length < 9) // se o usuário não digitou tudo alerta é acionado e reset mask
            {
                btn_limpar.Enabled = true;
                mtb_cep.Mask = "";
                mtb_cep.Text = "INVÁLIDO!";
                mtb_cep.BackColor = Color.Red;
                return;
            }
            else if (mtb_cep.Text.Length == 9) // se o usuário digitou tudo ele continua as verificações
            {
                btn_limpar.Enabled = true;

                CorreiosApi correiosApi = new CorreiosApi();
                Correios.CorreiosServiceReference.enderecoERP retorno;
                bool flag = false;    // flag que indica se capturou alguma exception                  
                try
                {
                    retorno = correiosApi.consultaCEP(mtb_cep.Text);  // consulta o cep

                    string estadoConvertido = Globais.getEstadoConvertido(retorno.uf); // converto siglaEstado em nome completo, exemplo SP == São Paulo 

                    // se todos campos forem vazios apenas pega o retorno da consulta e formata componentes
                    if (cb_estado.Text == "" && cb_logradouro.Text == "" && tb_bairro.Text == "" && tb_endereco.Text == "")
                    {
                        cb_estado.Text = estadoConvertido;
                        cb_estado.SelectedItem = estadoConvertido;
                        cb_logradouro.Text = retorno.cidade;
                        cb_logradouro.SelectedItem = retorno.cidade;
                        tb_bairro.Text = retorno.bairro;
                        tb_endereco.Text = retorno.end;
                        return;
                    }
                    else
                    { 
                        // verificação se existe algum campo que não condiz com o correto 

                        if (cb_estado.Text != "") 
                        {
                            if (cb_estado.Text != estadoConvertido)
                            {
                                msgAlertCepNãoCondizComCampo(estadoConvertido, retorno);
                                return;
                            }
                        }
                        if (cb_logradouro.Text != "") 
                        {
                            if (cb_logradouro.Text != retorno.cidade)
                            {
                                msgAlertCepNãoCondizComCampo(estadoConvertido, retorno);
                                return;
                            }
                        }
                        if (tb_bairro.Text != "") 
                        {
                            if (tb_bairro.Text != retorno.bairro)
                            {
                                msgAlertCepNãoCondizComCampo(estadoConvertido, retorno);
                                return;
                            }
                        }
                        if (tb_endereco.Text != "") 
                        {
                            if (tb_endereco.Text != retorno.end)
                            {
                                msgAlertCepNãoCondizComCampo(estadoConvertido, retorno);
                                return;
                            }
                        }
                    }                   
                }
                catch (Exception ex)
                {
                    flag = true;
                }
                if (flag)
                {
                    mtb_cep.Mask = "";
                    mtb_cep.Text = "INVÁLIDO!";
                    mtb_cep.BackColor = Color.Red;
                    return;
                }                           
            }
        }
        private void msgAlertCepNãoCondizComCampo(string estadoConvertido, Correios.CorreiosServiceReference.enderecoERP retorno)
        {
            DialogResult confirma = MessageBox.Show("CEP não condiz com o valor do campo!\nEsse CEP corresponde á:\n\nEstado: " + estadoConvertido + "\nCidade: " + retorno.cidade + "\nBairro: " + retorno.bairro + "\nEndereço: " + retorno.end + "\n\n\nPrecione [SIM] para formatar campos de acordo com o CEP" + "\nOu Precione [NÂO] para corrigir o CEP", "Modificar Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            // verifica se a resposta é "YES" e faz as alterações dos campos errados
            if (confirma.ToString().ToUpper() == "YES")
            {

                cb_estado.Text = estadoConvertido; // São Paulo (corrigido)
                cb_logradouro.Text = retorno.cidade; // Salto
                tb_bairro.Text = retorno.bairro; // Jardim Celani
                tb_endereco.Text = retorno.end; // Rua Grécia

                // Correios.CorreiosServiceReference.enderecoERP <- retorno do correiosApi.consultaCEP()
            }
            else
            {
                mtb_cep.BackColor = Color.Red;
                mtb_cep.Focus();
            }
        }

        // AREA OF EVENTS SELECTED_INDEX_CHANGED AND MODIFY THE TEXBOX
        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_logradouro.SelectedIndex != -1 || cb_logradouro.SelectedItem != null)
            {
                cb_logradouro.Text = "";
                cb_logradouro.SelectedIndex = -1;
            }
            if (mtb_cep.Text.Length == 9)
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(mtb_cep.Text);
                    if (cb_estado.SelectedItem is null)
                    {
                        return;
                    }
                    else if (Globais.getEstadoConvertido(retorno.uf) != cb_estado.SelectedItem.ToString() && cb_estado.SelectedItem.ToString() != "")
                    {
                        msgAlertCepNãoCondizComCampo(Globais.getEstadoConvertido(retorno.uf), retorno);
                    }
                }
                catch
                {
                    mtb_cep.Text = "INVÁLIDO!";
                    mtb_cep.BackColor = Color.Red;
                }
            }
        }
        private void cb_logradouro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mtb_cep.Text.Length == 9)
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(mtb_cep.Text);
                    if (cb_logradouro.SelectedItem is null)
                    {
                        return;
                    }
                    else if (retorno.cidade != cb_logradouro.SelectedItem.ToString() && cb_logradouro.SelectedItem.ToString() != "")
                    {
                        msgAlertCepNãoCondizComCampo(Globais.getEstadoConvertido(retorno.uf), retorno);
                    }
                }
                catch
                {
                    mtb_cep.Text = "INVÁLIDO!";
                    mtb_cep.BackColor = Color.Red;
                }
            }
        }
        private void tb_bairro_TextChanged(object sender, EventArgs e)
        {
            if (mtb_cep.Text.Length == 9)
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    Correios.CorreiosServiceReference.enderecoERP retorno = correiosApi.consultaCEP(mtb_cep.Text);

                    if (retorno.bairro != tb_bairro.Text && tb_bairro.Text != "")
                    {
                        msgAlertCepNãoCondizComCampo(Globais.getEstadoConvertido(retorno.uf), retorno);
                    }
                }
                catch
                {
                    mtb_cep.Text = "INVÁLIDO!";
                    mtb_cep.BackColor = Color.Red;
                }
            }
        }
        private void tb_endereco_TextChanged(object sender, EventArgs e)
        {
            if (mtb_cep.Text.Length == 9)
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    Correios.CorreiosServiceReference.enderecoERP retorno = correiosApi.consultaCEP(mtb_cep.Text);
                    if (retorno.end != tb_endereco.Text && tb_endereco.Text != "")
                    {
                        msgAlertCepNãoCondizComCampo(Globais.getEstadoConvertido(retorno.uf), retorno);
                    }
                }
                catch
                {
                    mtb_cep.Text = "INVÁLIDO!";
                    mtb_cep.BackColor = Color.Red;
                }
            }
        }

        private void btn_procurarNome_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "")
                                       
            {
                Globais.chamouProcurar = "procurarNomeVazio";
                F_ProcurarNome f_ProcurarNome = new F_ProcurarNome(this);
                f_ProcurarNome.ShowDialog();
            }
            else
            {

            }
        }
    }
}
