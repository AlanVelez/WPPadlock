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
    public partial class Form1 : Form
    {
        bool clickBorde = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirInformate()
        {
            FormCultural formCultural = new FormCultural();
            this.Hide();
            formCultural.Show();
        }

        private void abrirMemorama()
        {
            FormEntrenimiento formEntrenimiento = new FormEntrenimiento();
            this.Hide();
            formEntrenimiento.Show();
        }

        private void abrirDidactico()
        {
            FormDidactico formDidactico = new FormDidactico();

            this.Hide();
            formDidactico.Show();
        }

        //Minimizar ventana
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Evento Hover y Leave
        private void hoverMemorama(Label lbl, Label lbl2)
        {
            lbl.ForeColor = Color.Silver;
            lbl2.ForeColor = Color.Silver;
        }

        private void leaveMemorama(Label lbl, Label lbl2)
        {
            lbl.ForeColor = Color.White;
            lbl2.ForeColor = Color.White;

        }

        //Boton Memorama
      
            //hoverMemorama(lblTituloMemorama, lblTxtMemorama);
            //leaveMemorama(lblTituloMemorama, lblTxtMemorama);

      

        private void pnlNavegacion_MouseMove(object sender, MouseEventArgs e)
        {
            if (clickBorde)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pnlNavegacion_MouseUp(object sender, MouseEventArgs e)
        {
            clickBorde = false;
        }

        private void pnlNavegacion_MouseDown(object sender, MouseEventArgs e)
        {
            clickBorde = true;
        }


        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
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

        private void pctMemorama_Click(object sender, EventArgs e)
        {
            abrirMemorama();
        }

        private void pctInformate_Click(object sender, EventArgs e)
        {
            abrirInformate();
        }

        private void lblTituloGenerador_Click(object sender, EventArgs e)
        {
            abrirDidactico();
        }

        private void pctMemorama_MouseHover(object sender, EventArgs e)
        {
            hoverMemorama(lblTituloMemorama, lblTxtMemorama);
        }

        private void pctMemorama_MouseLeave(object sender, EventArgs e)
        {
            leaveMemorama(lblTxtMemorama, lblTituloMemorama);
        }

        private void pctInformate_MouseHover(object sender, EventArgs e)
        {
            hoverMemorama(lblTituloInformate, lblTxtInformate);
        }

        private void pctInformate_MouseLeave(object sender, EventArgs e)
        {
            leaveMemorama(lblTituloInformate, lblTxtInformate);
        }

        private void lblTituloGenerador_MouseHover(object sender, EventArgs e)
        {
            hoverMemorama(lblTituloGenerador, lblTxtGenerador);
        }

        private void lblTituloGenerador_MouseLeave(object sender, EventArgs e)
        {
            leaveMemorama(lblTituloGenerador, lblTxtGenerador);
        }
    }
}
