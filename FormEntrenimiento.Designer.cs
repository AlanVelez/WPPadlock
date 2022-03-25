namespace WAFPProyectoFinal
{
    partial class FormEntrenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrenimiento));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctLogoGenerador = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnNuevaPartida = new System.Windows.Forms.Button();
            this.pctLogoDaga = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlJuego = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlNavegacion.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoGenerador)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoDaga)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegresar.BackgroundImage")));
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(13, 7);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(25, 22);
            this.btnRegresar.TabIndex = 25;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(2, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(97, 20);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Memorama";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(775, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 21);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(846, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 21);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.pnlNavegacion.Controls.Add(this.btnMaximizar);
            this.pnlNavegacion.Controls.Add(this.btnRegresar);
            this.pnlNavegacion.Controls.Add(this.btnMinimizar);
            this.pnlNavegacion.Controls.Add(this.btnCerrar);
            this.pnlNavegacion.Controls.Add(this.panel2);
            this.pnlNavegacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavegacion.Location = new System.Drawing.Point(0, 0);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(882, 36);
            this.pnlNavegacion.TabIndex = 21;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(810, 8);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 21);
            this.btnMaximizar.TabIndex = 26;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pctLogoGenerador);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Location = new System.Drawing.Point(373, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 31);
            this.panel2.TabIndex = 27;
            // 
            // pctLogoGenerador
            // 
            this.pctLogoGenerador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctLogoGenerador.Image = ((System.Drawing.Image)(resources.GetObject("pctLogoGenerador.Image")));
            this.pctLogoGenerador.Location = new System.Drawing.Point(102, 2);
            this.pctLogoGenerador.Name = "pctLogoGenerador";
            this.pctLogoGenerador.Size = new System.Drawing.Size(28, 28);
            this.pctLogoGenerador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogoGenerador.TabIndex = 28;
            this.pctLogoGenerador.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Controls.Add(this.lblRecord);
            this.panel1.Controls.Add(this.btnNuevaPartida);
            this.panel1.Controls.Add(this.pctLogoDaga);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(618, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 558);
            this.panel1.TabIndex = 22;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(94, 70);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(87, 24);
            this.lblScore.TabIndex = 38;
            this.lblScore.Text = "SCORE:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.White;
            this.lblRecord.Location = new System.Drawing.Point(126, 110);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(21, 24);
            this.lblRecord.TabIndex = 37;
            this.lblRecord.Text = "0";
            // 
            // btnNuevaPartida
            // 
            this.btnNuevaPartida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevaPartida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevaPartida.BackgroundImage")));
            this.btnNuevaPartida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevaPartida.FlatAppearance.BorderSize = 0;
            this.btnNuevaPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaPartida.ForeColor = System.Drawing.Color.White;
            this.btnNuevaPartida.Location = new System.Drawing.Point(21, 431);
            this.btnNuevaPartida.Name = "btnNuevaPartida";
            this.btnNuevaPartida.Size = new System.Drawing.Size(219, 44);
            this.btnNuevaPartida.TabIndex = 36;
            this.btnNuevaPartida.Text = "Nueva Partida";
            this.btnNuevaPartida.UseVisualStyleBackColor = true;
            this.btnNuevaPartida.Click += new System.EventHandler(this.btnNuevaPartida_Click);
            // 
            // pctLogoDaga
            // 
            this.pctLogoDaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pctLogoDaga.Image = ((System.Drawing.Image)(resources.GetObject("pctLogoDaga.Image")));
            this.pctLogoDaga.Location = new System.Drawing.Point(185, 516);
            this.pctLogoDaga.Name = "pctLogoDaga";
            this.pctLogoDaga.Size = new System.Drawing.Size(66, 30);
            this.pctLogoDaga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogoDaga.TabIndex = 35;
            this.pctLogoDaga.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlJuego);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 558);
            this.panel3.TabIndex = 35;
            // 
            // pnlJuego
            // 
            this.pnlJuego.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlJuego.Location = new System.Drawing.Point(22, 37);
            this.pnlJuego.Name = "pnlJuego";
            this.pnlJuego.Size = new System.Drawing.Size(574, 491);
            this.pnlJuego.TabIndex = 35;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FormEntrenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(882, 594);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNavegacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEntrenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entretenimiento";
            this.pnlNavegacion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoGenerador)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoDaga)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevaPartida;
        private System.Windows.Forms.PictureBox pctLogoDaga;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctLogoGenerador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlJuego;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer1;
    }
}