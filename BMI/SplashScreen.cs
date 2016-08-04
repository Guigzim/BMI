using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        //Inicializo o timer para a barra de progresso
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBarSplash.Value < 100) 
            {
                progressBarSplash.Value = progressBarSplash.Value + 5; //Faço a contagem de 5 em 5 até 100% da barra
            }
            else
            {
                timer1.Enabled = false; //Quanddo chegar em 100 desativo o timer
                this.Visible = false;  //Deixo o form invisível

                FrmLogin Login = new FrmLogin(); //Instancio o Form de login
                Login.ShowDialog(); //Mostro o form de login
                
                this.Close(); //Fecho a Splash Screen
                
            }
        }
    }
}
