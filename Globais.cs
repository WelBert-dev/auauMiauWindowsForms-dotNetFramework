using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correios;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Data;
using MySql.Data.MySqlClient;

namespace wfDoutorAuauEMiau
{
    public class Globais
    {
        public static decimal versão = 1.0M;
        public static bool logado = true;
        public static int nivel = 0;
        public static MySqlDataReader lista;
        public static bool flagDataReader = false;
        public static string chamouProcurar = "nulo";
        public static int contadorDoDatagridProcurarNome = 0;
        public static int capturaDoDatagridviewProcurarNome = -2;

        public static void setDiaDeHoje_cb(System.Windows.Forms.ComboBox c)
        {
            for (int i = DateTime.Now.Day; i > 0; i--) //16, 15, 14, 13
            {
                if (i < 10)
                {
                    c.Items.Add("0" + i.ToString());
                }
                else
                {
                    c.Items.Add(i.ToString());
                }
            }
            c.SelectedItem = DateTime.Now.Day.ToString();
            c.Text = DateTime.Now.Day.ToString();
        }
        public static void setMesDeHoje_cb(System.Windows.Forms.ComboBox c)
        {
            for (int i = DateTime.Now.Month; i > 0; i--)
            {
                if (i < 10)
                {
                    c.Items.Add("0" + i.ToString());
                }
                else
                {
                    c.Items.Add(i.ToString());
                }
            }
            if(DateTime.Now.Month < 10)
            {
                c.SelectedItem = "0" + DateTime.Now.Month.ToString();
                c.Text = "0" + DateTime.Now.Month.ToString();
            }
            else
            {
                c.SelectedItem = DateTime.Now.Month.ToString();
                c.Text = DateTime.Now.Month.ToString();
            }
        }
        public static void setAnoDeHoje_cb(System.Windows.Forms.ComboBox c)
        {          
        }
        public static void setLogradouroCorreto_cb(System.Windows.Forms.ComboBox cE, System.Windows.Forms.ComboBox cL)
        { 
            if (cE.SelectedIndex != -1 || cE.SelectedItem != null) // aonde cE == combobox estado e cL comb.. Logradouro  // le arquivo txt e pega as cidades br 
            {
                string caminho;
                switch (cE.SelectedItem)
                {                  
                     case "Acre":
                        caminho = @".\acreLogradouros.txt";                     
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Alagoas":
                        caminho = @".\alagoasLogradouros.txt";                       
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Amapá":
                        caminho = @".\amapaLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Amazonas":
                        caminho = @".\amazonasLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Bahia":
                        List<string> logradouros = new List<string>();
                        StreamReader cu = new StreamReader(@".\bahiaLogradouros.txt");
                        int cont = 0;
                        while (!cu.EndOfStream)
                        {                                   
                            if (cont % 2 == 0)
                            {
                                logradouros.Add(cu.ReadLine());
                            }
                            else
                            {
                                cu.ReadLine();
                            }
                            cont ++;
                        }
                        cu.Close();
                        cL.Items.Clear();
                        cL.Items.AddRange(logradouros.ToArray());
                        break;
                    case "Ceará":
                        caminho = @".\cearaLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Distrito Federal":
                        cL.Items.Clear();
                        cL.Items.Add("Brasília");
                        break;
                    case "Espírito Santo":
                        caminho = @".\espiritoSantoLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Goiás":
                        caminho = @".\goiasLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Maranhão":
                        caminho = @".\maranhaoLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Mato Grosso":
                        caminho = @".\matoGrossoLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Mato Grosso do Sul":
                        caminho = @".\matoGrossoDoSulLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Minas Gerais":
                        caminho = @".\minasGeraisLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Pará":
                        caminho = @".\paraLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Paraíba":
                        caminho = @".\paraibaLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Paraná":
                        caminho = @".\paranaLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Pernambuco":
                        caminho = @".\pernambucoLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Piauí":
                        caminho = @".\piauiLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Rio de Janeiro":
                        caminho = @".\rioDeJaneiroLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Rio Grande do Norte":
                        caminho = @".\rioGrandeDoNorteLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Rio Grande do Sul":
                        caminho = @".\rioGrandeDoSulLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Rondônia":
                        caminho = @".\rondoniaLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Roraima":
                        caminho = @".\roraimaLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Santa Catarina":
                        caminho = @".\santaCatarinaLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "São Paulo":
                        caminho = @".\saoPauloLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Sergipe":
                        caminho = @".\sergipeLogradouros .txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                    case "Tocantins":
                        caminho = @".\tocantinsLogradouros.txt";
                        cL.Items.Clear();
                        cL.Items.AddRange(getListaDeArquivoTexto(caminho).ToArray());
                        break;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("É necessário selecionar um ESTADO primeiro!");
                return;
            }
        }
        public static List<string> getListaDeArquivoTexto(string caminho)
        {
            List<string> lista = new List<string>();
            StreamReader leitor;
            leitor = new StreamReader(@caminho);
            while (!leitor.EndOfStream)
            {
                lista.Add(leitor.ReadLine());
            }
            leitor.Close(); 
            return lista;
        }
        public static string getEstadoConvertido(string siglaEstado) // SP MG
        {
            switch (siglaEstado)
            {
                case "AC":
                    return "Acre";
                    break;
                case "AL":
                    return "Alagoas";
                    break;
                case "AP":
                    return "Amapá";
                    break;
                case "AM":
                    return "Amazonas";
                    break;
                case "BA":
                    return "Bahia";
                    break;
                case "CE":
                    return "Ceará";
                    break;
                case "DF":
                    return "Distrito Federal";
                    break;
                case "ES":
                    return "Espírito Santo";
                    break;
                case "GO":
                    return "Goiás";
                    break;
                case "MA":
                    return "Maranhão";
                    break;
                case "MT":
                    return "Mato Grosso";
                    break;
                case "MS":
                    return "Mato Grosso do Sul";
                    break;
                case "MG":
                    return "Minas Gerais";
                    break;
                case "PA":
                    return "Pará";
                    break;
                case "PB":
                    return "Paraíba";
                    break;
                case "PR":
                    return "Paraná";
                    break;
                case "PE":
                    return "Pernambuco";
                    break;
                case "PI":
                    return "Piauí";
                    break;
                case "RJ":
                    return "Rio de Janeiro";
                    break;
                case "RN":
                    return "Rio Grande do Norte";
                    break;
                case "RS":
                    return "Rio Grande do Sul";
                    break;
                case "RO":
                    return "Rondônia";
                    break;
                case "RR":
                   return "Roraima";
                    break;
                case "SC":
                    return "Santa Catarina";
                    break;
                case "SP": 
                    return "São Paulo";
                    break;
                case "SE":
                    return "Sergipe";
                    break;
                case "TO":
                    return "Tocantins";
                    break;
                default: 
                    return "nulo";
                    break;
            }
        }
        public static void formataEntrada_tb(System.Windows.Forms.TextBox t) // textbox simples
        {
            t.BackColor = Color.LightGreen;
        }
        public static void formataSaida_tb(System.Windows.Forms.TextBox t) // textbox simples
        {
            t.BackColor = Color.White;
        }
        public static void formataEntrada_mtbDt(System.Windows.Forms.MaskedTextBox dt) // maskedtextbox data
        {
            if (dt.Text == "INVÁLIDO" || dt.Text == "")
            {
                dt.BackColor = Color.LightGreen;
                dt.Text = "  /  /";
                dt.Mask = "00/00/0000";
                dt.Font = new Font(dt.Font.Name, dt.Font.Size, FontStyle.Regular);
                dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            }
        }
        public static void formataSaidaRed_mtbDt(System.Windows.Forms.MaskedTextBox dt)
        {
            dt.BackColor = Color.Red;
            dt.Mask = "";
            dt.Text = "INVÁLIDO";
            dt.Font = new Font(dt.Font.Name, dt.Font.Size, FontStyle.Bold | FontStyle.Underline);
            dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        }
        public static void formataSaida_mtbDt(System.Windows.Forms.MaskedTextBox dt) // maskedtexbox data
        {
            dt.BackColor = Color.White;
            if (dt.Text == "  /  /")
            {
                dt.Mask = "";
            }
            else
            {

                if (dt.Text.Length < 10) // break pq n foi digitado completo
                {
                    formataSaidaRed_mtbDt(dt);
                }
                else
                {
                    int cont = 0;
                    string dia = "";
                    string mes = "";
                    string ano = "";
                    foreach (char l in dt.Text) // "22/12/1999"
                    {
                        if (cont < 2)
                        {
                            if (l.ToString() == " " || String.IsNullOrEmpty(l.ToString()))
                            {
                                formataSaidaRed_mtbDt(dt);
                                break;
                            }
                            else
                            {
                                dia += l.ToString();
                            }
                        }
                        else if (cont < 5 && l != '/')
                        {
                            if (l.ToString() == " " || String.IsNullOrEmpty(l.ToString()))
                            {
                                formataSaidaRed_mtbDt(dt);
                                break;
                            }
                            else
                            {
                                mes += l.ToString();
                            }
                        }
                        else if (cont <= 9 && l != '/')
                        {
                            if (l.ToString() == " " || String.IsNullOrEmpty(l.ToString()))
                            {
                                formataSaidaRed_mtbDt(dt);
                                break;
                            }
                            else
                            {
                                ano += l.ToString();
                            }
                        }
                        cont++;
                    }
                    if (dia == "0" || dia == "00" || mes == "0" || mes == "00" || ano == "0" || ano == "00" || ano == "000" || ano == "0000" || int.Parse(mes) > 12 || int.Parse(mes) <= 0 || int.Parse(dia) > DateTime.DaysInMonth(int.Parse(ano), int.Parse(mes)))
                    {
                        formataSaidaRed_mtbDt(dt);
                    }
                }              
            }        
        }
        public static void formataEntrada_mtbTelCont(System.Windows.Forms.MaskedTextBox tel)
        {
            tel.BackColor = Color.LightGreen;
            tel.Mask = "(999) 00000-0000";
        }
        public static void formataSaida_mtbTelCont(System.Windows.Forms.MaskedTextBox tel)
        {
            tel.BackColor = Color.White;
            if (tel.Text == "(   )      -")
            {
                tel.Mask = "";
                tel.Text = "";
            }
        }
        public static void formataEntrada_cb(System.Windows.Forms.ComboBox c)
        {
            c.BackColor = Color.LightGreen;
        }
        public static void formataSaida_cb(System.Windows.Forms.ComboBox c)
        {
            c.BackColor = Color.White;
        }
    }
}
