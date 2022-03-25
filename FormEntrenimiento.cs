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


namespace WAFPProyectoFinal
{
    public partial class FormEntrenimiento : Form
    {
        bool click_borde = false;
        int tamañoColumnasFilas = 4;
        int Movimientos = 0;
        int cantidadCartasVolteadas = 0;
        List<string> cartasEnumeradas;
        List<string> cartasRevueeltas;
        ArrayList cartasSeleccionadas;
        PictureBox cartaTemporal1;
        PictureBox cartaTemporal2;
        int cartaActual = 0;

        public FormEntrenimiento()
        {
            InitializeComponent();
            iniciarJuego();

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
            click_borde = false;
        }

        public void iniciarJuego()
        {
            timer1.Enabled = false;
            timer1.Stop();
            lblRecord.Text = "0";
            cantidadCartasVolteadas = 0;
            Movimientos = 0;
            pnlJuego.Controls.Clear();
            cartasEnumeradas = new List<string>();
            cartasRevueeltas = new List<string>();
            cartasSeleccionadas = new ArrayList();
            for(int i =0; i< 8; i++)
            {
                cartasEnumeradas.Add(i.ToString());
                cartasEnumeradas.Add(i.ToString());

            }
            var NumeroAleatorio = new Random();
            var resultado = cartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());
            foreach (string valorCarta in resultado)
            {
                cartasRevueeltas.Add(valorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = tamañoColumnasFilas;
            tablaPanel.ColumnCount = tamañoColumnasFilas;
            for(int i =0; i< tamañoColumnasFilas; i++)
            {
                var porcentaje = 150f / (float)tamañoColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, porcentaje));
                tablaPanel.RowStyles .Add(new RowStyle (SizeType.Percent, porcentaje));
            }
            int contadorFichas = 1;

            for (int i = 0; i < tamañoColumnasFilas; i++)
            {
                for (int j = 0; j < tamañoColumnasFilas; j++)
                {
                    var cartasJuego = new PictureBox();
                    cartasJuego.Name = String.Format("{0}", contadorFichas);
                    cartasJuego.Dock = DockStyle.Fill;
                    cartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    cartasJuego.Image = Properties.Resources.cartaPrincipal;
                    cartasJuego.Cursor = Cursors.Hand;
                    cartasJuego.Click += btnCarta_Click;
                    tablaPanel.Controls.Add(cartasJuego, j, i);
                    contadorFichas++;
                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            pnlJuego.Controls.Add(tablaPanel);



        }
        private void btnNuevaPartida_Click(object sender, EventArgs e)
        {
            iniciarJuego();
        }
        private void btnCarta_Click(object sender, EventArgs e)
        {
            if (cartasSeleccionadas.Count < 2) { 
            Movimientos++;
            lblRecord.Text = Convert.ToString(Movimientos);
            var cartasSeleccionadasUsuario = (PictureBox)sender;

            cartaActual = Convert.ToInt32(cartasRevueeltas[Convert.ToInt32(cartasSeleccionadasUsuario.Name) - 1]);
            cartasSeleccionadasUsuario.Image = recuperarImagen(cartaActual);
            cartasSeleccionadas.Add(cartasSeleccionadasUsuario);
                //Recuerda dos veces se hizo el evento del click
                if(cartasSeleccionadas .Count == 2)
                {
                    cartaTemporal1 = (PictureBox)cartasSeleccionadas[0];
                    cartaTemporal2 = (PictureBox)cartasSeleccionadas[0];
                    int carta1 = Convert.ToInt32(cartasRevueeltas[Convert.ToInt32(cartaTemporal1.Name) - 1]);
                    int carta2 = Convert.ToInt32(cartasRevueeltas[Convert.ToInt32(cartaTemporal2.Name) - 1]);

                    if(carta1 != carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        cantidadCartasVolteadas++;
                        if (cantidadCartasVolteadas > 7)
                        {
                            MessageBox.Show("Eljuego termino");
                        }
                        cartaTemporal1.Enabled = false; cartaTemporal2.Enabled = false;
                        cartasSeleccionadas.Clear();
                    }

                }
            }
        }

        public Bitmap recuperarImagen(int numeroImagen)
        {
            Bitmap TmImg = new Bitmap(200, 100);
            switch (numeroImagen)
            {
                case 0: TmImg = Properties.Resources.carta11;
                    break;
                default: TmImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("carta" + numeroImagen);
                    break;
            }
            return TmImg;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int tiempoVirarCarta = 1;
            if (tiempoVirarCarta == 1)
            {
                cartaTemporal1.Image = Properties.Resources.cartaPrincipal;
                cartaTemporal2.Image = Properties.Resources.cartaPrincipal;
                cartasSeleccionadas.Clear();
                tiempoVirarCarta = 0;
                timer1.Stop();
            }
        }


    }
}
