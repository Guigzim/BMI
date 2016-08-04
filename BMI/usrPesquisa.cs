using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BMI
{
    public partial class usrPesquisa : Form
    {
        MySqlConnection conexao = null;
        private string strCon = "server=localhost;user id=root;database=bmi; password=d3v3l0p";
        private string _Sql = string.Empty;
        private string _SqlCount = string.Empty;
        private string _SqlBlank = string.Empty;
        private string _SqlRetUsr = string.Empty;
        
               

        public usrPesquisa()
        {
            InitializeComponent();



            cbPesqUsr.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPesqUsr.SelectedText = "Selecione...";
            cbPesqUsr.Items.Add("Código");
            cbPesqUsr.Items.Add("Nome");
            
            
                        
      }
        
        private void btnPesqUsrCancela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a pesquisa?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPesqUsrPesq_Click(object sender, EventArgs e)
        {
            if (tbPesqUsr.Text == "")
            {
                try
                {
                conexao = new MySqlConnection(strCon);

                _SqlBlank = @"SELECT ID_USR CÓDIGO,USR_NOME NOME,USR_LOGIN LOGIN FROM USR";
                MySqlCommand blankUsr = new MySqlCommand(_SqlBlank, conexao);
                
                conexao.Open();

                MySqlDataAdapter adapterUsr = new MySqlDataAdapter();
                adapterUsr.SelectCommand = blankUsr;

                DataTable dbdataset = new DataTable();
                adapterUsr.Fill(dbdataset);

                BindingSource bsource = new BindingSource();
                
                dataGridView1.DataSource = bsource;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowDrop = false;
                
                bsource.DataSource = dbdataset;
                dbdataset.DefaultView.AllowNew = false;
                dbdataset.DefaultView.AllowDelete = false;
                dbdataset.DefaultView.AllowEdit = false;

                //dataGridView1.BackgroundColor = Color.LightGray;
                dataGridView1.BorderStyle = BorderStyle.Fixed3D;

                dataGridView1.AutoResizeColumns();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.AllowUserToOrderColumns = true;


                conexao.Close();
                }
                catch (MySqlException errorLog)
                {
                    MessageBox.Show(errorLog + "DB ErrorLog - Ocorreu algum erro na conexão com o banco de dados. Verifique suas configurações de conexão.");
                }
            }
            else
            {
                if (cbPesqUsr.SelectedItem == "Código")
                {
                    try
                    {
                        conexao = new MySqlConnection(strCon);
                    
                    
                        int codigo = Convert.ToInt32(tbPesqUsr.Text);

                        _SqlCount = @"SELECT COUNT(ID_USR) FROM USR WHERE ID_USR = @codigo";
                        MySqlCommand countUsr = new MySqlCommand(_SqlCount,conexao);
                        countUsr.Parameters.Add("@codigo",MySqlDbType.Int32).Value = codigo;

                        _Sql = @"SELECT ID_USR CÓDIGO,USR_NOME NOME,USR_LOGIN LOGIN FROM USR WHERE ID_USR = @codigo";
                        MySqlCommand pesqUsr = new MySqlCommand(_Sql, conexao);
                        pesqUsr.Parameters.Add("@codigo", MySqlDbType.Int32).Value = codigo;
                    
                        conexao.Open();

                        int count = (int)(long)countUsr.ExecuteScalar();

                        if (count > 0)
                        {
                            MySqlDataAdapter adapterUsr = new MySqlDataAdapter();
                            adapterUsr.SelectCommand = pesqUsr;

                            DataTable dbdataset = new DataTable();
                            adapterUsr.Fill(dbdataset);

                            BindingSource bsource = new BindingSource();

                            dataGridView1.ReadOnly = true;
                            dataGridView1.AllowDrop = false;

                            bsource.DataSource = dbdataset;
                            dbdataset.DefaultView.AllowNew = false;
                            dbdataset.DefaultView.AllowDelete = false;
                            dbdataset.DefaultView.AllowEdit = false;

                            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
                            dataGridView1.AutoResizeColumns();
                            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dataGridView1.MultiSelect = false;
                            dataGridView1.AllowUserToOrderColumns = true;

                            dataGridView1.DataSource = bsource;
                            conexao.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado com os parâmetros informados.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conexao.Close();
                        }
                    }
                    catch (MySqlException errorLog)
                    {
                        MessageBox.Show(errorLog + "DB ErrorLog - Ocorreu algum erro na conexão com o banco de dados. Verifique suas configurações de conexão.");
                    }
                }
                else if (cbPesqUsr.SelectedItem == "Nome")
                {
                    try
                    {
                        conexao = new MySqlConnection(strCon);
                    
                        string nome = tbPesqUsr.Text;

                        _SqlCount = @"SELECT COUNT(ID_USR) FROM USR WHERE USR_NOME LIKE @nome";
                        MySqlCommand countUsr = new MySqlCommand(_SqlCount, conexao);
                        countUsr.Parameters.Add("@nome", MySqlDbType.VarChar).Value = "%" + nome + "%";
                    
                        _Sql = @"SELECT ID_USR CÓDIGO,USR_NOME NOME,USR_LOGIN LOGIN FROM USR WHERE USR_NOME LIKE @nome ORDER BY ID_USR";
                        MySqlCommand pesqUsr = new MySqlCommand(_Sql, conexao);
                        pesqUsr.Parameters.Add("@nome", MySqlDbType.VarChar).Value ="%" + nome + "%";

                        conexao.Open();

                        int count = (int)(long)countUsr.ExecuteScalar();
                    

                        if (count > 0)
                        {
                            MySqlDataAdapter adapterUsr = new MySqlDataAdapter();
                            adapterUsr.SelectCommand = pesqUsr;

                            DataTable dbdataset = new DataTable();
                            adapterUsr.Fill(dbdataset);

                            BindingSource bsource = new BindingSource();
                            bsource.DataSource = dbdataset;


                            dataGridView1.ReadOnly = true;
                            dataGridView1.AllowDrop = false;
                            

                            bsource.DataSource = dbdataset;
                            dbdataset.DefaultView.AllowNew = false;
                            dbdataset.DefaultView.AllowDelete = false;
                            dbdataset.DefaultView.AllowEdit = false;

                            //dataGridView1.BackgroundColor = Color.LightGray;
                            dataGridView1.BorderStyle = BorderStyle.Fixed3D;

                            dataGridView1.AutoResizeColumns();
                            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dataGridView1.MultiSelect = false;
                            dataGridView1.AllowUserToOrderColumns = true;

                            dataGridView1.DataSource = bsource;
                            conexao.Close();

                            int index = dataGridView1.SelectedCells[0].RowIndex;                           
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado com os parâmetros informados.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbPesqUsr.Focus();
                            conexao.Close();
                        }
                   }
                   catch (MySqlException errorLog)
                   {
                        MessageBox.Show(errorLog + "DB ErrorLog - Ocorreu algum erro na conexão com o banco de dados. Verifique suas configurações de conexão.");
                    }
                }
            }

        }

        public void btnPesqUsrOk_Click(object sender, EventArgs e)
        {

            int index = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            frmMain MainForm = new frmMain(index);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}


