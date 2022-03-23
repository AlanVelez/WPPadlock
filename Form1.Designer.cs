namespace WAFPProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pctMemorama = new System.Windows.Forms.PictureBox();
            this.pctInformate = new System.Windows.Forms.PictureBox();
            this.pctGenerador = new System.Windows.Forms.PictureBox();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTituloMemorama = new System.Windows.Forms.Label();
            this.lblTituloInformate = new System.Windows.Forms.Label();
            this.lblTituloGenerador = new System.Windows.Forms.Label();
            this.lblTxtMemorama = new System.Windows.Forms.Label();
            this.lblTxtInformate = new System.Windows.Forms.Label();
            this.lblTxtGenerador = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.pctLogoDaga = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctMemorama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInformate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGenerador)).BeginInit();
            this.pnlNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoDaga)).BeginInit();
            this.SuspendLayout();
            // 
            // pctMemorama
            // 
            this.pctMemorama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMemorama.Image = ((System.Drawing.Image)(resources.GetObject("pctMemorama.Image")));
            this.pctMemorama.Location = new System.Drawing.Point(191, 181);
            this.pctMemorama.Name = "pctMemorama";
            this.pctMemorama.Size = new System.Drawing.Size(242, 108);
            this.pctMemorama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMemorama.TabIndex = 1;
            this.pctMemorama.TabStop = false;
            this.pctMemorama.Click += new System.EventHandler(this.pctMemorama_Click);
            this.pctMemorama.MouseLeave += new System.EventHandler(this.pctMemorama_MouseLeave);
            this.pctMemorama.MouseHover += new System.EventHandler(this.pctMemorama_MouseHover);
            // 
            // pctInformate
            // 
            this.pctInformate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctInformate.Image = ((System.Drawing.Image)(resources.GetObject("pctInformate.Image")));
            this.pctInformate.Location = new System.Drawing.Point(455, 181);
            this.pctInformate.Name = "pctInformate";
            this.pctInformate.Size = new System.Drawing.Size(236, 108);
            this.pctInformate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctInformate.TabIndex = 2;
            this.pctInformate.TabStop = false;
            this.pctInformate.Click += new System.EventHandler(this.pctInformate_Click);
            this.pctInformate.MouseLeave += new System.EventHandler(this.pctInformate_MouseLeave);
            this.pctInformate.MouseHover += new System.EventHandler(this.pctInformate_MouseHover);
            // 
            // pctGenerador
            // 
            this.pctGenerador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctGenerador.Image = ((System.Drawing.Image)(resources.GetObject("pctGenerador.Image")));
            this.pctGenerador.Location = new System.Drawing.Point(191, 311);
            this.pctGenerador.Name = "pctGenerador";
            this.pctGenerador.Size = new System.Drawing.Size(500, 108);
            this.pctGenerador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGenerador.TabIndex = 3;
            this.pctGenerador.TabStop = false;
            this.pctGenerador.Click += new System.EventHandler(this.pctGenerador_Click);
            this.pctGenerador.MouseLeave += new System.EventHandler(this.pctGenerador_MouseLeave);
            this.pctGenerador.MouseHover += new System.EventHandler(this.pctGenerador_MouseHover);
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.pnlNavegacion.Controls.Add(this.btnMinimizar);
            this.pnlNavegacion.Controls.Add(this.btnCerrar);
            this.pnlNavegacion.Location = new System.Drawing.Point(-1, -2);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(885, 36);
            this.pnlNavegacion.TabIndex = 4;
            this.pnlNavegacion.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNavegacion_Paint);
            this.pnlNavegacion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlNavegacion_MouseDown);
            this.pnlNavegacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlNavegacion_MouseMove);
            this.pnlNavegacion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlNavegacion_MouseUp);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(814, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 21);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(850, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 21);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTituloMemorama
            // 
            this.lblTituloMemorama.AutoSize = true;
            this.lblTituloMemorama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.lblTituloMemorama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTituloMemorama.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMemorama.ForeColor = System.Drawing.Color.White;
            this.lblTituloMemorama.Location = new System.Drawing.Point(208, 208);
            this.lblTituloMemorama.Name = "lblTituloMemorama";
            this.lblTituloMemorama.Size = new System.Drawing.Size(98, 22);
            this.lblTituloMemorama.TabIndex = 5;
            this.lblTituloMemorama.Text = "Memorama";
            this.lblTituloMemorama.Click += new System.EventHandler(this.lblTituloMemorama_Click);
            this.lblTituloMemorama.MouseLeave += new System.EventHandler(this.lblTituloMemorama_MouseLeave);
            this.lblTituloMemorama.MouseHover += new System.EventHandler(this.lblTituloMemorama_MouseHover);
            // 
            // lblTituloInformate
            // 
            this.lblTituloInformate.AutoSize = true;
            this.lblTituloInformate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.lblTituloInformate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTituloInformate.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInformate.ForeColor = System.Drawing.Color.White;
            this.lblTituloInformate.Location = new System.Drawing.Point(473, 208);
            this.lblTituloInformate.Name = "lblTituloInformate";
            this.lblTituloInformate.Size = new System.Drawing.Size(87, 22);
            this.lblTituloInformate.TabIndex = 6;
            this.lblTituloInformate.Text = "Informate";
            this.lblTituloInformate.Click += new System.EventHandler(this.lblTituloInformate_Click);
            this.lblTituloInformate.MouseLeave += new System.EventHandler(this.pctInformate_MouseLeave);
            this.lblTituloInformate.MouseHover += new System.EventHandler(this.lblTituloInformate_MouseHover);
            // 
            // lblTituloGenerador
            // 
            this.lblTituloGenerador.AutoSize = true;
            this.lblTituloGenerador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.lblTituloGenerador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTituloGenerador.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGenerador.ForeColor = System.Drawing.Color.White;
            this.lblTituloGenerador.Location = new System.Drawing.Point(208, 334);
            this.lblTituloGenerador.Name = "lblTituloGenerador";
            this.lblTituloGenerador.Size = new System.Drawing.Size(216, 22);
            this.lblTituloGenerador.TabIndex = 7;
            this.lblTituloGenerador.Text = "Generador de contraseñas";
            this.lblTituloGenerador.Click += new System.EventHandler(this.lblTituloGenerador_Click);
            this.lblTituloGenerador.MouseLeave += new System.EventHandler(this.pctGenerador_MouseLeave);
            this.lblTituloGenerador.MouseHover += new System.EventHandler(this.pctGenerador_MouseHover);
            // 
            // lblTxtMemorama
            // 
            this.lblTxtMemorama.AutoSize = true;
            this.lblTxtMemorama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.lblTxtMemorama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTxtMemorama.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtMemorama.ForeColor = System.Drawing.Color.White;
            this.lblTxtMemorama.Location = new System.Drawing.Point(208, 230);
            this.lblTxtMemorama.Name = "lblTxtMemorama";
            this.lblTxtMemorama.Size = new System.Drawing.Size(126, 36);
            this.lblTxtMemorama.TabIndex = 8;
            this.lblTxtMemorama.Text = "Diviertete mientras\r\naprendes.";
            this.lblTxtMemorama.Click += new System.EventHandler(this.lblTxtMemorama_Click);
            this.lblTxtMemorama.MouseLeave += new System.EventHandler(this.lblTxtMemorama_MouseLeave);
            this.lblTxtMemorama.MouseHover += new System.EventHandler(this.lblTxtMemorama_MouseHover);
            // 
            // lblTxtInformate
            // 
            this.lblTxtInformate.AutoSize = true;
            this.lblTxtInformate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.lblTxtInformate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTxtInformate.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtInformate.ForeColor = System.Drawing.Color.White;
            this.lblTxtInformate.Location = new System.Drawing.Point(474, 230);
            this.lblTxtInformate.Name = "lblTxtInformate";
            this.lblTxtInformate.Size = new System.Drawing.Size(100, 36);
            this.lblTxtInformate.TabIndex = 9;
            this.lblTxtInformate.Text = "Aprende sobre\r\nseguridad.";
            this.lblTxtInformate.Click += new System.EventHandler(this.lblTxtInformate_Click);
            this.lblTxtInformate.MouseLeave += new System.EventHandler(this.pctInformate_MouseLeave);
            this.lblTxtInformate.MouseHover += new System.EventHandler(this.lblTituloInformate_MouseHover);
            // 
            // lblTxtGenerador
            // 
            this.lblTxtGenerador.AutoSize = true;
            this.lblTxtGenerador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.lblTxtGenerador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTxtGenerador.Font = new System.Drawing.Font("Raleway Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtGenerador.ForeColor = System.Drawing.Color.White;
            this.lblTxtGenerador.Location = new System.Drawing.Point(209, 361);
            this.lblTxtGenerador.Name = "lblTxtGenerador";
            this.lblTxtGenerador.Size = new System.Drawing.Size(341, 36);
            this.lblTxtGenerador.TabIndex = 10;
            this.lblTxtGenerador.Text = "Un generador que proporciona contraseñas seguras y \r\nunicas instantaniamente.";
            this.lblTxtGenerador.Click += new System.EventHandler(this.lblTxtGenerador_Click);
            this.lblTxtGenerador.MouseLeave += new System.EventHandler(this.pctGenerador_MouseLeave);
            this.lblTxtGenerador.MouseHover += new System.EventHandler(this.pctGenerador_MouseHover);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.lblLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLogo.Font = new System.Drawing.Font("Raleway ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(335, 52);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(217, 66);
            this.lblLogo.TabIndex = 11;
            this.lblLogo.Text = "padlock";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Raleway Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.White;
            this.lblSlogan.Location = new System.Drawing.Point(328, 122);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(231, 22);
            this.lblSlogan.TabIndex = 14;
            this.lblSlogan.Text = "Estar seguro de estar seguro.";
            // 
            // pctLogoDaga
            // 
            this.pctLogoDaga.Image = ((System.Drawing.Image)(resources.GetObject("pctLogoDaga.Image")));
            this.pctLogoDaga.Location = new System.Drawing.Point(804, 491);
            this.pctLogoDaga.Name = "pctLogoDaga";
            this.pctLogoDaga.Size = new System.Drawing.Size(66, 30);
            this.pctLogoDaga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogoDaga.TabIndex = 15;
            this.pctLogoDaga.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(882, 533);
            this.Controls.Add(this.pctLogoDaga);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblTxtGenerador);
            this.Controls.Add(this.lblTxtInformate);
            this.Controls.Add(this.lblTxtMemorama);
            this.Controls.Add(this.lblTituloGenerador);
            this.Controls.Add(this.lblTituloInformate);
            this.Controls.Add(this.lblTituloMemorama);
            this.Controls.Add(this.pnlNavegacion);
            this.Controls.Add(this.pctGenerador);
            this.Controls.Add(this.pctInformate);
            this.Controls.Add(this.pctMemorama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctMemorama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctInformate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGenerador)).EndInit();
            this.pnlNavegacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoDaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctMemorama;
        private System.Windows.Forms.PictureBox pctInformate;
        private System.Windows.Forms.PictureBox pctGenerador;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTituloMemorama;
        private System.Windows.Forms.Label lblTituloInformate;
        private System.Windows.Forms.Label lblTituloGenerador;
        private System.Windows.Forms.Label lblTxtMemorama;
        private System.Windows.Forms.Label lblTxtInformate;
        private System.Windows.Forms.Label lblTxtGenerador;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.PictureBox pctLogoDaga;
    }
}

