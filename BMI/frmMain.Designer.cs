namespace BMI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuários = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.papéisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sériesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeDeVisãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblUsr = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.tpPessoas = new System.Windows.Forms.TabPage();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.btnCancelarCad = new System.Windows.Forms.Button();
            this.btnPesqUsr = new System.Windows.Forms.Button();
            this.btnAlterUsr = new System.Windows.Forms.Button();
            this.btnNovoUsr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radioUsrInativo = new System.Windows.Forms.RadioButton();
            this.radioUsrAtivo = new System.Windows.Forms.RadioButton();
            this.cbNvlUsr = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarUsr = new System.Windows.Forms.Button();
            this.btnSairUsr = new System.Windows.Forms.Button();
            this.tbNomeUsr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbIdUsr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbConfSenhaUsr = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSenhaUsr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLoginUsr = new System.Windows.Forms.TextBox();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tpPapeis = new System.Windows.Forms.TabPage();
            this.lblNomePessoa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnSalvarPessoa = new System.Windows.Forms.Button();
            this.btnSairPessoa = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.tpPessoas.SuspendLayout();
            this.tpUsuarios.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.iMCToolStripMenuItem,
            this.testeDeVisãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.menuBtnSair});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1354, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuários,
            this.pessoasToolStripMenuItem,
            this.papéisToolStripMenuItem,
            this.escolasToolStripMenuItem,
            this.sériesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Tag = "C";
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuUsuários
            // 
            this.menuUsuários.Name = "menuUsuários";
            this.menuUsuários.Size = new System.Drawing.Size(119, 22);
            this.menuUsuários.Text = "Usuários";
            this.menuUsuários.Click += new System.EventHandler(this.menuUsuários_Click);
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // papéisToolStripMenuItem
            // 
            this.papéisToolStripMenuItem.Name = "papéisToolStripMenuItem";
            this.papéisToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.papéisToolStripMenuItem.Text = "Papéis";
            this.papéisToolStripMenuItem.Click += new System.EventHandler(this.papéisToolStripMenuItem_Click);
            // 
            // escolasToolStripMenuItem
            // 
            this.escolasToolStripMenuItem.Name = "escolasToolStripMenuItem";
            this.escolasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.escolasToolStripMenuItem.Text = "Escolas";
            this.escolasToolStripMenuItem.Click += new System.EventHandler(this.escolasToolStripMenuItem_Click);
            // 
            // sériesToolStripMenuItem
            // 
            this.sériesToolStripMenuItem.Name = "sériesToolStripMenuItem";
            this.sériesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sériesToolStripMenuItem.Text = "Séries";
            this.sériesToolStripMenuItem.Click += new System.EventHandler(this.sériesToolStripMenuItem_Click);
            // 
            // iMCToolStripMenuItem
            // 
            this.iMCToolStripMenuItem.Name = "iMCToolStripMenuItem";
            this.iMCToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.iMCToolStripMenuItem.Text = "IMC";
            // 
            // testeDeVisãoToolStripMenuItem
            // 
            this.testeDeVisãoToolStripMenuItem.Name = "testeDeVisãoToolStripMenuItem";
            this.testeDeVisãoToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.testeDeVisãoToolStripMenuItem.Text = "Teste de Visão";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // menuBtnSair
            // 
            this.menuBtnSair.Name = "menuBtnSair";
            this.menuBtnSair.Size = new System.Drawing.Size(38, 20);
            this.menuBtnSair.Text = "Sair";
            this.menuBtnSair.Click += new System.EventHandler(this.menuBtnSair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1584, 40);
            this.panel1.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(12, 13);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentUser.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblData,
            this.tsLblUsr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1354, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Barra de Status";
            // 
            // tsLblData
            // 
            this.tsLblData.Name = "tsLblData";
            this.tsLblData.Size = new System.Drawing.Size(31, 17);
            this.tsLblData.Text = "Data";
            // 
            // tsLblUsr
            // 
            this.tsLblUsr.Name = "tsLblUsr";
            this.tsLblUsr.Size = new System.Drawing.Size(47, 17);
            this.tsLblUsr.Text = "Usuário";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(514, 244);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(326, 284);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLogo.TabIndex = 3;
            this.pictureLogo.TabStop = false;
            // 
            // tpPessoas
            // 
            this.tpPessoas.BackColor = System.Drawing.Color.Gainsboro;
            this.tpPessoas.Controls.Add(this.btnSairPessoa);
            this.tpPessoas.Controls.Add(this.btnSalvarPessoa);
            this.tpPessoas.Controls.Add(this.textBox5);
            this.tpPessoas.Controls.Add(this.textBox4);
            this.tpPessoas.Controls.Add(this.textBox3);
            this.tpPessoas.Controls.Add(this.textBox2);
            this.tpPessoas.Controls.Add(this.textBox1);
            this.tpPessoas.Controls.Add(this.label10);
            this.tpPessoas.Controls.Add(this.label9);
            this.tpPessoas.Controls.Add(this.label8);
            this.tpPessoas.Controls.Add(this.label7);
            this.tpPessoas.Controls.Add(this.lblNomePessoa);
            this.tpPessoas.Location = new System.Drawing.Point(4, 22);
            this.tpPessoas.Name = "tpPessoas";
            this.tpPessoas.Padding = new System.Windows.Forms.Padding(3);
            this.tpPessoas.Size = new System.Drawing.Size(1576, 620);
            this.tpPessoas.TabIndex = 1;
            this.tpPessoas.Text = "Pessoas";
            // 
            // tpUsuarios
            // 
            this.tpUsuarios.BackColor = System.Drawing.Color.Gainsboro;
            this.tpUsuarios.Controls.Add(this.btnCancelarCad);
            this.tpUsuarios.Controls.Add(this.btnPesqUsr);
            this.tpUsuarios.Controls.Add(this.btnAlterUsr);
            this.tpUsuarios.Controls.Add(this.btnNovoUsr);
            this.tpUsuarios.Controls.Add(this.label5);
            this.tpUsuarios.Controls.Add(this.radioUsrInativo);
            this.tpUsuarios.Controls.Add(this.radioUsrAtivo);
            this.tpUsuarios.Controls.Add(this.cbNvlUsr);
            this.tpUsuarios.Controls.Add(this.label4);
            this.tpUsuarios.Controls.Add(this.btnSalvarUsr);
            this.tpUsuarios.Controls.Add(this.btnSairUsr);
            this.tpUsuarios.Controls.Add(this.tbNomeUsr);
            this.tpUsuarios.Controls.Add(this.label2);
            this.tpUsuarios.Controls.Add(this.groupBox1);
            this.tpUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tpUsuarios.Name = "tpUsuarios";
            this.tpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuarios.Size = new System.Drawing.Size(1576, 620);
            this.tpUsuarios.TabIndex = 0;
            this.tpUsuarios.Text = "Usuários";
            // 
            // btnCancelarCad
            // 
            this.btnCancelarCad.Location = new System.Drawing.Point(1223, 176);
            this.btnCancelarCad.Name = "btnCancelarCad";
            this.btnCancelarCad.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCad.TabIndex = 8;
            this.btnCancelarCad.Text = "Cancelar";
            this.btnCancelarCad.UseVisualStyleBackColor = true;
            this.btnCancelarCad.Click += new System.EventHandler(this.btnCancelarCad_Click);
            // 
            // btnPesqUsr
            // 
            this.btnPesqUsr.Location = new System.Drawing.Point(1223, 106);
            this.btnPesqUsr.Name = "btnPesqUsr";
            this.btnPesqUsr.Size = new System.Drawing.Size(75, 23);
            this.btnPesqUsr.TabIndex = 16;
            this.btnPesqUsr.Text = "Pesquisar";
            this.btnPesqUsr.UseVisualStyleBackColor = true;
            this.btnPesqUsr.Click += new System.EventHandler(this.btnPesqUsr_Click);
            // 
            // btnAlterUsr
            // 
            this.btnAlterUsr.Location = new System.Drawing.Point(1223, 142);
            this.btnAlterUsr.Name = "btnAlterUsr";
            this.btnAlterUsr.Size = new System.Drawing.Size(75, 23);
            this.btnAlterUsr.TabIndex = 15;
            this.btnAlterUsr.Text = "Alterar";
            this.btnAlterUsr.UseVisualStyleBackColor = true;
            this.btnAlterUsr.Click += new System.EventHandler(this.btnAlterUsr_Click);
            // 
            // btnNovoUsr
            // 
            this.btnNovoUsr.Location = new System.Drawing.Point(1223, 72);
            this.btnNovoUsr.Name = "btnNovoUsr";
            this.btnNovoUsr.Size = new System.Drawing.Size(75, 23);
            this.btnNovoUsr.TabIndex = 14;
            this.btnNovoUsr.Text = "Novo";
            this.btnNovoUsr.UseVisualStyleBackColor = true;
            this.btnNovoUsr.Click += new System.EventHandler(this.btnNovoUsr_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Status do usuário:";
            // 
            // radioUsrInativo
            // 
            this.radioUsrInativo.AutoSize = true;
            this.radioUsrInativo.Location = new System.Drawing.Point(643, 176);
            this.radioUsrInativo.Name = "radioUsrInativo";
            this.radioUsrInativo.Size = new System.Drawing.Size(57, 17);
            this.radioUsrInativo.TabIndex = 6;
            this.radioUsrInativo.TabStop = true;
            this.radioUsrInativo.Text = "Inativo";
            this.radioUsrInativo.UseVisualStyleBackColor = true;
            // 
            // radioUsrAtivo
            // 
            this.radioUsrAtivo.AutoSize = true;
            this.radioUsrAtivo.Location = new System.Drawing.Point(575, 176);
            this.radioUsrAtivo.Name = "radioUsrAtivo";
            this.radioUsrAtivo.Size = new System.Drawing.Size(49, 17);
            this.radioUsrAtivo.TabIndex = 5;
            this.radioUsrAtivo.TabStop = true;
            this.radioUsrAtivo.Text = "Ativo";
            this.radioUsrAtivo.UseVisualStyleBackColor = true;
            // 
            // cbNvlUsr
            // 
            this.cbNvlUsr.FormattingEnabled = true;
            this.cbNvlUsr.Location = new System.Drawing.Point(575, 127);
            this.cbNvlUsr.Name = "cbNvlUsr";
            this.cbNvlUsr.Size = new System.Drawing.Size(153, 21);
            this.cbNvlUsr.TabIndex = 4;
            this.cbNvlUsr.Text = "Selecione...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nível do usuário:";
            // 
            // btnSalvarUsr
            // 
            this.btnSalvarUsr.Location = new System.Drawing.Point(1200, 522);
            this.btnSalvarUsr.Name = "btnSalvarUsr";
            this.btnSalvarUsr.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarUsr.TabIndex = 7;
            this.btnSalvarUsr.Text = "Salvar";
            this.btnSalvarUsr.UseVisualStyleBackColor = true;
            this.btnSalvarUsr.Click += new System.EventHandler(this.btnSalvarUsr_Click);
            // 
            // btnSairUsr
            // 
            this.btnSairUsr.Location = new System.Drawing.Point(1102, 522);
            this.btnSairUsr.Name = "btnSairUsr";
            this.btnSairUsr.Size = new System.Drawing.Size(75, 23);
            this.btnSairUsr.TabIndex = 8;
            this.btnSairUsr.Text = "Sair";
            this.btnSairUsr.UseVisualStyleBackColor = true;
            this.btnSairUsr.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbNomeUsr
            // 
            this.tbNomeUsr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNomeUsr.Location = new System.Drawing.Point(575, 80);
            this.tbNomeUsr.Name = "tbNomeUsr";
            this.tbNomeUsr.Size = new System.Drawing.Size(350, 20);
            this.tbNomeUsr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do usuário:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.tbIdUsr);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbConfSenhaUsr);
            this.groupBox1.Controls.Add(this.lblSenha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSenhaUsr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbLoginUsr);
            this.groupBox1.Location = new System.Drawing.Point(24, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 204);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciais do usuário:";
            // 
            // tbIdUsr
            // 
            this.tbIdUsr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbIdUsr.Enabled = false;
            this.tbIdUsr.Location = new System.Drawing.Point(162, 44);
            this.tbIdUsr.Name = "tbIdUsr";
            this.tbIdUsr.Size = new System.Drawing.Size(153, 20);
            this.tbIdUsr.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Código do usuário:";
            // 
            // tbConfSenhaUsr
            // 
            this.tbConfSenhaUsr.Location = new System.Drawing.Point(162, 153);
            this.tbConfSenhaUsr.Name = "tbConfSenhaUsr";
            this.tbConfSenhaUsr.PasswordChar = '●';
            this.tbConfSenhaUsr.Size = new System.Drawing.Size(153, 20);
            this.tbConfSenhaUsr.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(19, 115);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 15);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // tbSenhaUsr
            // 
            this.tbSenhaUsr.Location = new System.Drawing.Point(162, 115);
            this.tbSenhaUsr.Name = "tbSenhaUsr";
            this.tbSenhaUsr.PasswordChar = '●';
            this.tbSenhaUsr.Size = new System.Drawing.Size(153, 20);
            this.tbSenhaUsr.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirme a senha:";
            // 
            // tbLoginUsr
            // 
            this.tbLoginUsr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbLoginUsr.Location = new System.Drawing.Point(162, 79);
            this.tbLoginUsr.Name = "tbLoginUsr";
            this.tbLoginUsr.Size = new System.Drawing.Size(153, 20);
            this.tbLoginUsr.TabIndex = 0;
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tpUsuarios);
            this.tabPages.Controls.Add(this.tpPessoas);
            this.tabPages.Controls.Add(this.tpPapeis);
            this.tabPages.Location = new System.Drawing.Point(0, 70);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(1584, 646);
            this.tabPages.TabIndex = 4;
            // 
            // tpPapeis
            // 
            this.tpPapeis.Location = new System.Drawing.Point(4, 22);
            this.tpPapeis.Name = "tpPapeis";
            this.tpPapeis.Padding = new System.Windows.Forms.Padding(3);
            this.tpPapeis.Size = new System.Drawing.Size(1576, 620);
            this.tpPapeis.TabIndex = 2;
            this.tpPapeis.Text = "Papéis";
            this.tpPapeis.UseVisualStyleBackColor = true;
            // 
            // lblNomePessoa
            // 
            this.lblNomePessoa.AutoSize = true;
            this.lblNomePessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePessoa.Location = new System.Drawing.Point(29, 35);
            this.lblNomePessoa.Name = "lblNomePessoa";
            this.lblNomePessoa.Size = new System.Drawing.Size(112, 15);
            this.lblNomePessoa.TabIndex = 0;
            this.lblNomePessoa.Text = "Nome completo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome completo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nome completo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nome completo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nome completo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(348, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(32, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(348, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(32, 263);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(348, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(32, 330);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(348, 20);
            this.textBox5.TabIndex = 9;
            // 
            // btnSalvarPessoa
            // 
            this.btnSalvarPessoa.Location = new System.Drawing.Point(1202, 536);
            this.btnSalvarPessoa.Name = "btnSalvarPessoa";
            this.btnSalvarPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPessoa.TabIndex = 10;
            this.btnSalvarPessoa.Text = "Salvar";
            this.btnSalvarPessoa.UseVisualStyleBackColor = true;
            // 
            // btnSairPessoa
            // 
            this.btnSairPessoa.Location = new System.Drawing.Point(1093, 536);
            this.btnSairPessoa.Name = "btnSairPessoa";
            this.btnSairPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnSairPessoa.TabIndex = 11;
            this.btnSairPessoa.Text = "Sair";
            this.btnSairPessoa.UseVisualStyleBackColor = true;
            this.btnSairPessoa.Click += new System.EventHandler(this.btnSairPessoa_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.Text = "BMI - Body Mass Index (for school)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.tpPessoas.ResumeLayout(false);
            this.tpPessoas.PerformLayout();
            this.tpUsuarios.ResumeLayout(false);
            this.tpUsuarios.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUsuários;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem papéisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sériesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeDeVisãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLblData;
        private System.Windows.Forms.ToolStripStatusLabel tsLblUsr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.TabPage tpPessoas;
        private System.Windows.Forms.TabPage tpUsuarios;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TextBox tbNomeUsr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbConfSenhaUsr;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSenhaUsr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLoginUsr;
        private System.Windows.Forms.Button btnSalvarUsr;
        private System.Windows.Forms.Button btnSairUsr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioUsrInativo;
        private System.Windows.Forms.RadioButton radioUsrAtivo;
        private System.Windows.Forms.ComboBox cbNvlUsr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdUsr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPesqUsr;
        private System.Windows.Forms.Button btnAlterUsr;
        private System.Windows.Forms.Button btnNovoUsr;
        private System.Windows.Forms.TabPage tpPapeis;
        private System.Windows.Forms.Button btnCancelarCad;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNomePessoa;
        private System.Windows.Forms.Button btnSairPessoa;
        private System.Windows.Forms.Button btnSalvarPessoa;
    }
}