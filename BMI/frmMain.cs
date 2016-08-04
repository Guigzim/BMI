using System;
using System.Collections.Generic;
using System.Collections;
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

    public partial class frmMain : Form
    {
        static bool NovoUsr = false;
        static bool AlteraUsr = false;


        public frmMain(string _User)
        {
            InitializeComponent();

            lblCurrentUser.Text = _User;

            tsLblUsr.Text = "   |    Usuário: " + _User;

            disableAllTabPages();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o programa?\n\nTodos os trabalhos não salvos serão perdidos.", "Mensagem",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }
        //Desablito todas as abas e tabControl na inicialização ou caso feche a ultima aba
        private void disableAllTabPages()
        {
            tabPages.Hide();
            tabPages.TabPages.Remove(tpUsuarios);
            tabPages.TabPages.Remove(tpPessoas);
            tabPages.TabPages.Remove(tpPapeis);
            
        }
        private void menuBtnSair_Click(object sender, EventArgs e)
        {
            if (tabPages.TabCount > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja fechar todas as abas abertas e sair do sistema?\n\nTodos os trabalhos não salvos serão perdidos.",
                "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Lembrar de dar rollback em tudo e fechar conexao com db
                    disableAllTabPages();
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja sair do sistema?\n\nTodos os trabalhos não salvos serão perdidos.",
    "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Lembrar de dar rollback em tudo e fechar conexao com db
                    this.Close();
                }

            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            string _hour = DateTime.Now.ToLongTimeString();
            string _date = DateTime.Now.ToLongDateString();
            tsLblData.Text = "Data: " + _date + "   |   Hora: " + _hour;
        }

        private void papéisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPages.TabPages.Add(tpPapeis);
            tabPages.SelectedTab = tpPapeis;
            tabPages.Show();            
        }

        private void escolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPages.TabPages.Add(tpPessoas);
            tabPages.Show();
        }

        private void sériesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPages.TabPages.Add(tpPessoas);
            tabPages.Show();
            tabPages.SelectedTab = tpPessoas;
        }

        //Código da Tab Users
        #region
        //Inicio da region TabUsers
        private void menuUsuários_Click(object sender, EventArgs e)
        {
            tabPages.TabPages.Add(tpUsuarios);
            tabPages.SelectedTab = tpUsuarios;
            tabPages.Show();
            
            DisableFieldsUsr();
            btnPesqUsr.Enabled = true;
            btnNovoUsr.Enabled = true;
        }
        private void DisableFieldsUsr()
        {
            btnAlterUsr.Enabled = false;
            btnSalvarUsr.Enabled = false;
            tbIdUsr.Enabled = false;
            tbIdUsr.Clear();
            tbLoginUsr.Enabled = false;
            tbLoginUsr.Clear();
            tbSenhaUsr.Enabled = false;
            tbSenhaUsr.Clear();
            tbConfSenhaUsr.Enabled = false;
            tbConfSenhaUsr.Clear();
            tbNomeUsr.Enabled = false;
            tbNomeUsr.Clear();
            cbNvlUsr.Enabled = false;
            cbNvlUsr.Text = " ";
            radioUsrAtivo.Enabled = false;
            radioUsrAtivo.Checked = false;
            radioUsrInativo.Enabled = false;
            radioUsrInativo.Checked = false;
            btnCancelarCad.Enabled = false;

            cbNvlUsr.Items.Remove("Nível 1");
            cbNvlUsr.Items.Remove("Nível 2");
            cbNvlUsr.Items.Remove("Nível 3");
            cbNvlUsr.Items.Remove("Nível 4");
            cbNvlUsr.Items.Remove("Nível 5");

        }
        private void EnableFieldsUsr()
        {
            btnAlterUsr.Enabled = true;
            btnSalvarUsr.Enabled = true;
            tbIdUsr.Enabled = false;
            tbLoginUsr.Enabled = true;
            tbSenhaUsr.Enabled = true;
            tbConfSenhaUsr.Enabled = true;
            tbNomeUsr.Enabled = true;
            cbNvlUsr.Enabled = true;
            radioUsrAtivo.Enabled = true;
            radioUsrInativo.Enabled = true;
            btnCancelarCad.Enabled = true;

            cbNvlUsr.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void ClearAllFields()
        {
            tbIdUsr.Clear();
            tbLoginUsr.Clear();
            tbSenhaUsr.Clear();
            tbConfSenhaUsr.Clear();
            tbNomeUsr.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do cadastro de usuários?\n\nTodas as alterações não salvas serão perdidas.", "Mensagem",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tabPages.TabPages.Remove(tpUsuarios);

                if (tabPages.TabCount < 1)
                {
                    disableAllTabPages();
                }
            }
        }

        //Defino uma variavel estática para poder receber o valor atual do usuário selecionado.
        static int _PesqUsr;
        public frmMain(int _UsrPesq)
        {
            _PesqUsr = _UsrPesq;
        }

        public void recebeUsr()
        {
            if (_PesqUsr != 0)
            {
                try
                {
                    int idUsuario = _PesqUsr;
                    tbIdUsr.Text = Convert.ToString(idUsuario);
                    btnAlterUsr.Enabled = true;
                    btnNovoUsr.Enabled = false;
                    btnCancelarCad.Enabled = false;

                    MySqlConnection conexao = null;
                    string strCon = "server=localhost;user id=root;database=bmi; password=d3v3l0p";
                    conexao = new MySqlConnection(strCon);
                    string _SqlRecebeLogin = string.Empty;
                    string _SqlRecebeSenha = string.Empty;
                    string _SqlRecebeNome = string.Empty;
                    string _SqlRecebeNvl = string.Empty;
                    string _SqlRecebeStatus = string.Empty;



                    _SqlRecebeLogin = @"SELECT USR_LOGIN FROM BMI.USR WHERE ID_USR = @codigousr";
                    _SqlRecebeSenha = @"SELECT USR_SENHA FROM BMI.USR WHERE ID_USR = @codigousr";
                    _SqlRecebeNome = @"SELECT USR_NOME FROM BMI.USR WHERE ID_USR = @codigousr";
                    _SqlRecebeNvl = @"SELECT USR_NIVEL FROM BMI.USR WHERE ID_USR = @codigousr";
                    _SqlRecebeStatus = @"SELECT USR_STATUS FROM BMI.USR WHERE ID_USR = @codigousr";

                    MySqlCommand _RecebeLogin = new MySqlCommand(_SqlRecebeLogin, conexao);
                    MySqlCommand _RecebeSenha = new MySqlCommand(_SqlRecebeSenha, conexao);
                    MySqlCommand _RecebeNome = new MySqlCommand(_SqlRecebeNome, conexao);
                    MySqlCommand _RecebeNvl = new MySqlCommand(_SqlRecebeNvl, conexao);
                    MySqlCommand _RecebeStatus = new MySqlCommand(_SqlRecebeStatus, conexao);

                    _RecebeLogin.Parameters.Add("@codigousr", MySqlDbType.Int16).Value = idUsuario;
                    _RecebeSenha.Parameters.Add("@codigousr", MySqlDbType.Int16).Value = idUsuario;
                    _RecebeNome.Parameters.Add("@codigousr", MySqlDbType.Int16).Value = idUsuario;
                    _RecebeNvl.Parameters.Add("@codigousr", MySqlDbType.Int16).Value = idUsuario;
                    _RecebeStatus.Parameters.Add("@codigousr", MySqlDbType.Int16).Value = idUsuario;

                    conexao.Open();

                    string LoginUsr = _RecebeLogin.ExecuteScalar().ToString();
                    string SenhaUsr = _RecebeSenha.ExecuteScalar().ToString();
                    string NomeUsr = _RecebeNome.ExecuteScalar().ToString();
                    string NvlUsr = _RecebeNvl.ExecuteScalar().ToString();
                    string StatusUsr = _RecebeStatus.ExecuteScalar().ToString();

                    conexao.Close();

                    tbLoginUsr.Text = LoginUsr;
                    tbSenhaUsr.Text = SenhaUsr;
                    tbConfSenhaUsr.Text = SenhaUsr;
                    tbNomeUsr.Text = NomeUsr;

                    if (NvlUsr == "1")
                    {
                        cbNvlUsr.SelectedIndex = 0;
                    }
                    else if (NvlUsr == "2")
                    {
                        cbNvlUsr.SelectedIndex = 1;
                    }
                    else if (NvlUsr == "3")
                    {
                        cbNvlUsr.SelectedIndex = 2;
                    }
                    else if (NvlUsr == "4")
                    {
                        cbNvlUsr.SelectedIndex = 3;
                    }
                    else if (NvlUsr == "5")
                    {
                        cbNvlUsr.SelectedIndex = 4;
                    }
                    else
                    {
                        MessageBox.Show("Nível de acesso não identificado. Favor alterar o cadastro do usuário e selecionar um nível de acesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (StatusUsr == "A")
                    {
                        radioUsrAtivo.Checked = true;
                        radioUsrInativo.Checked = false;
                    }
                    else if (StatusUsr == "I")
                    {
                        radioUsrInativo.Checked = true;
                        radioUsrAtivo.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.");
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ocorreu uma exceção ao executar a consulta do usuário. \nCódigo e mensagem do erro a seguir:\n\n" + erro, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }


        private void btnPesqUsr_Click(object sender, EventArgs e)
        {
            cbNvlUsr.Items.Add("Nível 1");
            cbNvlUsr.Items.Add("Nível 2");
            cbNvlUsr.Items.Add("Nível 3");
            cbNvlUsr.Items.Add("Nível 4");
            cbNvlUsr.Items.Add("Nível 5");

            usrPesquisa Pesquisa = new usrPesquisa();
            Pesquisa.ShowDialog();

            recebeUsr();

        }

        private void btnNovoUsr_Click(object sender, EventArgs e)
        {
            NovoUsr = true;
            AlteraUsr = false;

            EnableFieldsUsr();


            cbNvlUsr.Items.Add("Nível 1");
            cbNvlUsr.Items.Add("Nível 2");
            cbNvlUsr.Items.Add("Nível 3");
            cbNvlUsr.Items.Add("Nível 4");
            cbNvlUsr.Items.Add("Nível 5");
            btnNovoUsr.Enabled = false;
            btnPesqUsr.Enabled = false;
            btnAlterUsr.Enabled = false;
            radioUsrAtivo.Checked = true;

            try
            {
                MySqlConnection conexao = null;
                string strCon = "server=localhost;user id=root;database=bmi; password=d3v3l0p";
                conexao = new MySqlConnection(strCon);
                string _Sql = string.Empty;
                

                _Sql = @"SELECT MAX(ID_USR) FROM BMI.USR";
                MySqlCommand _retCodUsr = new MySqlCommand(_Sql, conexao);

                conexao.Open();

                MySqlDataReader reader = _retCodUsr.ExecuteReader();

                string _codUsr = String.Empty;

                while (reader.Read())
                {
                    _codUsr = reader.GetString(0);
                }
                conexao.Close();

                int _convertCodUsr = Convert.ToInt16(_codUsr);
                int _somaCodUsr = _convertCodUsr + 1;


                tbIdUsr.Text = Convert.ToString(_somaCodUsr);
                tbLoginUsr.Focus();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro não esperado. \nErro: \n\n" + erro, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnSalvarUsr.Enabled = true;

        }

        private void btnCancelarCad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar o cadastro de usuários?\n\nTodas as alterações não salvas serão perdidas.", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DisableFieldsUsr();
                btnNovoUsr.Enabled = true;
                btnPesqUsr.Enabled = true;
            }
        }

        private void btnAlterUsr_Click(object sender, EventArgs e)
        {
            AlteraUsr = true;
            NovoUsr = false;

            EnableFieldsUsr();


            tbLoginUsr.Enabled = false;
            btnAlterUsr.Enabled = false;
            btnNovoUsr.Enabled = false;
            btnPesqUsr.Enabled = false;

        }
        private void btnSalvarUsr_Click(object sender, EventArgs e)
        {

            if (NovoUsr == true && AlteraUsr == false)
            {
                bool camposOk = false;
                int idUsr = Convert.ToInt16(tbIdUsr.Text);
                string loginUsr = tbLoginUsr.Text;
                string senhaUsr = tbSenhaUsr.Text;
                string confSenhaUsr = tbConfSenhaUsr.Text;
                string nomeUsr = tbNomeUsr.Text;
                int nvlUsr = 0;

                if (cbNvlUsr.SelectedItem == "Nível 1")
                {
                    nvlUsr = 1;
                }
                else if (cbNvlUsr.SelectedItem == "Nível 2")
                {
                    nvlUsr = 2;
                }
                else if (cbNvlUsr.SelectedItem == "Nível 3")
                {
                    nvlUsr = 3;
                }
                else if (cbNvlUsr.SelectedItem == "Nível 4")
                {
                    nvlUsr = 4;
                }
                else if (cbNvlUsr.SelectedItem == "Nível 5")
                {
                    nvlUsr = 5;
                }


                if (loginUsr == string.Empty)
                {
                    MessageBox.Show("Você precisa preencher o login para o usuário " + idUsr, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    camposOk = false;

                }
                else if (senhaUsr == string.Empty)
                {
                    MessageBox.Show("Você precisa preencher a senha para o usuário " + idUsr + " " + loginUsr, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    camposOk = false;
                }
                else if (confSenhaUsr == string.Empty)
                {
                    MessageBox.Show("Você precisa preencher a confirmação da senha para o usuário " + idUsr + " " + loginUsr, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    camposOk = false;
                }
                else if (nomeUsr == string.Empty)
                {
                    MessageBox.Show("Você precisa preencher o nome para o usuário " + idUsr + " " + loginUsr, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    camposOk = false;
                }
                else if (nvlUsr == 0)
                {
                    MessageBox.Show("Você precisa preencher um nível de acesso para o usuário " + idUsr + " " + loginUsr, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    camposOk = false;
                }
                else if (senhaUsr != confSenhaUsr)
                {
                    MessageBox.Show("As senhas digitadas não coincidem para o usuário " + idUsr + " " + loginUsr, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    camposOk = false;
                }
                else if (radioUsrInativo.Checked == true)
                {
                    if (MessageBox.Show("Notamos que o status selecionado para o usuário está como INATIVO.\n\nDeseja realmente inativar o usuário " + idUsr + " " + loginUsr + "?", "Messagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        radioUsrInativo.Checked = true;
                        radioUsrAtivo.Checked = false;
                    }
                    else
                    {
                        radioUsrAtivo.Checked = true;
                        radioUsrInativo.Checked = false;
                    }

                    camposOk = true;
                }
                else
                {
                    camposOk = true;
                }


                if (camposOk == true)
                {


                    try
                    {
                        MySqlConnection conexao = null;
                        string strCon = "server=localhost;user id=root;database=bmi; password=d3v3l0p";
                        conexao = new MySqlConnection(strCon);
                        string _Sql = string.Empty;
                        string _SqlGravaUsr = string.Empty;
                        
                        string status = string.Empty;

                        if (radioUsrAtivo.Checked == true)
                        {
                            status = "A";
                        }
                        else
                        {
                            status = "I";
                        }

                        _Sql = @"SELECT COUNT(ID_USR) FROM USR WHERE USR_LOGIN = @usuario";

                        MySqlCommand confUsr = new MySqlCommand(_Sql, conexao);

                        confUsr.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = loginUsr;

                        conexao.Open();

                        int count = (int)(long)confUsr.ExecuteScalar();

                        conexao.Close();

                        if (count > 0)
                        {
                            MessageBox.Show("Já existe um cadastro para o usuário " + loginUsr + ".\n\nDigite outro nome de usuário.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            try
                            {

                                _SqlGravaUsr = @"START TRANSACTION; INSERT INTO BMI.USR VALUES (@id,@usuario,@senha,@nome,@nivel,@status); COMMIT;";
                                MySqlCommand gravaUsr = new MySqlCommand(_SqlGravaUsr, conexao);
                                gravaUsr.Parameters.Add("@id", MySqlDbType.Int16).Value = idUsr;
                                gravaUsr.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = loginUsr;
                                gravaUsr.Parameters.Add("@senha", MySqlDbType.VarChar).Value = senhaUsr;
                                gravaUsr.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nomeUsr;
                                gravaUsr.Parameters.Add("@nivel", MySqlDbType.Int16).Value = nvlUsr;
                                gravaUsr.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;

                                conexao.Open();

                                gravaUsr.ExecuteNonQuery();

                                conexao.Close();

                                MessageBox.Show("Usuário " + nomeUsr + " cadastrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                DisableFieldsUsr();
                                btnNovoUsr.Enabled = true;
                                btnPesqUsr.Enabled = true;


                            }
                            catch (Exception erro)
                            {
                                MessageBox.Show("Ocorreu algum erro durante a gravação do usuário. \n\nTente novamente." + erro);
                            }
                        }

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Ocorreu um erro durante a consulta do usuário: " + erro);
                    }
                }
            }
            else if (AlteraUsr == true && NovoUsr == false)
            {
                bool camposOk = false;
                string idUsr = tbIdUsr.Text;
                string loginUsr = tbLoginUsr.Text;
                string nomeUsr = tbNomeUsr.Text;
                string senhaUsr = tbSenhaUsr.Text;
                string confSenhaUsr = tbConfSenhaUsr.Text;
                int nvlUsr = cbNvlUsr.SelectedIndex;

                if (cbNvlUsr.SelectedIndex == 0)
                {
                    nvlUsr = 1;
                }
                else if (cbNvlUsr.SelectedIndex == 1)
                {
                    nvlUsr = 2;
                }
                else if (cbNvlUsr.SelectedIndex == 2)
                {
                    nvlUsr = 3;
                }
                else if (cbNvlUsr.SelectedIndex == 3)
                {
                    nvlUsr = 4;
                }
                else if (cbNvlUsr.SelectedIndex == 4)
                {
                    nvlUsr = 5;
                }


                if (senhaUsr == string.Empty)
                {
                    MessageBox.Show("Você precisa preencher a senha para o usuário " + idUsr + " " + loginUsr, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    camposOk = false;
                }
                else if (confSenhaUsr == string.Empty)
                {
                    MessageBox.Show("Você precisa preencher a confirmação da senha para o usuário " + idUsr + " " + loginUsr, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    camposOk = false;
                }
                else if (nomeUsr == string.Empty)
                {
                    MessageBox.Show("Você precisa preencher o nome para o usuário " + idUsr + " " + loginUsr, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    camposOk = false;
                }
                else if (nvlUsr == 0)
                {
                    MessageBox.Show("Você precisa preencher um nível de acesso para o usuário " + idUsr + " " + loginUsr, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    camposOk = false;
                }
                else if (senhaUsr != confSenhaUsr)
                {
                    MessageBox.Show("As senhas digitadas não coincidem para o usuário " + idUsr + " " + loginUsr, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    camposOk = false;
                    tbSenhaUsr.Clear();
                    tbConfSenhaUsr.Clear();
                }
                else if (radioUsrInativo.Checked == true)
                {
                    if (MessageBox.Show("Notamos que o status selecionado para o usuário está como INATIVO.\n\nDeseja realmente inativar o usuário " + idUsr + " " + loginUsr + "?", "Messagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        radioUsrInativo.Checked = true;
                        radioUsrAtivo.Checked = false;
                    }
                    else
                    {
                        radioUsrAtivo.Checked = true;
                        radioUsrInativo.Checked = false;
                    }

                    camposOk = true;
                }
                else
                {
                    camposOk = true;
                }


                if (camposOk == true)
                {


                    try
                    {
                        string _SqlUpdateUsr = string.Empty;
                        

                        string status = string.Empty;

                        if (radioUsrAtivo.Checked == true)
                        {
                            status = "A";
                        }
                        else
                        {
                            status = "I";
                        }

                        try
                        {
                            MySqlConnection conexao = null;
                            string strCon = "server=localhost;user id=root;database=bmi; password=d3v3l0p";
                            conexao = new MySqlConnection(strCon);
                            _SqlUpdateUsr = @"START TRANSACTION; 
                                                        UPDATE BMI.USR 
                                                            SET USR_SENHA=@senha, 
                                                                USR_NOME=@nome,
                                                                USR_NIVEL=@nivel,
                                                                USR_STATUS=@status
                                                        WHERE ID_USR=@id;
                                                      COMMIT;";
                            MySqlCommand alteraUsr = new MySqlCommand(_SqlUpdateUsr, conexao);
                            alteraUsr.Parameters.Add("@id", MySqlDbType.Int16).Value = idUsr;
                            alteraUsr.Parameters.Add("@senha", MySqlDbType.VarChar).Value = senhaUsr;
                            alteraUsr.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nomeUsr;
                            alteraUsr.Parameters.Add("@nivel", MySqlDbType.Int16).Value = nvlUsr;
                            alteraUsr.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;

                            conexao.Open();

                            alteraUsr.ExecuteNonQuery();

                            conexao.Close();

                            MessageBox.Show("Usuário " + nomeUsr + " alterado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DisableFieldsUsr();
                            btnNovoUsr.Enabled = true;
                            btnPesqUsr.Enabled = true;
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Ocorreu algum erro durante a gravação do usuário. \n\nTente novamente." + erro);
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Ocorreu um erro durante a consulta do usuário: " + erro);
                    }
                }
            }
        }
        //Fim da region TabUsers
        #endregion
        

        //Inicio da region TabPessoas
        #region
        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPages.TabPages.Add(tpPessoas);
            tabPages.SelectedTab = tpPessoas;
            tabPages.Show();
        }
        private void btnSairPessoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do cadastro de usuários?\n\nTodas as alterações não salvas serão perdidas.", "Mensagem",
MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tabPages.TabPages.Remove(tpPessoas);

                if (tabPages.TabCount < 1)
                {
                    disableAllTabPages();
                }
            }
        }
        #endregion
        //Fim da region TabPessoas
    }
}
   

