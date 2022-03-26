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
        bool click_borde = false;

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
            String[] diapositivas = { "NuevaPresentacion1.jpg",
                                      "NuevaPresentacion2.jpg",
                                      "NuevaPresentacion3.jpg",
                                      "NuevaPresentacion4.jpg",
                                      "NuevaPresentacion5.jpg",
                                      "NuevaPresentacion6.jpg"};

            if(i> 4){i = 0;}

            if (i < 0){i = 4;}

            pctDiapositiva.Image = Image.FromFile(diapositivas[i]);
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
                    lbltip.Text = "¡No utilices la misma contraseña en tus cuentas!";
                    break;
                case 2:
                    lbltip.Text = "¡Conectarte a redes publicas con VPN podria salvar tus datos!";
                    break;
                case 3:
                    lbltip.Text = "¡Revisa las actualizaciones de tu sistema!";
                    break;
                case 4:
                    lbltip.Text = "¡Utiliza un antivirus!";
                    break;
                case 5:
                    lbltip.Text = "¡Utiliza solo paginas con el protocolo Https!";
                    break;
            }
        }

        private void btnAdelante_Click_1(object sender, EventArgs e)
        {
            i++;

            botonesPrincipales();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;

            botonesPrincipales();
        }

        private void btnTip_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            int frase = random.Next(1, 6);
            switch (frase)
            {
                case 1:
                    lbltip.Text = "¡No utilices la misma contraseña en tus cuentas!";
                    break;
                case 2:
                    lbltip.Text = "¡Conectarte a redes publicas con VPN podria salvar tus datos!";
                    break;
                case 3:
                    lbltip.Text = "¡Revisa las actualizaciones de tu sistema!";
                    break;
                case 4:
                    lbltip.Text = "¡Utiliza un antivirus!";
                    break;
                case 5:
                    lbltip.Text = "¡Utiliza solo paginas con el protocolo Https!";
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnMaximizar.BackgroundImage = Image.FromFile("maximizar.png");
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                btnMaximizar.BackgroundImage = Image.FromFile("maximizar2.png");

                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void pnlNavegacion_MouseDown(object sender, MouseEventArgs e)
        {
            click_borde = true;
        }

        private void pnlNavegacion_MouseMove(object sender, MouseEventArgs e)
        {
            if (click_borde)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pnlNavegacion_MouseUp(object sender, MouseEventArgs e)
        {
            click_borde=false;
        }
    }
}
