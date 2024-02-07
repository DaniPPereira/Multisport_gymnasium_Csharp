namespace Polidesportivo_Ipca.Forms
{
    partial class VerPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerPerfil));
            this.PctBoxSair = new System.Windows.Forms.PictureBox();
            this.MenuStripPerfil = new System.Windows.Forms.MenuStrip();
            this.ToolStripVerReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMudarInformacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripConsultarFisico = new System.Windows.Forms.ToolStripMenuItem();
            this.LstReservas = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InicioReserva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FimReserva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Espaco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PctBoxLogo = new System.Windows.Forms.PictureBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtNrTelemovel = new System.Windows.Forms.TextBox();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.TxtBraco = new System.Windows.Forms.TextBox();
            this.TxtEnvergadura = new System.Windows.Forms.TextBox();
            this.TxtCoxa = new System.Windows.Forms.TextBox();
            this.TxtMassaCorporal = new System.Windows.Forms.TextBox();
            this.TxtOmbros = new System.Windows.Forms.TextBox();
            this.TxtAntebraco = new System.Windows.Forms.TextBox();
            this.TxtGluteos = new System.Windows.Forms.TextBox();
            this.TxtIMC = new System.Windows.Forms.TextBox();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.ComboBoxUser = new System.Windows.Forms.ComboBox();
            this.BtnAlterarDados = new System.Windows.Forms.Button();
            this.labelPeso = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelMassaCorporal = new System.Windows.Forms.Label();
            this.labelEnvergadura = new System.Windows.Forms.Label();
            this.labelOmbros = new System.Windows.Forms.Label();
            this.labelCoxa = new System.Windows.Forms.Label();
            this.labelBraco = new System.Windows.Forms.Label();
            this.labelGluteos = new System.Windows.Forms.Label();
            this.labelAntebraco = new System.Windows.Forms.Label();
            this.labelIMC = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTelemovel = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNProcesso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxSair)).BeginInit();
            this.MenuStripPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PctBoxSair
            // 
            this.PctBoxSair.BackColor = System.Drawing.Color.Transparent;
            this.PctBoxSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PctBoxSair.BackgroundImage")));
            this.PctBoxSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PctBoxSair.Location = new System.Drawing.Point(777, 1);
            this.PctBoxSair.Name = "PctBoxSair";
            this.PctBoxSair.Size = new System.Drawing.Size(20, 23);
            this.PctBoxSair.TabIndex = 16;
            this.PctBoxSair.TabStop = false;
            this.PctBoxSair.Click += new System.EventHandler(this.PctBoxSair_Click);
            // 
            // MenuStripPerfil
            // 
            this.MenuStripPerfil.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStripPerfil.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStripPerfil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripVerReservas,
            this.ToolStripMudarInformacoes,
            this.ToolStripConsultarFisico});
            this.MenuStripPerfil.Location = new System.Drawing.Point(0, 0);
            this.MenuStripPerfil.Name = "MenuStripPerfil";
            this.MenuStripPerfil.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.MenuStripPerfil.Size = new System.Drawing.Size(800, 24);
            this.MenuStripPerfil.TabIndex = 17;
            this.MenuStripPerfil.Text = "MenuStripPerfil";
            // 
            // ToolStripVerReservas
            // 
            this.ToolStripVerReservas.Name = "ToolStripVerReservas";
            this.ToolStripVerReservas.Size = new System.Drawing.Size(117, 22);
            this.ToolStripVerReservas.Text = "Ver Reservas";
            this.ToolStripVerReservas.Click += new System.EventHandler(this.ToolStripVerReservas_Click);
            // 
            // ToolStripMudarInformacoes
            // 
            this.ToolStripMudarInformacoes.Name = "ToolStripMudarInformacoes";
            this.ToolStripMudarInformacoes.Size = new System.Drawing.Size(234, 22);
            this.ToolStripMudarInformacoes.Text = "Mudar Informações Pessoais";
            this.ToolStripMudarInformacoes.Click += new System.EventHandler(this.ToolStripMudarInformacoes_Click);
            // 
            // ToolStripConsultarFisico
            // 
            this.ToolStripConsultarFisico.Name = "ToolStripConsultarFisico";
            this.ToolStripConsultarFisico.Size = new System.Drawing.Size(137, 22);
            this.ToolStripConsultarFisico.Text = "Consultar Físico";
            this.ToolStripConsultarFisico.Click += new System.EventHandler(this.ToolStripConsultarFisico_Click);
            // 
            // LstReservas
            // 
            this.LstReservas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Data,
            this.InicioReserva,
            this.FimReserva,
            this.Espaco,
            this.Estado});
            this.LstReservas.FullRowSelect = true;
            this.LstReservas.HideSelection = false;
            this.LstReservas.Location = new System.Drawing.Point(26, 78);
            this.LstReservas.Name = "LstReservas";
            this.LstReservas.Size = new System.Drawing.Size(735, 340);
            this.LstReservas.TabIndex = 18;
            this.LstReservas.UseCompatibleStateImageBehavior = false;
            this.LstReservas.Visible = false;
            this.LstReservas.SelectedIndexChanged += new System.EventHandler(this.LstReservas_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 122;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 122;
            // 
            // InicioReserva
            // 
            this.InicioReserva.Text = "Fim da Reserva";
            this.InicioReserva.Width = 122;
            // 
            // FimReserva
            // 
            this.FimReserva.Text = "Fim da Reserva";
            this.FimReserva.Width = 122;
            // 
            // Espaco
            // 
            this.Espaco.Text = "Espaço";
            this.Espaco.Width = 122;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 122;
            // 
            // PctBoxLogo
            // 
            this.PctBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PctBoxLogo.Image")));
            this.PctBoxLogo.Location = new System.Drawing.Point(165, 40);
            this.PctBoxLogo.Name = "PctBoxLogo";
            this.PctBoxLogo.Size = new System.Drawing.Size(463, 365);
            this.PctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBoxLogo.TabIndex = 19;
            this.PctBoxLogo.TabStop = false;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(79, 140);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(219, 20);
            this.TxtNome.TabIndex = 20;
            this.TxtNome.Visible = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(466, 140);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(219, 20);
            this.TxtPassword.TabIndex = 21;
            this.TxtPassword.Visible = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(79, 301);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(219, 20);
            this.TxtEmail.TabIndex = 22;
            this.TxtEmail.Visible = false;
            // 
            // TxtNrTelemovel
            // 
            this.TxtNrTelemovel.Location = new System.Drawing.Point(466, 301);
            this.TxtNrTelemovel.Name = "TxtNrTelemovel";
            this.TxtNrTelemovel.Size = new System.Drawing.Size(219, 20);
            this.TxtNrTelemovel.TabIndex = 23;
            this.TxtNrTelemovel.Visible = false;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.ForeColor = System.Drawing.Color.White;
            this.BtnAlterar.Location = new System.Drawing.Point(240, 351);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(268, 39);
            this.BtnAlterar.TabIndex = 24;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Visible = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(79, 114);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.ReadOnly = true;
            this.TxtPeso.Size = new System.Drawing.Size(219, 20);
            this.TxtPeso.TabIndex = 25;
            this.TxtPeso.Visible = false;
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(79, 166);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.ReadOnly = true;
            this.TxtAltura.Size = new System.Drawing.Size(219, 20);
            this.TxtAltura.TabIndex = 26;
            this.TxtAltura.Visible = false;
            // 
            // TxtBraco
            // 
            this.TxtBraco.Location = new System.Drawing.Point(79, 212);
            this.TxtBraco.Name = "TxtBraco";
            this.TxtBraco.ReadOnly = true;
            this.TxtBraco.Size = new System.Drawing.Size(219, 20);
            this.TxtBraco.TabIndex = 27;
            this.TxtBraco.Visible = false;
            // 
            // TxtEnvergadura
            // 
            this.TxtEnvergadura.Location = new System.Drawing.Point(79, 255);
            this.TxtEnvergadura.Name = "TxtEnvergadura";
            this.TxtEnvergadura.ReadOnly = true;
            this.TxtEnvergadura.Size = new System.Drawing.Size(219, 20);
            this.TxtEnvergadura.TabIndex = 28;
            this.TxtEnvergadura.Visible = false;
            // 
            // TxtCoxa
            // 
            this.TxtCoxa.Location = new System.Drawing.Point(79, 301);
            this.TxtCoxa.Name = "TxtCoxa";
            this.TxtCoxa.ReadOnly = true;
            this.TxtCoxa.Size = new System.Drawing.Size(219, 20);
            this.TxtCoxa.TabIndex = 29;
            this.TxtCoxa.Visible = false;
            // 
            // TxtMassaCorporal
            // 
            this.TxtMassaCorporal.Location = new System.Drawing.Point(466, 114);
            this.TxtMassaCorporal.Name = "TxtMassaCorporal";
            this.TxtMassaCorporal.ReadOnly = true;
            this.TxtMassaCorporal.Size = new System.Drawing.Size(219, 20);
            this.TxtMassaCorporal.TabIndex = 30;
            this.TxtMassaCorporal.Visible = false;
            // 
            // TxtOmbros
            // 
            this.TxtOmbros.Location = new System.Drawing.Point(466, 166);
            this.TxtOmbros.Name = "TxtOmbros";
            this.TxtOmbros.ReadOnly = true;
            this.TxtOmbros.Size = new System.Drawing.Size(219, 20);
            this.TxtOmbros.TabIndex = 31;
            this.TxtOmbros.Visible = false;
            // 
            // TxtAntebraco
            // 
            this.TxtAntebraco.Location = new System.Drawing.Point(466, 212);
            this.TxtAntebraco.Name = "TxtAntebraco";
            this.TxtAntebraco.ReadOnly = true;
            this.TxtAntebraco.Size = new System.Drawing.Size(219, 20);
            this.TxtAntebraco.TabIndex = 32;
            this.TxtAntebraco.Visible = false;
            // 
            // TxtGluteos
            // 
            this.TxtGluteos.Location = new System.Drawing.Point(466, 255);
            this.TxtGluteos.Name = "TxtGluteos";
            this.TxtGluteos.ReadOnly = true;
            this.TxtGluteos.Size = new System.Drawing.Size(219, 20);
            this.TxtGluteos.TabIndex = 33;
            this.TxtGluteos.Visible = false;
            // 
            // TxtIMC
            // 
            this.TxtIMC.Location = new System.Drawing.Point(466, 302);
            this.TxtIMC.Name = "TxtIMC";
            this.TxtIMC.ReadOnly = true;
            this.TxtIMC.Size = new System.Drawing.Size(219, 20);
            this.TxtIMC.TabIndex = 34;
            this.TxtIMC.Visible = false;
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarReserva.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarReserva.ForeColor = System.Drawing.Color.White;
            this.btnEliminarReserva.Location = new System.Drawing.Point(493, 40);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(268, 39);
            this.btnEliminarReserva.TabIndex = 35;
            this.btnEliminarReserva.Text = "Eliminar Reserva";
            this.btnEliminarReserva.UseVisualStyleBackColor = false;
            this.btnEliminarReserva.Visible = false;
            this.btnEliminarReserva.Click += new System.EventHandler(this.BtnEliminarReserva_Click);
            // 
            // ComboBoxUser
            // 
            this.ComboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxUser.FormattingEnabled = true;
            this.ComboBoxUser.Location = new System.Drawing.Point(79, 58);
            this.ComboBoxUser.Name = "ComboBoxUser";
            this.ComboBoxUser.Size = new System.Drawing.Size(219, 21);
            this.ComboBoxUser.TabIndex = 36;
            this.ComboBoxUser.Visible = false;
            this.ComboBoxUser.SelectedIndexChanged += new System.EventHandler(this.ComboBoxUser_SelectedIndexChanged);
            // 
            // BtnAlterarDados
            // 
            this.BtnAlterarDados.BackColor = System.Drawing.Color.Transparent;
            this.BtnAlterarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAlterarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterarDados.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterarDados.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarDados.Location = new System.Drawing.Point(240, 351);
            this.BtnAlterarDados.Name = "BtnAlterarDados";
            this.BtnAlterarDados.Size = new System.Drawing.Size(268, 39);
            this.BtnAlterarDados.TabIndex = 37;
            this.BtnAlterarDados.Text = "Alterar";
            this.BtnAlterarDados.UseVisualStyleBackColor = false;
            this.BtnAlterarDados.Visible = false;
            this.BtnAlterarDados.Click += new System.EventHandler(this.BtnAlterarDados_Click);
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelPeso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPeso.Location = new System.Drawing.Point(76, 94);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(47, 17);
            this.labelPeso.TabIndex = 38;
            this.labelPeso.Text = "Peso:";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelAltura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAltura.Location = new System.Drawing.Point(76, 146);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(56, 17);
            this.labelAltura.TabIndex = 40;
            this.labelAltura.Text = "Altura:";
            // 
            // labelMassaCorporal
            // 
            this.labelMassaCorporal.AutoSize = true;
            this.labelMassaCorporal.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelMassaCorporal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMassaCorporal.Location = new System.Drawing.Point(463, 94);
            this.labelMassaCorporal.Name = "labelMassaCorporal";
            this.labelMassaCorporal.Size = new System.Drawing.Size(104, 17);
            this.labelMassaCorporal.TabIndex = 42;
            this.labelMassaCorporal.Text = "Massa Magra:";
            // 
            // labelEnvergadura
            // 
            this.labelEnvergadura.AutoSize = true;
            this.labelEnvergadura.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelEnvergadura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEnvergadura.Location = new System.Drawing.Point(76, 235);
            this.labelEnvergadura.Name = "labelEnvergadura";
            this.labelEnvergadura.Size = new System.Drawing.Size(103, 17);
            this.labelEnvergadura.TabIndex = 43;
            this.labelEnvergadura.Text = "Envergadura:";
            // 
            // labelOmbros
            // 
            this.labelOmbros.AutoSize = true;
            this.labelOmbros.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelOmbros.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOmbros.Location = new System.Drawing.Point(461, 146);
            this.labelOmbros.Name = "labelOmbros";
            this.labelOmbros.Size = new System.Drawing.Size(70, 17);
            this.labelOmbros.TabIndex = 44;
            this.labelOmbros.Text = "Ombros:";
            // 
            // labelCoxa
            // 
            this.labelCoxa.AutoSize = true;
            this.labelCoxa.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelCoxa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCoxa.Location = new System.Drawing.Point(76, 281);
            this.labelCoxa.Name = "labelCoxa";
            this.labelCoxa.Size = new System.Drawing.Size(50, 17);
            this.labelCoxa.TabIndex = 45;
            this.labelCoxa.Text = "Coxa:";
            // 
            // labelBraco
            // 
            this.labelBraco.AutoSize = true;
            this.labelBraco.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelBraco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelBraco.Location = new System.Drawing.Point(76, 192);
            this.labelBraco.Name = "labelBraco";
            this.labelBraco.Size = new System.Drawing.Size(54, 17);
            this.labelBraco.TabIndex = 46;
            this.labelBraco.Text = "Braço:";
            // 
            // labelGluteos
            // 
            this.labelGluteos.AutoSize = true;
            this.labelGluteos.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelGluteos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGluteos.Location = new System.Drawing.Point(463, 235);
            this.labelGluteos.Name = "labelGluteos";
            this.labelGluteos.Size = new System.Drawing.Size(68, 17);
            this.labelGluteos.TabIndex = 47;
            this.labelGluteos.Text = "Gluteos:";
            // 
            // labelAntebraco
            // 
            this.labelAntebraco.AutoSize = true;
            this.labelAntebraco.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelAntebraco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAntebraco.Location = new System.Drawing.Point(463, 192);
            this.labelAntebraco.Name = "labelAntebraco";
            this.labelAntebraco.Size = new System.Drawing.Size(86, 17);
            this.labelAntebraco.TabIndex = 48;
            this.labelAntebraco.Text = "Antebraço:";
            // 
            // labelIMC
            // 
            this.labelIMC.AutoSize = true;
            this.labelIMC.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelIMC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelIMC.Location = new System.Drawing.Point(468, 282);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(40, 17);
            this.labelIMC.TabIndex = 49;
            this.labelIMC.Text = "IMC:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPassword.Location = new System.Drawing.Point(463, 114);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(81, 17);
            this.labelPassword.TabIndex = 50;
            this.labelPassword.Text = "Password:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNome.Location = new System.Drawing.Point(76, 120);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(54, 17);
            this.labelNome.TabIndex = 51;
            this.labelNome.Text = "Nome:";
            // 
            // labelTelemovel
            // 
            this.labelTelemovel.AutoSize = true;
            this.labelTelemovel.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelTelemovel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTelemovel.Location = new System.Drawing.Point(468, 282);
            this.labelTelemovel.Name = "labelTelemovel";
            this.labelTelemovel.Size = new System.Drawing.Size(81, 17);
            this.labelTelemovel.TabIndex = 52;
            this.labelTelemovel.Text = "Telemovel:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEmail.Location = new System.Drawing.Point(76, 281);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 17);
            this.labelEmail.TabIndex = 53;
            this.labelEmail.Text = "Email:";
            // 
            // labelNProcesso
            // 
            this.labelNProcesso.AutoSize = true;
            this.labelNProcesso.Font = new System.Drawing.Font("Verdana", 7F);
            this.labelNProcesso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNProcesso.Location = new System.Drawing.Point(77, 40);
            this.labelNProcesso.Name = "labelNProcesso";
            this.labelNProcesso.Size = new System.Drawing.Size(75, 12);
            this.labelNProcesso.TabIndex = 54;
            this.labelNProcesso.Text = "Nº Processo:";
            // 
            // VerPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNProcesso);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTelemovel);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.labelAntebraco);
            this.Controls.Add(this.labelGluteos);
            this.Controls.Add(this.labelBraco);
            this.Controls.Add(this.labelCoxa);
            this.Controls.Add(this.labelOmbros);
            this.Controls.Add(this.labelEnvergadura);
            this.Controls.Add(this.labelMassaCorporal);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.BtnAlterarDados);
            this.Controls.Add(this.ComboBoxUser);
            this.Controls.Add(this.btnEliminarReserva);
            this.Controls.Add(this.TxtIMC);
            this.Controls.Add(this.TxtGluteos);
            this.Controls.Add(this.TxtAntebraco);
            this.Controls.Add(this.TxtOmbros);
            this.Controls.Add(this.TxtMassaCorporal);
            this.Controls.Add(this.TxtCoxa);
            this.Controls.Add(this.TxtEnvergadura);
            this.Controls.Add(this.TxtBraco);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.TxtNrTelemovel);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.PctBoxLogo);
            this.Controls.Add(this.LstReservas);
            this.Controls.Add(this.PctBoxSair);
            this.Controls.Add(this.MenuStripPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripPerfil;
            this.Name = "VerPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerPerfil";
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxSair)).EndInit();
            this.MenuStripPerfil.ResumeLayout(false);
            this.MenuStripPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctBoxSair;
        private System.Windows.Forms.MenuStrip MenuStripPerfil;
        private System.Windows.Forms.ToolStripMenuItem ToolStripVerReservas;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMudarInformacoes;
        private System.Windows.Forms.ToolStripMenuItem ToolStripConsultarFisico;
        private System.Windows.Forms.ListView LstReservas;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader InicioReserva;
        private System.Windows.Forms.ColumnHeader FimReserva;
        private System.Windows.Forms.ColumnHeader Espaco;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.PictureBox PctBoxLogo;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNrTelemovel;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.TextBox TxtBraco;
        private System.Windows.Forms.TextBox TxtEnvergadura;
        private System.Windows.Forms.TextBox TxtCoxa;
        private System.Windows.Forms.TextBox TxtMassaCorporal;
        private System.Windows.Forms.TextBox TxtOmbros;
        private System.Windows.Forms.TextBox TxtAntebraco;
        private System.Windows.Forms.TextBox TxtGluteos;
        private System.Windows.Forms.TextBox TxtIMC;
        private System.Windows.Forms.Button btnEliminarReserva;
        private System.Windows.Forms.ComboBox ComboBoxUser;
        private System.Windows.Forms.Button BtnAlterarDados;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelMassaCorporal;
        private System.Windows.Forms.Label labelEnvergadura;
        private System.Windows.Forms.Label labelOmbros;
        private System.Windows.Forms.Label labelCoxa;
        private System.Windows.Forms.Label labelBraco;
        private System.Windows.Forms.Label labelGluteos;
        private System.Windows.Forms.Label labelAntebraco;
        private System.Windows.Forms.Label labelIMC;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelTelemovel;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNProcesso;
    }
}