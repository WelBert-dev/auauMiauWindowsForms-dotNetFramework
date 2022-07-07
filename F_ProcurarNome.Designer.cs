namespace wfDoutorAuauEMiau
{
    partial class F_ProcurarNome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.cb_tipoDeFlag = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gb_referenciaDeBusca = new System.Windows.Forms.GroupBox();
            this.lb_infoTipo = new System.Windows.Forms.Label();
            this.mtb_valorBuscado = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_Principal = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gb_referenciaDeBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Principal)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_confirmar.Enabled = false;
            this.btn_confirmar.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(429, 492);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(115, 31);
            this.btn_confirmar.TabIndex = 7;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // cb_tipoDeFlag
            // 
            this.cb_tipoDeFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipoDeFlag.FormattingEnabled = true;
            this.cb_tipoDeFlag.Location = new System.Drawing.Point(52, 14);
            this.cb_tipoDeFlag.Name = "cb_tipoDeFlag";
            this.cb_tipoDeFlag.Size = new System.Drawing.Size(109, 21);
            this.cb_tipoDeFlag.TabIndex = 8;
            this.cb_tipoDeFlag.SelectedIndexChanged += new System.EventHandler(this.cb_tipoDeFlag_SelectedIndexChanged);
            this.cb_tipoDeFlag.Click += new System.EventHandler(this.cb_tipoDeFlag_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(167, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Valor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tipo:";
            // 
            // gb_referenciaDeBusca
            // 
            this.gb_referenciaDeBusca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_referenciaDeBusca.Controls.Add(this.lb_infoTipo);
            this.gb_referenciaDeBusca.Controls.Add(this.mtb_valorBuscado);
            this.gb_referenciaDeBusca.Controls.Add(this.btn_buscar);
            this.gb_referenciaDeBusca.Controls.Add(this.cb_tipoDeFlag);
            this.gb_referenciaDeBusca.Controls.Add(this.label11);
            this.gb_referenciaDeBusca.Controls.Add(this.label10);
            this.gb_referenciaDeBusca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb_referenciaDeBusca.Location = new System.Drawing.Point(12, 12);
            this.gb_referenciaDeBusca.Name = "gb_referenciaDeBusca";
            this.gb_referenciaDeBusca.Size = new System.Drawing.Size(659, 57);
            this.gb_referenciaDeBusca.TabIndex = 19;
            this.gb_referenciaDeBusca.TabStop = false;
            // 
            // lb_infoTipo
            // 
            this.lb_infoTipo.AutoSize = true;
            this.lb_infoTipo.Location = new System.Drawing.Point(115, 38);
            this.lb_infoTipo.Name = "lb_infoTipo";
            this.lb_infoTipo.Size = new System.Drawing.Size(0, 13);
            this.lb_infoTipo.TabIndex = 15;
            this.lb_infoTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_infoTipo.Visible = false;
            // 
            // mtb_valorBuscado
            // 
            this.mtb_valorBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_valorBuscado.Location = new System.Drawing.Point(221, 14);
            this.mtb_valorBuscado.Name = "mtb_valorBuscado";
            this.mtb_valorBuscado.ReadOnly = true;
            this.mtb_valorBuscado.Size = new System.Drawing.Size(330, 20);
            this.mtb_valorBuscado.TabIndex = 13;
            this.mtb_valorBuscado.Enter += new System.EventHandler(this.mtb_valorBuscado_Enter);
            this.mtb_valorBuscado.Leave += new System.EventHandler(this.mtb_valorBuscado_Leave);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_buscar.Enabled = false;
            this.btn_buscar.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(557, 9);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(96, 30);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // dgv_Principal
            // 
            this.dgv_Principal.AllowUserToAddRows = false;
            this.dgv_Principal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Principal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Principal.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Principal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Principal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Principal.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Principal.Location = new System.Drawing.Point(12, 75);
            this.dgv_Principal.MultiSelect = false;
            this.dgv_Principal.Name = "dgv_Principal";
            this.dgv_Principal.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Principal.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Principal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Principal.Size = new System.Drawing.Size(1069, 411);
            this.dgv_Principal.TabIndex = 20;
            this.dgv_Principal.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Principal_ColumnHeaderMouseClick);
            this.dgv_Principal.SelectionChanged += new System.EventHandler(this.dgv_Principal_SelectionChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cancelar.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(550, 492);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(115, 31);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // F_ProcurarNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 528);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dgv_Principal);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.gb_referenciaDeBusca);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "F_ProcurarNome";
            this.Text = "Buscar Registro";
            this.gb_referenciaDeBusca.ResumeLayout(false);
            this.gb_referenciaDeBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Principal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.ComboBox cb_tipoDeFlag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gb_referenciaDeBusca;
        private System.Windows.Forms.DataGridView dgv_Principal;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.MaskedTextBox mtb_valorBuscado;
        private System.Windows.Forms.Label lb_infoTipo;
        private System.Windows.Forms.Button btn_cancelar;
    }
}

