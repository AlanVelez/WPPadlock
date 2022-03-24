using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WAFPProyectoFinal
{
    public partial class FormDidactico : Form
    {
        Random rd = new Random();
        String mayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        String minusculas = "abcdefghijklmnopqrstuvwxyz";
        String numeros = "0123456789";
        String simbolos = "!@#$%^&";
        String contraseñaAleatoria = "";

        bool clickBorde = false;

        public FormDidactico()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            generador();
        }

        private void generador()
        {
            String opciones = string.Empty;
          
            if (chckMayus.Checked)
            {
                opciones += mayusculas;
            }
            if (chckMinu.Checked)
            {
                opciones += minusculas;
            }
            if (chckNum.Checked)
            {
                opciones += numeros;
            }
            if (chckSim.Checked)
            {
                opciones += simbolos;
            }

            String cadenaValida = txtCantCaracteres.Text;
            cadenaValida = cadenaValida.Replace(" ", String.Empty);

            int longuitud = int.Parse(cadenaValida);
            String contraseña = "";
            char caracter;

            for (int i = 0; i < longuitud; i++)
            {
                caracter = opciones[rd.Next(opciones.Length)];
                contraseña += caracter;
            }
            txtContraGenerada.Text = contraseña;
            contraseñaAleatoria = contraseña;

            if (contraseña.Length>13 && chckNum.Checked && chckSim.Checked && (chckMayus.Checked || chckMinu.Checked)) {
              
                tipoContra("garrapata.png", "Fuerte", 3, 181, 77);


            }
            else if (contraseña.Length > 7  && (chckNum.Checked || chckSim.Checked))
            {
                tipoContra("alerta.png", "Buena", 245, 183, 0);
            }
            else
            {
                tipoContra("cruzar.png", "Debil", 222, 26, 26);

            }
        }

        private void btnGenerarIcon_Click(object sender, EventArgs e)
        {
            generador();
        }

        private void tipoContra(String ruta, String clasif, int primero, int segundo, int tercero)
        {
            pctTipo.Image = Image.FromFile(ruta);
            lblTipo.Text = clasif;
            lblTipo.ForeColor = Color.FromArgb(primero, segundo, tercero);
            pctTipo.Visible = true;
            lblTipo.Visible = true;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(contraseñaAleatoria);
            MessageBox.Show("La contraseña a sido copiada con exito!");
        }

        private void pnlNavegacion_MouseDown(object sender, MouseEventArgs e)
        {
            clickBorde = true;
        }

        private void pnlNavegacion_MouseMove(object sender, MouseEventArgs e)
        {
            if (clickBorde)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pnlNavegacion_MouseUp(object sender, MouseEventArgs e)
        {
            clickBorde=false;
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
    }
}
