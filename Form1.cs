using Cliente_WebService.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cliente_WebService
{
    public partial class Form1 : Form
    {
        ContratoServidorClient contratoServidorClient;
        public Form1()
        {
            InitializeComponent();
            EnviaStr_Text.Focus();
        }

        private void enviaStr_Click(object sender, EventArgs e)
        {
            contratoServidorClient = new ContratoServidorClient();
            string textTemp = EnviaStr_Text.Text;
            if (string.IsNullOrEmpty(EnviaStr_Text.Text))
                MessageBox.Show("Nada foi digitado!!","Erro!",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            contratoServidorClient.EnviaStrToServidor(textTemp);
            contratoServidorClient.Close();
        }

        private void recebeStr_Click(object sender, EventArgs e)
        {
            contratoServidorClient = new ContratoServidorClient();
            RecebeStr_Text.Text = contratoServidorClient.PegaStrFromServidor();
            contratoServidorClient.Close();
            limpar_Button.Visible = true;
        }

        private void limpar_Button_Click(object sender, EventArgs e)
        {
            RecebeStr_Text.Clear();
            limpar_Button.Visible=false;
        }
    }
}
