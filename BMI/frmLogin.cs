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
    public partial class FrmLogin : Form 
    {

        //Crio o objeto conexão
        MySqlConnection conexao = null; 
        //Passo pra uma stringas credenciais para conexão com o banco
        private string strCon = "server=localhost;user id=root;database=bmi; password=d3v3l0p"; 
        
        //Variável que vai receber minha querie que conta os usuários com base na consulta de usuário e senha
        private string _Sql = string.Empty;

        //Variável que vai receber a querie pra retorno do usuário que está logado
        private string _SqlReturn = string.Empty;
        
        //Variável bool que define se está logado ou não
        public bool logado = false;  

        //Variável que recebe o usuário logado para passar ao form principal
        public string _Usuario = string.Empty;

        //Inicializa o form
        public FrmLogin() 
        {
            InitializeComponent();
        }

        //Método que faz a verificação do usuário e senha digitados
        public void logar() 
        {
            //Instacio a conexão com o banco recebendo a string de conexão
            conexao = new MySqlConnection(strCon); 

            //Variáveis que recebem usuário e senha digitados
            string usr; 
            string pwd; 

            try
            { 
                //Variáveis recebem os valores
                usr = tbUsuario.Text;
                pwd = tbSenha.Text;

                //Variável recebe a querie que conta se existe usuário digitado, senha digitada e se status está ATIVO
                _Sql = @"SELECT COUNT(ID_USR) FROM USR WHERE USR_LOGIN = @usuario AND USR_SENHA = @senha AND USR_STATUS = 'A'";
                
                //Instancio a variável 
                MySqlCommand selUser = new MySqlCommand(_Sql,conexao);

                //Passo o valor das variáveis para parâmetros para receber na minha querie
                selUser.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = usr;
                selUser.Parameters.Add("@senha", MySqlDbType.VarChar).Value = pwd;

                //Abro a conexão com o banco
                conexao.Open();

                //Atribuo a contagem da minha querie à variável count
                int count = (int)(long)selUser.ExecuteScalar();

                //Se a contagem for maior que 0, ou seja, ENCONTRAR um usuário que atenda aos requisitos da querie
                if (count > 0)
                {
                    //Passo o valor de true para a minha variável logado
                    logado = true;
                    
                    //Fecho conexão com o banco
                    conexao.Close();

                    //Se receber true, monto a querie que vai retornar o nome completo do usuário logado
                    _SqlReturn = @"SELECT USR_NOME FROM USR WHERE USR_LOGIN = @usuario AND USR_SENHA = @senha";

                    //Passo a string de conexão e querie pra minha variável de execução
                    MySqlCommand _retUsuario = new MySqlCommand(_SqlReturn,conexao);

                    //Recebo os valores digitados em parametros para passar pra minha querie
                    _retUsuario.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = usr;
                    _retUsuario.Parameters.Add("@senha", MySqlDbType.VarChar).Value = pwd;

                    //Fecho a conexão com o banco
                    conexao.Open();

                    //Monto um data reader pra receber o retorno da querie
                    MySqlDataReader reader = _retUsuario.ExecuteReader();

                    //Faço um while pra receber o valor lido do usuário logado
                    while (reader.Read())
                    {
                        //Atribuo à variável o retorno que vou passar por parametro pro form principal
                        _Usuario = reader.GetString(0);
                    }

                    //Fecho o reader
                    reader.Close();
                    //Fecho a conexão com o banco
                    conexao.Close();
                    
                  
                }                    
                else
                {

                    //Se o resultado da contagem no banco com base no usuário, senha e status ATIVO for = 0
                    MessageBox.Show("Login não realizado.\n\nUsuário inexistente, inativo ou credenciais incorretas..", "Login não realizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Atribui a variavel de definição false
                    logado = false;
                    //Limpa o textBox da senha para nova tentativa
                    tbSenha.Clear();
                }

                //Valida se a variável recebeu true
                if (logado)
                {
                    //Instacio o form principal e passo o nome do usuário por parâmetro
                    frmMain Principal = new frmMain(_Usuario);
                    //Abro o form principal
                    Principal.ShowDialog();

                    //Limpo da memória a tela de login
                    this.Dispose();
                    //Fecho a tela de login
                    this.Close();
                }

            }
            catch (MySqlException errorLog)
            {
                //Capturo algum erro de conexão
                MessageBox.Show(errorLog + "DB ErrorLog - Ocorreu algum erro na conexão com o banco de dados. Verifique suas configurações de conexão.");
            }
        }

        //Faço validação se o usuário realmente deseja cancelar o login e sair do programa
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?",
                "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            //Caso a resposta seja sim, saio do programa.
            Application.Exit();
        }
        }

        //Se após a validação de usuário e senha e status de usuário, tudo estiver ok, loga no sistema
        private void btnOk_Click(object sender, EventArgs e)
        {
            //Chama funçao que loga no sistema
            logar();            
        }
        
        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logar();
            }
            else
            {
                if (e.KeyCode == Keys.Escape)
                {
                    if (MessageBox.Show("Tem certeza que deseja sair?",
                "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void tbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Tem certeza que deseja sair?",
                "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

     }
}
