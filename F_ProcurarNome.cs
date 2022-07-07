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
    public partial class F_ProcurarNome : Form
    {
        F_Cliente formPai;
        string enterEvent;
        public F_ProcurarNome(F_Cliente f)
        {
            formPai = f;
            InitializeComponent();

            btn_buscar.Enabled = false;

            if (Globais.chamouProcurar == "procurarNomeVazio")
            {
                ProcurarNomeVazio();
            }
            else if (Globais.chamouProcurar == "procurarCPF")
            {

            }
            else
            {

            }
        }

        private void ProcurarNomeVazio()
        {
            string query = @"SELECT cpf as 'CPF', nome_completo as 'Nome', dt_nasc as 'Dt. Nasc.', 
                   CASE WHEN sexo = 'M' THEN 'Masculino' WHEN sexo = 'F' THEN 'Feminino' 
                   END as 'Sexo', 
                   dt_reg as 'Dt. Reg.', tel_cont1 as 'Tel. Cont.', tel_cont2 as 'Tel. Cont. 2', 
                   email as 'E-mail', pais as 'Pais', estado as 'Estado', logradouro as 'Logradouro', 
                   bairro as 'Bairro', endereco as 'Endereço', cep as 'Cep', infosComp as 'Infos Comp.' FROM cliente;";
            try
            {
                DataTable res = Cliente.consultaComRetornoDtTable(query);

                if (res.Rows.Count > 0)
                {
                    // dgv_Principal.Dock = DockStyle.Fill;
                    dgv_Principal.AutoGenerateColumns = true;
                    //bindingSource1.DataSource = res;
                    dgv_Principal.DataSource = res;
                    dgv_Principal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                    dgv_Principal.BorderStyle = BorderStyle.Fixed3D;

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(res.Rows.Count.ToString());

                }
            }
            catch (Exception ex)
            {

            }
        }
        private void btn_confirmar_Click(object sender, EventArgs e)
        {

        }
        private void cb_tipoDeFlag_Click(object sender, EventArgs e)
        {
            cb_tipoDeFlag.Items.Clear();

            for (int i = 0; i < dgv_Principal.RowCount; i++)     //dgv_Principal.Columns[i].Name <- obter nome das colunas
            {
                cb_tipoDeFlag.Items.Add(dgv_Principal.Columns[i].Name); //dgv_Principal.Rows[i].Cells[0].Value.ToString()
            }            
        }
        private void cb_tipoDeFlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_tipoDeFlag.BackColor = Color.White;
            mtb_valorBuscado.Mask = "";
            mtb_valorBuscado.Text = "";
            btn_buscar.Enabled = false;

            if (mtb_valorBuscado.ReadOnly)
            {
                mtb_valorBuscado.ReadOnly = false;
            }
            if (cb_tipoDeFlag.SelectedIndex != -1)
            {
                lb_infoTipo.Font = new Font(lb_infoTipo.Font.Name, lb_infoTipo.Font.Size, FontStyle.Bold | FontStyle.Underline);
                lb_infoTipo.ForeColor = Color.Red;
                mtb_valorBuscado.Font = new Font(mtb_valorBuscado.Font.Name, mtb_valorBuscado.Font.Size, FontStyle.Bold);

                if (cb_tipoDeFlag.SelectedItem.ToString() == "Nome" || cb_tipoDeFlag.SelectedItem.ToString() == "E-mail" || cb_tipoDeFlag.SelectedItem.ToString() == "Pais" || cb_tipoDeFlag.SelectedItem.ToString() == "Estado" || cb_tipoDeFlag.SelectedItem.ToString() == "Logradouro" || cb_tipoDeFlag.SelectedItem.ToString() == "Bairro" || cb_tipoDeFlag.SelectedItem.ToString() == "Endereço" || cb_tipoDeFlag.SelectedItem.ToString() == "Infos Comp.")
                {
                    mtb_valorBuscado.Size = new Size(330, 20); // normal: 330; 20

                    lb_infoTipo.Text = "* Digite um " + cb_tipoDeFlag.SelectedItem.ToString().ToLower() + ", [NÂO] precisa ser completo! após clica em [BUSCAR] ;D";
                    lb_infoTipo.Visible = true;
                }
                else if (cb_tipoDeFlag.SelectedItem.ToString() == "CPF")
                {
                    mtb_valorBuscado.Size = new Size(99, 20); 

                    lb_infoTipo.Text = "* Digite um CPF, [NÃO] precisa ser completo! após clica em [BUSCAR] ;D";
                    lb_infoTipo.Visible = true;
                }
                else if (cb_tipoDeFlag.SelectedItem.ToString() == "Dt. Nasc." || cb_tipoDeFlag.SelectedItem.ToString() == "Dt. Reg.")
                {
                    mtb_valorBuscado.Size = new Size(79, 20); 

                    lb_infoTipo.Text = "* Digite uma data de nascimento, [NÃO] precisa ser completo! após clica em [BUSCAR] ;D";
                    lb_infoTipo.Visible = true;
                }
                else if (cb_tipoDeFlag.SelectedItem.ToString() == "Sexo")
                {
                    mtb_valorBuscado.Size = new Size(33, 20); 

                    lb_infoTipo.Text = "* Digite [F] para \"Feminino\" ou [M] para \"Masculino\", após clica em [BUSCAR] ;D";
                    lb_infoTipo.Visible = true;
                }
                else if (cb_tipoDeFlag.SelectedItem.ToString() == "Tel. Cont." || cb_tipoDeFlag.SelectedItem.ToString() == "Tel. Cont. 2")
                {
                    mtb_valorBuscado.Size = new Size(105, 20); 

                    lb_infoTipo.Text = "* Digite um número de telefone, não precisa ser completo! após clica em [BUSCAR] ;D";
                    lb_infoTipo.Visible = true;
                }
                else if (cb_tipoDeFlag.SelectedItem.ToString() == "Cep")
                {

                    lb_infoTipo.Text = "* Digite um número de CEP, não precisa ser completo! após clica em [BUSCAR] ;D";
                    lb_infoTipo.Visible = true;
                }
            }
        }
        private void mtb_valorBuscado_Enter(object sender, EventArgs e)
        {
            if (cb_tipoDeFlag.SelectedIndex == -1)
            {
                lb_infoTipo.Font = new Font(lb_infoTipo.Font.Name, lb_infoTipo.Font.Size, FontStyle.Bold | FontStyle.Underline);
                lb_infoTipo.ForeColor = Color.Red;
                lb_infoTipo.Text = "É Necessário selecionar um \"Tipo\" primeiro!!";
                lb_infoTipo.Visible = true;
 
                mtb_valorBuscado.BackColor = Color.Red;
                mtb_valorBuscado.Text = "<---------------------------------------------------------------------";
                mtb_valorBuscado.Font = new Font(mtb_valorBuscado.Font.Name, mtb_valorBuscado.Font.Size, FontStyle.Bold);

                cb_tipoDeFlag.BackColor = Color.LightGreen;
                return;
            }
            else if (cb_tipoDeFlag.SelectedItem.ToString() == "CPF")
            {

                if (mtb_valorBuscado.Text == "<---------------------------------------------------------------------")
                {
                    mtb_valorBuscado.Text = "";
                }

                mtb_valorBuscado.BackColor = Color.LightGreen;
                mtb_valorBuscado.Mask = "000.000.000-00";
                enterEvent = "cpf";
            }
            else if (cb_tipoDeFlag.SelectedItem.ToString() == "Nome" || cb_tipoDeFlag.SelectedItem.ToString() == "E-mail" || cb_tipoDeFlag.SelectedItem.ToString() == "Pais" || cb_tipoDeFlag.SelectedItem.ToString() == "Estado" || cb_tipoDeFlag.SelectedItem.ToString() == "Logradouro" || cb_tipoDeFlag.SelectedItem.ToString() == "Bairro" || cb_tipoDeFlag.SelectedItem.ToString() == "Endereço" || cb_tipoDeFlag.SelectedItem.ToString() == "Infos Comp.")
            {
                if (mtb_valorBuscado.Text == "<---------------------------------------------------------------------")
                {
                    mtb_valorBuscado.Text = "";
                }
                mtb_valorBuscado.BackColor = Color.LightGreen;
                mtb_valorBuscado.Mask = "";
                enterEvent = "varios";
            }
            else if (cb_tipoDeFlag.SelectedItem.ToString() == "Dt. Nasc." || cb_tipoDeFlag.SelectedItem.ToString() == "Dt. Reg.")
            {
                if (mtb_valorBuscado.Text == "<---------------------------------------------------------------------")
                {
                    mtb_valorBuscado.Text = "";
                }
                Globais.formataEntrada_mtbDt(mtb_valorBuscado);
                enterEvent = "dt";
            }
            else if (cb_tipoDeFlag.SelectedItem.ToString() == "Sexo")
            {
                if (mtb_valorBuscado.Text == "<---------------------------------------------------------------------")
                {
                    mtb_valorBuscado.Text = "";
                }
                mtb_valorBuscado.BackColor = Color.LightGreen;
                mtb_valorBuscado.Mask = "[L]";
                enterEvent = "sexo";
            }
            else if (cb_tipoDeFlag.SelectedItem.ToString() == "Tel. Cont." || cb_tipoDeFlag.SelectedItem.ToString() == "Tel. Cont. 2")
            {
                if (mtb_valorBuscado.Text == "<---------------------------------------------------------------------")
                {
                    mtb_valorBuscado.Text = "";
                }
                mtb_valorBuscado.BackColor = Color.LightGreen;
                Globais.formataEntrada_mtbTelCont(mtb_valorBuscado);
                enterEvent = "tel";
            }
            else if (cb_tipoDeFlag.SelectedItem.ToString() == "Cep")
            {
                if (mtb_valorBuscado.Text == "<---------------------------------------------------------------------")
                {
                    mtb_valorBuscado.Text = "";
                }
                mtb_valorBuscado.BackColor = Color.LightGreen;
                mtb_valorBuscado.Mask = "00000-000";
                enterEvent = "cep";
            }
        } 
        private void mtb_valorBuscado_Leave(object sender, EventArgs e)
        {
            mtb_valorBuscado.Mask = "";
            if (mtb_valorBuscado.Text == "" || cb_tipoDeFlag.SelectedItem == null)
            {
                btn_buscar.Enabled = false;
                mtb_valorBuscado.BackColor = Color.White;
                return;
            }
            else
            {
                switch (enterEvent)
                {
                    case "cpf":

                        mtb_valorBuscado.Mask = "000.000.000-00";
                        btn_buscar.Enabled = true;
                        mtb_valorBuscado.BackColor = Color.White;
                        
                        break;
                    case "varios":

                        btn_buscar.Enabled = true; // talvez melhorar no futuro
                        mtb_valorBuscado.BackColor = Color.White;

                        break;
                    case "dt":

                        string d = "";
                        string m = "";
                        string a = "";

                        for (int i = 0; i < mtb_valorBuscado.TextLength; i++) // - pega dia, mes e ano
                        {
                            if (i < 2)
                            {
                                d += i.ToString();
                            }
                            else if (i < 4)
                            {
                                m += i.ToString();
                            }
                            else
                            {
                                a += i.ToString();
                            }
                        }
                        if (mtb_valorBuscado.TextLength ==  8) // - se a data esta completa == 8
                        {                                                                // - verifica se a data é válida
                            if (int.Parse(m) > 12 || int.Parse(m) <= 0 || int.Parse(d) > DateTime.DaysInMonth(int.Parse(a), int.Parse(m)) || int.Parse(d) <= 0 || int.Parse(a) > DateTime.Now.Year)
                            {
                                Globais.formataSaidaRed_mtbDt(mtb_valorBuscado);
                                btn_buscar.Enabled = false;
                                return;
                            }
                        }
                        else
                        {                              // - verifica qual é completo (dia, mes, ano)
                            if (d.Length == 2)         // - ai verifica se é válido ? null : btn_buscar == false
                            {
                                if (int.Parse(d) > 32 || int.Parse(d) <= 0)
                                {
                                    Globais.formataSaidaRed_mtbDt(mtb_valorBuscado);
                                    btn_buscar.Enabled = false;
                                    return;
                                }
                            }
                            if (m.Length == 2)
                            {
                                if (int.Parse(m) > 12 || int.Parse(m) <= 0)
                                {
                                    Globais.formataSaidaRed_mtbDt(mtb_valorBuscado);
                                    return;
                                }
                            }
                            if (a.Length == 4)
                            {
                                if (int.Parse(a) > DateTime.Now.Year || int.Parse(a) <= 0)
                                {
                                    Globais.formataSaidaRed_mtbDt(mtb_valorBuscado);
                                    return;
                                }
                            }

                            btn_buscar.Enabled = true;
                            mtb_valorBuscado.BackColor = Color.White;
                            mtb_valorBuscado.Mask = "00/00/0000";
                        }
                        break;
                    case "sexo":

                        if (mtb_valorBuscado.Text.ToUpper() != "F" && mtb_valorBuscado.Text.ToUpper() != "M")
                        {
                            mtb_valorBuscado.BackColor = Color.Red;
                            mtb_valorBuscado.Text = "ENTRAR COM F (FEMININO) OU M (MASCULINO)!";
                            mtb_valorBuscado.Font = new Font(mtb_valorBuscado.Font.Name, mtb_valorBuscado.Font.Size, FontStyle.Bold | FontStyle.Underline);
                            mtb_valorBuscado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                            btn_buscar.Enabled = false;
                        }
                        else
                        {
                            mtb_valorBuscado.BackColor = Color.White;
                            btn_buscar.Enabled = true;
                        }
                        break;
                    case "tel":
                        mtb_valorBuscado.Mask = "(999) 00000-0000";
                        mtb_valorBuscado.BackColor = Color.White;
                        btn_buscar.Enabled = true;
                        break;
                    case "cep":
                        mtb_valorBuscado.Mask = "00000-000";
                        mtb_valorBuscado.BackColor = Color.White;
                        break;
                }
            }
        }
        private void tb_valorBuscado_Enter(object sender, EventArgs e)
        {

        }
        private void tb_valorBuscado_Leave(object sender, EventArgs e)
        {

        }
        private void dgv_Principal_SelectionChanged(object sender, EventArgs e) 
        {
            // - Verifica se existe alguma célula selecionada, e atualiza btn_confirmar

            if (dgv_Principal.SelectedCells.Count == 15)
            {
                btn_confirmar.Enabled = true;
            }
            else
            {
                btn_confirmar.Enabled = false;
            }

            // - muda a formatação da linha corrente e re-formata para default a linha selecionada anteriormente
            // - utilizando contador pois o evento é disparado 3 vezes antes de abrir form
            // - variaveis no global pois aqui dentro ele fica resetando!

            if (dgv_Principal.CurrentCell != null)
            {
                btn_buscar.Enabled = true;

      
                if (Globais.contadorDoDatagridProcurarNome == 3) // - primeira interação 
                {
                    Globais.capturaDoDatagridviewProcurarNome = dgv_Principal.CurrentRow.Index;
                    dgv_Principal.CurrentRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold);

                }
                else if (Globais.capturaDoDatagridviewProcurarNome != dgv_Principal.CurrentRow.Index && Globais.contadorDoDatagridProcurarNome > 3)
                {
                    dgv_Principal.Rows[Globais.capturaDoDatagridviewProcurarNome].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular);
                    dgv_Principal.Rows[Globais.capturaDoDatagridviewProcurarNome].DefaultCellStyle.ForeColor = Color.Black;
                    dgv_Principal.CurrentRow.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold);
                    Globais.capturaDoDatagridviewProcurarNome = dgv_Principal.CurrentRow.Index;
                }
                Globais.contadorDoDatagridProcurarNome ++;
            }
        }

        private void dgv_Principal_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_Principal.SelectedCells[0].Selected = false;
        }
    }
}
