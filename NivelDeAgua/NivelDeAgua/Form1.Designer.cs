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
            this.porta_text = new System.Windows.Forms.TextBox();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_desconectar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
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
            this.pictureBox2.Location = new System.Drawing.Point(12, 310);
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
            this.btn_iniciar.Location = new System.Drawing.Point(12, 110);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 4;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Enabled = false;
            this.btn_parar.Location = new System.Drawing.Point(118, 110);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(75, 23);
            this.btn_parar.TabIndex = 5;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // tbxScale
            // 
            this.tbxScale.Location = new System.Drawing.Point(12, 52);
            this.tbxScale.Name = "tbxScale";
            this.tbxScale.Size = new System.Drawing.Size(91, 20);
            this.tbxScale.TabIndex = 6;
            this.tbxScale.Text = "1";
            this.tbxScale.TextChanged += new System.EventHandler(this.tbxScale_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 157);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Distância";
            // 
            // TimerLeitura
            // 
            this.TimerLeitura.Interval = 500;
            this.TimerLeitura.Tick += new System.EventHandler(this.TimerLeitura_Tick);
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Location = new System.Drawing.Point(12, 201);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(37, 13);
            this.lblStatus2.TabIndex = 8;
            this.lblStatus2.Text = "Status";
            this.lblStatus2.Click += new System.EventHandler(this.label2_Click);
            // 
            // porta_text
            // 
            this.porta_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.porta_text.Location = new System.Drawing.Point(12, 78);
            this.porta_text.Name = "porta_text";
            this.porta_text.Size = new System.Drawing.Size(91, 20);
            this.porta_text.TabIndex = 9;
            this.porta_text.Text = "Selecione a Porta";
            this.porta_text.TextChanged += new System.EventHandler(this.porta_text_TextChanged);
            this.porta_text.Enter += new System.EventHandler(this.porta_text_Enter_1);
            this.porta_text.Leave += new System.EventHandler(this.porta_text_Leave_1);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(105, 76);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 10;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Location = new System.Drawing.Point(186, 76);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(85, 23);
            this.btn_desconectar.TabIndex = 11;
            this.btn_desconectar.Text = "Desconectar";
            this.btn_desconectar.UseVisualStyleBackColor = true;
            this.btn_desconectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_desconectar);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.porta_text);
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
        private System.Windows.Forms.TextBox porta_text;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_desconectar;
    }
}

