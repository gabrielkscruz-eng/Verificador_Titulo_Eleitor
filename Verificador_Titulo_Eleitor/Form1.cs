using System;
using System.Windows.Forms;

namespace Verificador_Titulo_Eleitor
{
    public partial class Verificador_Eleitor : Form
    {
        public Verificador_Eleitor()
        {
            InitializeComponent();
            lbl_verifica.Visible = false;
        }

        private void Verificador_Eleitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quer sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (txt_titulo.TextLength > 0)
            {
                if (Verifica_titulo.Verificar_eleitor.Verificar(txt_titulo.Text) == true)
                {
                    lbl_verifica.Visible = true;
                    lbl_verifica.Text = "Seu titulo é verdadeiro";
                    txt_titulo.Clear();
                }
                else
                {
                    lbl_verifica.Visible = true;
                    lbl_verifica.Text = "Seu titulo é falso";
                    txt_titulo.Clear();
                }
            }
            else
                MessageBox.Show("Coloque informação na caixa");
        }
    }
}
