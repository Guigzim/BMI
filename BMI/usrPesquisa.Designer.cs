namespace BMI
{
    partial class usrPesquisa
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
            this.btnPesqUsrCancela = new System.Windows.Forms.Button();
            this.btnPesqUsrOk = new System.Windows.Forms.Button();
            this.btnPesqUsrPesq = new System.Windows.Forms.Button();
            this.tbPesqUsr = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbPesqUsr = new System.Windows.Forms.ComboBox();
            this.gbPesqUsr = new System.Windows.Forms.GroupBox();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbPesqUsr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesqUsrCancela
            // 
            this.btnPesqUsrCancela.Location = new System.Drawing.Point(629, 74);
            this.btnPesqUsrCancela.Name = "btnPesqUsrCancela";
            this.btnPesqUsrCancela.Size = new System.Drawing.Size(75, 23);
            this.btnPesqUsrCancela.TabIndex = 5;
            this.btnPesqUsrCancela.Text = "Cancelar";
            this.btnPesqUsrCancela.UseVisualStyleBackColor = true;
            this.btnPesqUsrCancela.Click += new System.EventHandler(this.btnPesqUsrCancela_Click);
            // 
            // btnPesqUsrOk
            // 
            this.btnPesqUsrOk.Location = new System.Drawing.Point(629, 34);
            this.btnPesqUsrOk.Name = "btnPesqUsrOk";
            this.btnPesqUsrOk.Size = new System.Drawing.Size(75, 23);
            this.btnPesqUsrOk.TabIndex = 4;
            this.btnPesqUsrOk.Text = "OK";
            this.btnPesqUsrOk.UseVisualStyleBackColor = true;
            this.btnPesqUsrOk.Click += new System.EventHandler(this.btnPesqUsrOk_Click);
            // 
            // btnPesqUsrPesq
            // 
            this.btnPesqUsrPesq.Location = new System.Drawing.Point(475, 28);
            this.btnPesqUsrPesq.Name = "btnPesqUsrPesq";
            this.btnPesqUsrPesq.Size = new System.Drawing.Size(75, 23);
            this.btnPesqUsrPesq.TabIndex = 2;
            this.btnPesqUsrPesq.Text = "Pesquisar";
            this.btnPesqUsrPesq.UseVisualStyleBackColor = true;
            this.btnPesqUsrPesq.Click += new System.EventHandler(this.btnPesqUsrPesq_Click);
            // 
            // tbPesqUsr
            // 
            this.tbPesqUsr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPesqUsr.Location = new System.Drawing.Point(145, 28);
            this.tbPesqUsr.Name = "tbPesqUsr";
            this.tbPesqUsr.Size = new System.Drawing.Size(320, 20);
            this.tbPesqUsr.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 170);
            this.dataGridView1.TabIndex = 3;
            // 
            // cbPesqUsr
            // 
            this.cbPesqUsr.FormattingEnabled = true;
            this.cbPesqUsr.Location = new System.Drawing.Point(12, 28);
            this.cbPesqUsr.Name = "cbPesqUsr";
            this.cbPesqUsr.Size = new System.Drawing.Size(121, 21);
            this.cbPesqUsr.TabIndex = 0;
            this.cbPesqUsr.Text = "Selecione...";
            // 
            // gbPesqUsr
            // 
            this.gbPesqUsr.BackColor = System.Drawing.Color.Transparent;
            this.gbPesqUsr.Controls.Add(this.cbPesqUsr);
            this.gbPesqUsr.Controls.Add(this.btnPesqUsrPesq);
            this.gbPesqUsr.Controls.Add(this.tbPesqUsr);
            this.gbPesqUsr.Location = new System.Drawing.Point(37, 34);
            this.gbPesqUsr.Name = "gbPesqUsr";
            this.gbPesqUsr.Size = new System.Drawing.Size(567, 87);
            this.gbPesqUsr.TabIndex = 9;
            this.gbPesqUsr.TabStop = false;
            this.gbPesqUsr.Text = "Selecione abaixo sua forma de pesquisa";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // usrPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(734, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPesqUsrOk);
            this.Controls.Add(this.btnPesqUsrCancela);
            this.Controls.Add(this.gbPesqUsr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usrPesquisa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbPesqUsr.ResumeLayout(false);
            this.gbPesqUsr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesqUsrCancela;
        private System.Windows.Forms.Button btnPesqUsrOk;
        private System.Windows.Forms.Button btnPesqUsrPesq;
        private System.Windows.Forms.TextBox tbPesqUsr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbPesqUsr;
        private System.Windows.Forms.GroupBox gbPesqUsr;
        private System.Data.DataSet dataSet1;
    }
}