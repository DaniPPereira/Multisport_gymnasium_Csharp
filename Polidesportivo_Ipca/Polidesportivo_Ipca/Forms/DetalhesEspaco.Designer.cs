namespace Polidesportivo_Ipca
{
    partial class DetalhesEspaco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalhesEspaco));
            this.PctBoxSair = new System.Windows.Forms.PictureBox();
            this.LstHorasOcupadas = new System.Windows.Forms.ListView();
            this.DataReserva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoraInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoraFim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblHorasOcupadas = new System.Windows.Forms.Label();
            this.BtnReservar = new System.Windows.Forms.Button();
            this.DataTimeFim = new System.Windows.Forms.DateTimePicker();
            this.DataTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.DataTimeData = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.LblInicio = new System.Windows.Forms.Label();
            this.LblFim = new System.Windows.Forms.Label();
            this.PctBoxImagem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // PctBoxSair
            // 
            this.PctBoxSair.BackColor = System.Drawing.Color.Transparent;
            this.PctBoxSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PctBoxSair.BackgroundImage")));
            this.PctBoxSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PctBoxSair.Location = new System.Drawing.Point(940, 12);
            this.PctBoxSair.Name = "PctBoxSair";
            this.PctBoxSair.Size = new System.Drawing.Size(33, 27);
            this.PctBoxSair.TabIndex = 15;
            this.PctBoxSair.TabStop = false;
            this.PctBoxSair.Click += new System.EventHandler(this.PctBoxSair_Click_1);
            // 
            // LstHorasOcupadas
            // 
            this.LstHorasOcupadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstHorasOcupadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DataReserva,
            this.HoraInicio,
            this.HoraFim});
            this.LstHorasOcupadas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstHorasOcupadas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstHorasOcupadas.HideSelection = false;
            this.LstHorasOcupadas.Location = new System.Drawing.Point(502, 163);
            this.LstHorasOcupadas.Name = "LstHorasOcupadas";
            this.LstHorasOcupadas.Size = new System.Drawing.Size(350, 250);
            this.LstHorasOcupadas.TabIndex = 16;
            this.LstHorasOcupadas.UseCompatibleStateImageBehavior = false;
            this.LstHorasOcupadas.View = System.Windows.Forms.View.List;
            // 
            // DataReserva
            // 
            this.DataReserva.Text = "Data de Reserva";
            this.DataReserva.Width = 160;
            // 
            // HoraInicio
            // 
            this.HoraInicio.Text = "Hora de Inicio";
            this.HoraInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HoraInicio.Width = 95;
            // 
            // HoraFim
            // 
            this.HoraFim.Text = "Hora de Fim";
            this.HoraFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HoraFim.Width = 95;
            // 
            // LblHorasOcupadas
            // 
            this.LblHorasOcupadas.AutoSize = true;
            this.LblHorasOcupadas.Font = new System.Drawing.Font("Verdana", 14F);
            this.LblHorasOcupadas.ForeColor = System.Drawing.Color.White;
            this.LblHorasOcupadas.Location = new System.Drawing.Point(498, 137);
            this.LblHorasOcupadas.Name = "LblHorasOcupadas";
            this.LblHorasOcupadas.Size = new System.Drawing.Size(174, 23);
            this.LblHorasOcupadas.TabIndex = 17;
            this.LblHorasOcupadas.Text = "Horas Ocupadas:";
            // 
            // BtnReservar
            // 
            this.BtnReservar.BackColor = System.Drawing.Color.Transparent;
            this.BtnReservar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservar.ForeColor = System.Drawing.Color.White;
            this.BtnReservar.Location = new System.Drawing.Point(284, 374);
            this.BtnReservar.Name = "BtnReservar";
            this.BtnReservar.Size = new System.Drawing.Size(200, 39);
            this.BtnReservar.TabIndex = 18;
            this.BtnReservar.Text = "Reservar";
            this.BtnReservar.UseVisualStyleBackColor = false;
            this.BtnReservar.Click += new System.EventHandler(this.BtnReservar_Click);
            // 
            // DataTimeFim
            // 
            this.DataTimeFim.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTimeFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataTimeFim.Location = new System.Drawing.Point(284, 330);
            this.DataTimeFim.Name = "DataTimeFim";
            this.DataTimeFim.Size = new System.Drawing.Size(200, 20);
            this.DataTimeFim.TabIndex = 21;
            // 
            // DataTimeInicio
            // 
            this.DataTimeInicio.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataTimeInicio.Location = new System.Drawing.Point(284, 282);
            this.DataTimeInicio.Name = "DataTimeInicio";
            this.DataTimeInicio.Size = new System.Drawing.Size(200, 20);
            this.DataTimeInicio.TabIndex = 22;
            this.DataTimeInicio.ValueChanged += new System.EventHandler(this.DataTimeInicio_ValueChanged);
            // 
            // DataTimeData
            // 
            this.DataTimeData.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTimeData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataTimeData.Location = new System.Drawing.Point(284, 234);
            this.DataTimeData.Name = "DataTimeData";
            this.DataTimeData.Size = new System.Drawing.Size(200, 20);
            this.DataTimeData.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(388, -33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(281, 213);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(54, 18);
            this.lblData.TabIndex = 30;
            this.lblData.Text = "Data:";
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.BackColor = System.Drawing.Color.Transparent;
            this.LblInicio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblInicio.Location = new System.Drawing.Point(281, 260);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(150, 18);
            this.LblInicio.TabIndex = 31;
            this.LblInicio.Text = "Início de Reserva";
            // 
            // LblFim
            // 
            this.LblFim.AutoSize = true;
            this.LblFim.BackColor = System.Drawing.Color.Transparent;
            this.LblFim.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFim.ForeColor = System.Drawing.Color.White;
            this.LblFim.Location = new System.Drawing.Point(281, 309);
            this.LblFim.Name = "LblFim";
            this.LblFim.Size = new System.Drawing.Size(141, 18);
            this.LblFim.TabIndex = 32;
            this.LblFim.Text = "Fim de Reserva:";
            // 
            // PctBoxImagem
            // 
            this.PctBoxImagem.Location = new System.Drawing.Point(53, 232);
            this.PctBoxImagem.Name = "PctBoxImagem";
            this.PctBoxImagem.Size = new System.Drawing.Size(200, 181);
            this.PctBoxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBoxImagem.TabIndex = 33;
            this.PctBoxImagem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "label1";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.ForeColor = System.Drawing.Color.White;
            this.LblInfo.Location = new System.Drawing.Point(46, 163);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(58, 18);
            this.LblInfo.TabIndex = 35;
            this.LblInfo.Text = "label2";
            // 
            // DetalhesEspaco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 530);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PctBoxImagem);
            this.Controls.Add(this.LblFim);
            this.Controls.Add(this.LblInicio);
            this.Controls.Add(this.LblHorasOcupadas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataTimeData);
            this.Controls.Add(this.DataTimeInicio);
            this.Controls.Add(this.DataTimeFim);
            this.Controls.Add(this.BtnReservar);
            this.Controls.Add(this.LstHorasOcupadas);
            this.Controls.Add(this.PctBoxSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetalhesEspaco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3";
            this.Load += new System.EventHandler(this.DetalhesEspaco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBoxSair;
        private System.Windows.Forms.Label LblHorasOcupadas;
        private System.Windows.Forms.ColumnHeader HoraInicio;
        private System.Windows.Forms.ColumnHeader HoraFim;
        private System.Windows.Forms.ColumnHeader DataReserva;
        public System.Windows.Forms.ListView LstHorasOcupadas;
        private System.Windows.Forms.Button BtnReservar;
        private System.Windows.Forms.DateTimePicker DataTimeFim;
        private System.Windows.Forms.DateTimePicker DataTimeInicio;
        private System.Windows.Forms.DateTimePicker DataTimeData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.Label LblFim;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox PctBoxImagem;
        public System.Windows.Forms.Label LblInfo;
    }
}