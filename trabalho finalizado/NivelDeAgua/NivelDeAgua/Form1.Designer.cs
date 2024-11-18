namespace NivelDeAgua
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.tbxScale = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.TimerLeitura = new System.Windows.Forms.Timer(this.components);
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combobox_portas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusSeguranca = new System.Windows.Forms.Label();
            this.TimerSeguranca = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sensor de previsão de inundações";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\caio-\\Downloads\\ProjetoIntegradoImg\\logo_arduino.png";
            this.pictureBox1.Location = new System.Drawing.Point(12, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NivelDeAgua.Properties.Resources.logo_c_;
            this.pictureBox2.Location = new System.Drawing.Point(83, 377);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(276, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(512, 426);
            this.zedGraphControl1.TabIndex = 3;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Enabled = false;
            this.btn_iniciar.Location = new System.Drawing.Point(9, 166);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(85, 23);
            this.btn_iniciar.TabIndex = 4;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Enabled = false;
            this.btn_parar.Location = new System.Drawing.Point(95, 166);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(85, 23);
            this.btn_parar.TabIndex = 5;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // tbxScale
            // 
            this.tbxScale.Location = new System.Drawing.Point(92, 52);
            this.tbxScale.Name = "tbxScale";
            this.tbxScale.Size = new System.Drawing.Size(85, 20);
            this.tbxScale.TabIndex = 6;
            this.tbxScale.Text = "1";
            this.tbxScale.TextChanged += new System.EventHandler(this.tbxScale_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(63, 227);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // TimerLeitura
            // 
            this.TimerLeitura.Interval = 500;
            this.TimerLeitura.Tick += new System.EventHandler(this.TimerLeitura_Tick);
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Location = new System.Drawing.Point(63, 253);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(0, 13);
            this.lblStatus2.TabIndex = 8;
            this.lblStatus2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(9, 137);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(85, 23);
            this.btn_conectar.TabIndex = 10;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Location = new System.Drawing.Point(95, 137);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(85, 23);
            this.btn_desconectar.TabIndex = 11;
            this.btn_desconectar.Text = "Desconectar";
            this.btn_desconectar.UseVisualStyleBackColor = true;
            this.btn_desconectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Status:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Distância:";
            // 
            // combobox_portas
            // 
            this.combobox_portas.FormattingEnabled = true;
            this.combobox_portas.Items.AddRange(new object[] {
            "COM0",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20",
            "COM21",
            "COM22",
            "COM23",
            "COM24",
            "COM25",
            "COM26",
            "COM27",
            "COM28",
            "COM29",
            "COM30",
            "COM31",
            "COM32",
            "COM33",
            "COM34",
            "COM35",
            "COM36",
            "COM37",
            "COM38",
            "COM39",
            "COM40",
            "COM41",
            "COM42",
            "COM43",
            "COM44",
            "COM45",
            "COM46",
            "COM47",
            "COM48",
            "COM49",
            "COM50",
            "COM51",
            "COM52",
            "COM53",
            "COM54",
            "COM55",
            "COM56",
            "COM57",
            "COM58",
            "COM59",
            "COM60",
            "COM61",
            "COM62",
            "COM63",
            "COM64",
            "COM65",
            "COM66",
            "COM67",
            "COM68",
            "COM69",
            "COM70",
            "COM71",
            "COM72",
            "COM73",
            "COM74",
            "COM75",
            "COM76",
            "COM77",
            "COM78",
            "COM79",
            "COM80",
            "COM81",
            "COM82",
            "COM83",
            "COM84",
            "COM85",
            "COM86",
            "COM87",
            "COM88",
            "COM89",
            "COM90",
            "COM91",
            "COM92",
            "COM93",
            "COM94",
            "COM95",
            "COM96",
            "COM97",
            "COM98",
            "COM99",
            "COM100"});
            this.combobox_portas.Location = new System.Drawing.Point(92, 102);
            this.combobox_portas.Name = "combobox_portas";
            this.combobox_portas.Size = new System.Drawing.Size(85, 21);
            this.combobox_portas.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Escala";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Porta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Status de Segurança:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // StatusSeguranca
            // 
            this.StatusSeguranca.AutoSize = true;
            this.StatusSeguranca.Location = new System.Drawing.Point(122, 203);
            this.StatusSeguranca.Name = "StatusSeguranca";
            this.StatusSeguranca.Size = new System.Drawing.Size(0, 13);
            this.StatusSeguranca.TabIndex = 18;
            this.StatusSeguranca.Click += new System.EventHandler(this.label7_Click);
            // 
            // TimerSeguranca
            // 
            this.TimerSeguranca.Interval = 3000;
            this.TimerSeguranca.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusSeguranca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combobox_portas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_desconectar);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbxScale);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nível de Água";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.TextBox tbxScale;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer TimerLeitura;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobox_portas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label StatusSeguranca;
        private System.Windows.Forms.Timer TimerSeguranca;
    }
}

