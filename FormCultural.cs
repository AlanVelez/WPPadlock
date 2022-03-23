using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAFPProyectoFinal
{
    public partial class FormCultural : Form
    {
        int i = 0;

        public FormCultural()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void botonesPrincipales()
        {
            String[] diapositivas = { "Diapositiva1.png", 
                                      "Diapositiva2.png", 
                                      "Diapositiva3.png",
                                      "Diapositiva4.png",
                                      "Diapositiva5.png"};

            if(i> 4){i = 0;}

            if (i < 0){i = 4;}

            pctDiapo.Image = Image.FromFile(diapositivas[i]);
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            i++;

            botonesPrincipales();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            i--;

            botonesPrincipales();
        }

        private void btnTip_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int frase = random.Next(1,6);
            switch (frase)
            {
                case 1:
                    lblTip.Text = "¡No utilices la misma contraseña en tus cuentas!";
                    break;
                case 2:
                    lblTip.Text = "¡Conectarte a redes publicas con VPN podria salvar tus datos!";
                    break;
                case 3:
                    lblTip.Text = "¡Revisa las actualizaciones de tu sistema!";
                    break;
                case 4:
                    lblTip.Text = "¡Utiliza un antivirus!";
                    break;
                case 5:
                    lblTip.Text = "¡Utiliza solo paginas con el protocolo Https!";
                    break;
            }
        }
    }
}
