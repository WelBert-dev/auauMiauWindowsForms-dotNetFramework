namespace wfDoutorAuauEMiau
{
    partial class F_Cliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Cliente));
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lbDataNasci = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.cb_pais = new System.Windows.Forms.ComboBox();
            this.cb_logradouro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pb_perfil = new System.Windows.Forms.PictureBox();
            this.btn_procurarNome = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_infos = new System.Windows.Forms.TextBox();
            this.gb_sexo = new System.Windows.Forms.GroupBox();
            this.rb_feminino = new System.Windows.Forms.RadioButton();
            this.rb_masculino = new System.Windows.Forms.RadioButton();
            this.gb_dataReg = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_anoReg = new System.Windows.Forms.ComboBox();
            this.cb_mesReg = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.btn_procurarCpf = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.mtb_cep = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_dataNasc = new System.Windows.Forms.GroupBox();
            this.mtb_dtNasc = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mtb_telCont1 = new System.Windows.Forms.MaskedTextBox();
            this.mtb_telCont2 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_perfil)).BeginInit();
            this.gb_sexo.SuspendLayout();
            this.gb_dataReg.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gb_dataNasc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(162, 100);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(211, 20);
            this.tb_nome.TabIndex = 0;
            this.tb_nome.Enter += new System.EventHandler(this.tb_nome_Enter);
            this.tb_nome.Leave += new System.EventHandler(this.tb_nome_Leave);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(169, 84);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(95, 13);
            this.lb_nome.TabIndex = 2;
            this.lb_nome.Text = "Nome Completo";
            // 
            // lbDataNasci
            // 
            this.lbDataNasci.AutoSize = true;
            this.lbDataNasci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNasci.Location = new System.Drawing.Point(169, 124);
            this.lbDataNasci.Name = "lbDataNasci";
            this.lbDataNasci.Size = new System.Drawing.Size(30, 13);
            this.lbDataNasci.TabIndex = 3;
            this.lbDataNasci.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "País";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-Mail";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(165, 280);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(206, 20);
            this.tb_email.TabIndex = 4;
            this.tb_email.Enter += new System.EventHandler(this.tb_email_Enter);
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // cb_pais
            // 
            this.cb_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pais.FormattingEnabled = true;
            this.cb_pais.Items.AddRange(new object[] {
            "Brasil"});
            this.cb_pais.Location = new System.Drawing.Point(9, 29);
            this.cb_pais.Name = "cb_pais";
            this.cb_pais.Size = new System.Drawing.Size(121, 21);
            this.cb_pais.TabIndex = 15;
            this.cb_pais.Enter += new System.EventHandler(this.cb_pais_Enter);
            this.cb_pais.Leave += new System.EventHandler(this.cb_pais_Leave);
            // 
            // cb_logradouro
            // 
            this.cb_logradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_logradouro.FormattingEnabled = true;
            this.cb_logradouro.Location = new System.Drawing.Point(9, 100);
            this.cb_logradouro.Name = "cb_logradouro";
            this.cb_logradouro.Size = new System.Drawing.Size(121, 21);
            this.cb_logradouro.TabIndex = 17;
            this.cb_logradouro.SelectedIndexChanged += new System.EventHandler(this.cb_logradouro_SelectedIndexChanged);
            this.cb_logradouro.Click += new System.EventHandler(this.cb_logradouro_Click);
            this.cb_logradouro.Enter += new System.EventHandler(this.cb_logradouro_Enter);
            this.cb_logradouro.Leave += new System.EventHandler(this.cb_logradouro_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Logradouro/Cidade";
            // 
            // cb_estado
            // 
            this.cb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cb_estado.Location = new System.Drawing.Point(9, 64);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(121, 21);
            this.cb_estado.TabIndex = 19;
            this.cb_estado.SelectedIndexChanged += new System.EventHandler(this.cb_estado_SelectedIndexChanged);
            this.cb_estado.Enter += new System.EventHandler(this.cb_estado_Enter);
            this.cb_estado.Leave += new System.EventHandler(this.cb_estado_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Endereço";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(9, 171);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(187, 20);
            this.tb_endereco.TabIndex = 20;
            this.tb_endereco.TextChanged += new System.EventHandler(this.tb_endereco_TextChanged);
            this.tb_endereco.Enter += new System.EventHandler(this.tb_endereco_Enter);
            this.tb_endereco.Leave += new System.EventHandler(this.tb_endereco_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "CEP";
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Navy;
            this.btn_registrar.Enabled = false;
            this.btn_registrar.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_registrar.Location = new System.Drawing.Point(72, 362);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(106, 29);
            this.btn_registrar.TabIndex = 24;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Navy;
            this.btn_limpar.Enabled = false;
            this.btn_limpar.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_limpar.Location = new System.Drawing.Point(184, 362);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(106, 29);
            this.btn_limpar.TabIndex = 25;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.Navy;
            this.btn_atualizar.Enabled = false;
            this.btn_atualizar.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_atualizar.Location = new System.Drawing.Point(305, 362);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(106, 29);
            this.btn_atualizar.TabIndex = 26;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Navy;
            this.btn_excluir.Enabled = false;
            this.btn_excluir.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_excluir.Location = new System.Drawing.Point(422, 362);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(106, 29);
            this.btn_excluir.TabIndex = 27;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ink Free", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(157, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(267, 30);
            this.label11.TabIndex = 28;
            this.label11.Text = "Informações do Cliente";
            // 
            // pb_perfil
            // 
            this.pb_perfil.Image = ((System.Drawing.Image)(resources.GetObject("pb_perfil.Image")));
            this.pb_perfil.Location = new System.Drawing.Point(9, 84);
            this.pb_perfil.Name = "pb_perfil";
            this.pb_perfil.Size = new System.Drawing.Size(141, 129);
            this.pb_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_perfil.TabIndex = 36;
            this.pb_perfil.TabStop = false;
            // 
            // btn_procurarNome
            // 
            this.btn_procurarNome.BackColor = System.Drawing.Color.Navy;
            this.btn_procurarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurarNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_procurarNome.Location = new System.Drawing.Point(367, 99);
            this.btn_procurarNome.Name = "btn_procurarNome";
            this.btn_procurarNome.Size = new System.Drawing.Size(57, 22);
            this.btn_procurarNome.TabIndex = 37;
            this.btn_procurarNome.Text = "Procurar";
            this.btn_procurarNome.UseVisualStyleBackColor = false;
            this.btn_procurarNome.Click += new System.EventHandler(this.btn_procurarNome_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(270, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Informações Complementares *150 CHAR MAX";
            // 
            // tb_infos
            // 
            this.tb_infos.Location = new System.Drawing.Point(12, 322);
            this.tb_infos.Name = "tb_infos";
            this.tb_infos.Size = new System.Drawing.Size(615, 20);
            this.tb_infos.TabIndex = 38;
            this.tb_infos.Enter += new System.EventHandler(this.tb_infos_Enter);
            this.tb_infos.Leave += new System.EventHandler(this.tb_infos_Leave);
            // 
            // gb_sexo
            // 
            this.gb_sexo.Controls.Add(this.rb_feminino);
            this.gb_sexo.Controls.Add(this.rb_masculino);
            this.gb_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_sexo.Location = new System.Drawing.Point(312, 162);
            this.gb_sexo.Name = "gb_sexo";
            this.gb_sexo.Size = new System.Drawing.Size(99, 54);
            this.gb_sexo.TabIndex = 40;
            this.gb_sexo.TabStop = false;
            this.gb_sexo.Text = "Sexo";
            // 
            // rb_feminino
            // 
            this.rb_feminino.AutoSize = true;
            this.rb_feminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_feminino.Location = new System.Drawing.Point(6, 32);
            this.rb_feminino.Name = "rb_feminino";
            this.rb_feminino.Size = new System.Drawing.Size(67, 17);
            this.rb_feminino.TabIndex = 54;
            this.rb_feminino.Text = "Feminino";
            this.rb_feminino.UseVisualStyleBackColor = true;
            this.rb_feminino.CheckedChanged += new System.EventHandler(this.rb_feminino_CheckedChanged);
            // 
            // rb_masculino
            // 
            this.rb_masculino.AutoSize = true;
            this.rb_masculino.Checked = true;
            this.rb_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_masculino.Location = new System.Drawing.Point(6, 12);
            this.rb_masculino.Name = "rb_masculino";
            this.rb_masculino.Size = new System.Drawing.Size(73, 17);
            this.rb_masculino.TabIndex = 53;
            this.rb_masculino.TabStop = true;
            this.rb_masculino.Text = "Masculino";
            this.rb_masculino.UseVisualStyleBackColor = true;
            this.rb_masculino.CheckedChanged += new System.EventHandler(this.rb_masculino_CheckedChanged);
            // 
            // gb_dataReg
            // 
            this.gb_dataReg.Controls.Add(this.label12);
            this.gb_dataReg.Controls.Add(this.label6);
            this.gb_dataReg.Controls.Add(this.label5);
            this.gb_dataReg.Controls.Add(this.cb_anoReg);
            this.gb_dataReg.Controls.Add(this.cb_mesReg);
            this.gb_dataReg.Controls.Add(this.comboBox15);
            this.gb_dataReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_dataReg.Location = new System.Drawing.Point(9, 221);
            this.gb_dataReg.Name = "gb_dataReg";
            this.gb_dataReg.Size = new System.Drawing.Size(141, 58);
            this.gb_dataReg.TabIndex = 42;
            this.gb_dataReg.TabStop = false;
            this.gb_dataReg.Text = "Data de Registro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(94, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Ano";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mês";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dia";
            // 
            // cb_anoReg
            // 
            this.cb_anoReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_anoReg.FormattingEnabled = true;
            this.cb_anoReg.Location = new System.Drawing.Point(87, 31);
            this.cb_anoReg.Name = "cb_anoReg";
            this.cb_anoReg.Size = new System.Drawing.Size(49, 21);
            this.cb_anoReg.TabIndex = 2;
            // 
            // cb_mesReg
            // 
            this.cb_mesReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mesReg.FormattingEnabled = true;
            this.cb_mesReg.Location = new System.Drawing.Point(48, 31);
            this.cb_mesReg.Name = "cb_mesReg";
            this.cb_mesReg.Size = new System.Drawing.Size(36, 21);
            this.cb_mesReg.TabIndex = 1;
            // 
            // comboBox15
            // 
            this.comboBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(3, 31);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(41, 21);
            this.comboBox15.TabIndex = 0;
            // 
            // btn_procurarCpf
            // 
            this.btn_procurarCpf.BackColor = System.Drawing.Color.Navy;
            this.btn_procurarCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurarCpf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_procurarCpf.Location = new System.Drawing.Point(305, 137);
            this.btn_procurarCpf.Name = "btn_procurarCpf";
            this.btn_procurarCpf.Size = new System.Drawing.Size(57, 22);
            this.btn_procurarCpf.TabIndex = 43;
            this.btn_procurarCpf.Text = "Procurar";
            this.btn_procurarCpf.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_bairro);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.mtb_cep);
            this.groupBox4.Controls.Add(this.cb_pais);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cb_logradouro);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cb_estado);
            this.groupBox4.Controls.Add(this.tb_endereco);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(437, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 232);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Moradia";
            // 
            // tb_bairro
            // 
            this.tb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bairro.Location = new System.Drawing.Point(11, 138);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(185, 20);
            this.tb_bairro.TabIndex = 27;
            this.tb_bairro.TextChanged += new System.EventHandler(this.tb_bairro_TextChanged);
            this.tb_bairro.Enter += new System.EventHandler(this.tb_bairro_Enter);
            this.tb_bairro.Leave += new System.EventHandler(this.tb_bairro_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 122);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Bairro";
            // 
            // mtb_cep
            // 
            this.mtb_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cep.Location = new System.Drawing.Point(9, 206);
            this.mtb_cep.Name = "mtb_cep";
            this.mtb_cep.Size = new System.Drawing.Size(121, 20);
            this.mtb_cep.TabIndex = 24;
            this.mtb_cep.Enter += new System.EventHandler(this.mtb_cep_Enter);
            this.mtb_cep.Leave += new System.EventHandler(this.mtb_cep_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tel. Contato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Tel. Contato 2";
            // 
            // gb_dataNasc
            // 
            this.gb_dataNasc.Controls.Add(this.mtb_dtNasc);
            this.gb_dataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_dataNasc.Location = new System.Drawing.Point(165, 164);
            this.gb_dataNasc.Name = "gb_dataNasc";
            this.gb_dataNasc.Size = new System.Drawing.Size(141, 47);
            this.gb_dataNasc.TabIndex = 43;
            this.gb_dataNasc.TabStop = false;
            this.gb_dataNasc.Text = "Data de Nascimento";
            // 
            // mtb_dtNasc
            // 
            this.mtb_dtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_dtNasc.Location = new System.Drawing.Point(6, 19);
            this.mtb_dtNasc.Name = "mtb_dtNasc";
            this.mtb_dtNasc.Size = new System.Drawing.Size(78, 20);
            this.mtb_dtNasc.TabIndex = 0;
            this.mtb_dtNasc.ValidatingType = typeof(System.DateTime);
            this.mtb_dtNasc.Enter += new System.EventHandler(this.mtb_dtNasc_Enter);
            this.mtb_dtNasc.Leave += new System.EventHandler(this.mtb_dtNasc_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(158, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 20);
            this.label17.TabIndex = 49;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(158, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 20);
            this.label18.TabIndex = 50;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(158, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 20);
            this.label19.TabIndex = 51;
            this.label19.Text = "*";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(162, 138);
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(144, 20);
            this.mtb_cpf.TabIndex = 52;
            this.mtb_cpf.Enter += new System.EventHandler(this.mtb_cpf_Enter);
            this.mtb_cpf.Leave += new System.EventHandler(this.mtb_cpf_Leave);
            // 
            // mtb_telCont1
            // 
            this.mtb_telCont1.Location = new System.Drawing.Point(162, 241);
            this.mtb_telCont1.Name = "mtb_telCont1";
            this.mtb_telCont1.Size = new System.Drawing.Size(100, 20);
            this.mtb_telCont1.TabIndex = 53;
            this.mtb_telCont1.Enter += new System.EventHandler(this.mtb_telCont1_Enter);
            this.mtb_telCont1.Leave += new System.EventHandler(this.mtb_telCont1_Leave);
            // 
            // mtb_telCont2
            // 
            this.mtb_telCont2.Location = new System.Drawing.Point(273, 241);
            this.mtb_telCont2.Name = "mtb_telCont2";
            this.mtb_telCont2.Size = new System.Drawing.Size(100, 20);
            this.mtb_telCont2.TabIndex = 54;
            this.mtb_telCont2.Enter += new System.EventHandler(this.mtb_telCont2_Enter);
            this.mtb_telCont2.Leave += new System.EventHandler(this.mtb_telCont2_Leave);
            // 
            // F_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(649, 409);
            this.Controls.Add(this.mtb_telCont2);
            this.Controls.Add(this.mtb_telCont1);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.lbDataNasci);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_procurarCpf);
            this.Controls.Add(this.gb_dataReg);
            this.Controls.Add(this.gb_sexo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_infos);
            this.Controls.Add(this.btn_procurarNome);
            this.Controls.Add(this.pb_perfil);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.gb_dataNasc);
            this.Name = "F_Cliente";
            this.Text = "Cadastro Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pb_perfil)).EndInit();
            this.gb_sexo.ResumeLayout(false);
            this.gb_sexo.PerformLayout();
            this.gb_dataReg.ResumeLayout(false);
            this.gb_dataReg.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gb_dataNasc.ResumeLayout(false);
            this.gb_dataNasc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lbDataNasci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.ComboBox cb_pais;
        private System.Windows.Forms.ComboBox cb_logradouro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pb_perfil;
        private System.Windows.Forms.Button btn_procurarNome;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_infos;
        private System.Windows.Forms.GroupBox gb_sexo;
        private System.Windows.Forms.GroupBox gb_dataReg;
        private System.Windows.Forms.ComboBox cb_anoReg;
        private System.Windows.Forms.ComboBox cb_mesReg;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.Button btn_procurarCpf;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_dataNasc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rb_feminino;
        private System.Windows.Forms.RadioButton rb_masculino;
        private System.Windows.Forms.MaskedTextBox mtb_cep;
        public System.Windows.Forms.TextBox tb_nome;
        public System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.MaskedTextBox mtb_telCont1;
        private System.Windows.Forms.MaskedTextBox mtb_telCont2;
        private System.Windows.Forms.MaskedTextBox mtb_dtNasc;
    }
}

