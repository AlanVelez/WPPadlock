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

        private void pctMemorama_Click(object sender, EventArgs e)
        {
            abrirMemorama();
        }

        private void lblTituloMemorama_Click(object sender, EventArgs e)
        {
            abrirMemorama();
        }

        private void lblTxtMemorama_Click(object sender, EventArgs e)
        {
            abrirMemorama();
        }

        private void pctInformate_Click(object sender, EventArgs e)
        {
            abrirInformate();
        }

        private void lblTituloInformate_Click(object sender, EventArgs e)
        {
            abrirInformate();
        }

        private void lblTxtInformate_Click(object sender, EventArgs e)
        {
            abrirInformate();
        }

        private void lblTituloGenerador_Click(object sender, EventArgs e)
        {
            abrirDidactico();
        }

        private void pctGenerador_Click(object sender, EventArgs e)
        {
            abrirDidactico();
        }

        private void lblTxtGenerador_Click(object sender, EventArgs e)
        {
            abrirDidactico();
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
        private void pctMemorama_MouseHover(object sender, EventArgs e)
        {
            hoverMemorama(lblTituloMemorama, lblTxtMemorama);
        }

        private void pctMemorama_MouseLeave(object sender, EventArgs e)
        {
            leaveMemorama(lblTituloMemorama, lblTxtMemorama);
        }

      
        private void lblTituloMemorama_MouseHover(object sender, EventArgs e)
        {
            hoverMemorama(lblTituloMemorama, lblTxtMemorama);
        }

        private void lblTxtMemorama_MouseHover(object sender, EventArgs e)
        {
            hoverMemorama(lblTituloMemorama, lblTxtMemorama);
        }

        private void lblTituloMemorama_MouseLeave(object sender, EventArgs e)
        {
            leaveMemorama(lblTituloMemorama, lblTxtMemorama);
        }

        private void lblTxtMemorama_MouseLeave(object sender, EventArgs e)
        {
            leaveMemorama(lblTituloMemorama, lblTxtMemorama);
        }

        //Boton Informate

        private void pctInformate_MouseHover(object sender, EventArgs e)
        {
            hoverMemorama(lblTituloInformate, lblTxtInformate);
        }

        private void lblTituloInformate_MouseHover(object sender, EventArgs e)
        {
            hoverMemorama(lblTituloInformate, lblTxtInformate);
        }
        private void pctInformate_MouseLeave(object sender, EventArgs e)
        {
            leaveMemorama(lblTituloInformate, lblTxtInformate);
        }

        //Boton Generador
        private void pctGenerador_MouseHover(object sender, EventArgs e)
        {
            hoverMemorama(lblTxtGenerador, lblTituloGenerador);

        }

        private void pctGenerador_MouseLeave(object sender, EventArgs e)
        {
            leaveMemorama(lblTituloGenerador, lblTxtGenerador);

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
            clickBorde = false;
        }

        private void pnlNavegacion_MouseDown(object sender, MouseEventArgs e)
        {
            clickBorde = true;
        }

        private void pnlNavegacion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
