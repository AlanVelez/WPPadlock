namespace WAFPProyectoFinal
{
    partial class FormDidactico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDidactico));
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pctLogoGenerador = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pctLogoDaga = new System.Windows.Forms.PictureBox();
            this.txtContraGenerada = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.chckMayus = new System.Windows.Forms.CheckBox();
            this.chckMinu = new System.Windows.Forms.CheckBox();
            this.chckNum = new System.Windows.Forms.CheckBox();
            this.lblNumCaracteres = new System.Windows.Forms.Label();
            this.pctTipo = new System.Windows.Forms.PictureBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtCantCaracteres = new System.Windows.Forms.TextBox();
            this.btnGenerarIcon = new System.Windows.Forms.Button();
            this.chckSim = new System.Windows.Forms.CheckBox();
            this.pnlNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoGenerador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoDaga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(813, 8);
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
            this.btnCerrar.Location = new System.Drawing.Point(849, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 21);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(49)))));
            this.pnlNavegacion.Controls.Add(this.btnRegresar);
            this.pnlNavegacion.Controls.Add(this.pctLogoGenerador);
            this.pnlNavegacion.Controls.Add(this.lblTitulo);
            this.pnlNavegacion.Controls.Add(this.btnMinimizar);
            this.pnlNavegacion.Controls.Add(this.btnCerrar);
            this.pnlNavegacion.Location = new System.Drawing.Point(-1, 0);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(885, 36);
            this.pnlNavegacion.TabIndex = 20;
            this.pnlNavegacion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlNavegacion_MouseDown);
            this.pnlNavegacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlNavegacion_MouseMove);
            this.pnlNavegacion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlNavegacion_MouseUp);
            // 
            // btnRegresar
            // 
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
            // pctLogoGenerador
            // 
            this.pctLogoGenerador.Image = ((System.Drawing.Image)(resources.GetObject("pctLogoGenerador.Image")));
            this.pctLogoGenerador.Location = new System.Drawing.Point(536, 4);
            this.pctLogoGenerador.Name = "pctLogoGenerador";
            this.pctLogoGenerador.Size = new System.Drawing.Size(28, 28);
            this.pctLogoGenerador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogoGenerador.TabIndex = 24;
            this.pctLogoGenerador.TabStop = false;
            this.pctLogoGenerador.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlNavegacion_MouseDown);
            this.pctLogoGenerador.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlNavegacion_MouseMove);
            this.pctLogoGenerador.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlNavegacion_MouseUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(319, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(216, 22);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Generador de contraseñas";
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlNavegacion_MouseDown);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlNavegacion_MouseMove);
            this.lblTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlNavegacion_MouseUp);
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Raleway Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.White;
            this.lblSlogan.Location = new System.Drawing.Point(328, 126);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(231, 22);
            this.lblSlogan.TabIndex = 22;
            this.lblSlogan.Text = "Estar seguro de estar seguro.";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.lblLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLogo.Font = new System.Drawing.Font("Raleway ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(335, 56);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(217, 66);
            this.lblLogo.TabIndex = 21;
            this.lblLogo.Text = "padlock";
            // 
            // pctLogoDaga
            // 
            this.pctLogoDaga.Image = ((System.Drawing.Image)(resources.GetObject("pctLogoDaga.Image")));
            this.pctLogoDaga.Location = new System.Drawing.Point(804, 491);
            this.pctLogoDaga.Name = "pctLogoDaga";
            this.pctLogoDaga.Size = new System.Drawing.Size(66, 30);
            this.pctLogoDaga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogoDaga.TabIndex = 23;
            this.pctLogoDaga.TabStop = false;
            // 
            // txtContraGenerada
            // 
            this.txtContraGenerada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraGenerada.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraGenerada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.txtContraGenerada.Location = new System.Drawing.Point(255, 203);
            this.txtContraGenerada.Multiline = true;
            this.txtContraGenerada.Name = "txtContraGenerada";
            this.txtContraGenerada.ReadOnly = true;
            this.txtContraGenerada.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtContraGenerada.Size = new System.Drawing.Size(375, 38);
            this.txtContraGenerada.TabIndex = 25;
            this.txtContraGenerada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.btnGenerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerar.BackgroundImage")));
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(350, 425);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(193, 54);
            this.btnGenerar.TabIndex = 32;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopiar.BackgroundImage")));
            this.btnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopiar.FlatAppearance.BorderSize = 0;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.Location = new System.Drawing.Point(639, 207);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(27, 30);
            this.btnCopiar.TabIndex = 33;
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // chckMayus
            // 
            this.chckMayus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.chckMayus.Checked = true;
            this.chckMayus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckMayus.FlatAppearance.BorderSize = 0;
            this.chckMayus.Font = new System.Drawing.Font("Raleway SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckMayus.ForeColor = System.Drawing.Color.White;
            this.chckMayus.Location = new System.Drawing.Point(231, 312);
            this.chckMayus.Name = "chckMayus";
            this.chckMayus.Size = new System.Drawing.Size(268, 33);
            this.chckMayus.TabIndex = 34;
            this.chckMayus.Text = "Incluir letras mayusculas.";
            this.chckMayus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckMayus.UseVisualStyleBackColor = false;
            // 
            // chckMinu
            // 
            this.chckMinu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.chckMinu.Checked = true;
            this.chckMinu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckMinu.FlatAppearance.BorderSize = 0;
            this.chckMinu.Font = new System.Drawing.Font("Raleway SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckMinu.ForeColor = System.Drawing.Color.White;
            this.chckMinu.Location = new System.Drawing.Point(231, 351);
            this.chckMinu.Name = "chckMinu";
            this.chckMinu.Size = new System.Drawing.Size(268, 33);
            this.chckMinu.TabIndex = 35;
            this.chckMinu.Text = "Incluir letras minusculas.";
            this.chckMinu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckMinu.UseVisualStyleBackColor = false;
            // 
            // chckNum
            // 
            this.chckNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.chckNum.FlatAppearance.BorderSize = 0;
            this.chckNum.Font = new System.Drawing.Font("Raleway SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckNum.ForeColor = System.Drawing.Color.White;
            this.chckNum.Location = new System.Drawing.Point(505, 312);
            this.chckNum.Name = "chckNum";
            this.chckNum.Size = new System.Drawing.Size(189, 33);
            this.chckNum.TabIndex = 36;
            this.chckNum.Text = "Incluir numeros.";
            this.chckNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckNum.UseVisualStyleBackColor = false;
            // 
            // lblNumCaracteres
            // 
            this.lblNumCaracteres.AutoSize = true;
            this.lblNumCaracteres.Font = new System.Drawing.Font("Raleway SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCaracteres.ForeColor = System.Drawing.Color.White;
            this.lblNumCaracteres.Location = new System.Drawing.Point(358, 267);
            this.lblNumCaracteres.Name = "lblNumCaracteres";
            this.lblNumCaracteres.Size = new System.Drawing.Size(219, 26);
            this.lblNumCaracteres.TabIndex = 38;
            this.lblNumCaracteres.Text = "Numero de caracteres.";
            this.lblNumCaracteres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctTipo
            // 
            this.pctTipo.Image = ((System.Drawing.Image)(resources.GetObject("pctTipo.Image")));
            this.pctTipo.Location = new System.Drawing.Point(205, 203);
            this.pctTipo.Name = "pctTipo";
            this.pctTipo.Size = new System.Drawing.Size(42, 38);
            this.pctTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTipo.TabIndex = 39;
            this.pctTipo.TabStop = false;
            this.pctTipo.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTipo.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(181)))), ((int)(((byte)(77)))));
            this.lblTipo.Location = new System.Drawing.Point(561, 211);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(60, 22);
            this.lblTipo.TabIndex = 40;
            this.lblTipo.Text = "Fuerte";
            this.lblTipo.Visible = false;
            // 
            // txtCantCaracteres
            // 
            this.txtCantCaracteres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantCaracteres.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantCaracteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.txtCantCaracteres.Location = new System.Drawing.Point(305, 269);
            this.txtCantCaracteres.Multiline = true;
            this.txtCantCaracteres.Name = "txtCantCaracteres";
            this.txtCantCaracteres.Size = new System.Drawing.Size(47, 26);
            this.txtCantCaracteres.TabIndex = 41;
            this.txtCantCaracteres.Text = "8";
            this.txtCantCaracteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerarIcon
            // 
            this.btnGenerarIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.btnGenerarIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerarIcon.BackgroundImage")));
            this.btnGenerarIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerarIcon.FlatAppearance.BorderSize = 0;
            this.btnGenerarIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarIcon.Location = new System.Drawing.Point(672, 209);
            this.btnGenerarIcon.Name = "btnGenerarIcon";
            this.btnGenerarIcon.Size = new System.Drawing.Size(27, 26);
            this.btnGenerarIcon.TabIndex = 42;
            this.btnGenerarIcon.UseVisualStyleBackColor = false;
            this.btnGenerarIcon.Click += new System.EventHandler(this.btnGenerarIcon_Click);
            // 
            // chckSim
            // 
            this.chckSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.chckSim.FlatAppearance.BorderSize = 0;
            this.chckSim.Font = new System.Drawing.Font("Raleway SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckSim.ForeColor = System.Drawing.Color.White;
            this.chckSim.Location = new System.Drawing.Point(505, 351);
            this.chckSim.Name = "chckSim";
            this.chckSim.Size = new System.Drawing.Size(189, 33);
            this.chckSim.TabIndex = 43;
            this.chckSim.Text = "Incluir símbolos.";
            this.chckSim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckSim.UseVisualStyleBackColor = false;
            // 
            // FormDidactico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(882, 533);
            this.Controls.Add(this.chckSim);
            this.Controls.Add(this.btnGenerarIcon);
            this.Controls.Add(this.txtCantCaracteres);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.pctTipo);
            this.Controls.Add(this.lblNumCaracteres);
            this.Controls.Add(this.chckNum);
            this.Controls.Add(this.chckMinu);
            this.Controls.Add(this.chckMayus);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtContraGenerada);
            this.Controls.Add(this.pctLogoDaga);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pnlNavegacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDidactico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de contraseñas";
            this.pnlNavegacion.ResumeLayout(false);
            this.pnlNavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoGenerador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoDaga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pctLogoDaga;
        private System.Windows.Forms.PictureBox pctLogoGenerador;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtContraGenerada;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.CheckBox chckMayus;
        private System.Windows.Forms.CheckBox chckMinu;
        private System.Windows.Forms.CheckBox chckNum;
        private System.Windows.Forms.Label lblNumCaracteres;
        private System.Windows.Forms.PictureBox pctTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtCantCaracteres;
        private System.Windows.Forms.Button btnGenerarIcon;
        private System.Windows.Forms.CheckBox chckSim;
    }
}