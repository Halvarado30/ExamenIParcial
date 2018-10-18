namespace FrmPrincipal
{
    partial class FrmPPrincipal
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbResenia_Analisis = new System.Windows.Forms.GroupBox();
            this.lstbProductos = new System.Windows.Forms.ListBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblCorreoUsuario = new System.Windows.Forms.Label();
            this.lblValoracionUsuario = new System.Windows.Forms.Label();
            this.lblComentariosUsuarios = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.nupValoracion = new System.Windows.Forms.NumericUpDown();
            this.gbResenia_Analisis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValoracion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAceptar.Location = new System.Drawing.Point(135, 420);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(163, 40);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbResenia_Analisis
            // 
            this.gbResenia_Analisis.Controls.Add(this.nupValoracion);
            this.gbResenia_Analisis.Controls.Add(this.btnSalir);
            this.gbResenia_Analisis.Controls.Add(this.txtComentarios);
            this.gbResenia_Analisis.Controls.Add(this.txtCorreoUsuario);
            this.gbResenia_Analisis.Controls.Add(this.txtNombreUsuario);
            this.gbResenia_Analisis.Controls.Add(this.lblComentariosUsuarios);
            this.gbResenia_Analisis.Controls.Add(this.lblValoracionUsuario);
            this.gbResenia_Analisis.Controls.Add(this.lblCorreoUsuario);
            this.gbResenia_Analisis.Controls.Add(this.lblNombreUsuario);
            this.gbResenia_Analisis.Controls.Add(this.lstbProductos);
            this.gbResenia_Analisis.Controls.Add(this.btnAceptar);
            this.gbResenia_Analisis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gbResenia_Analisis.Location = new System.Drawing.Point(21, 21);
            this.gbResenia_Analisis.Name = "gbResenia_Analisis";
            this.gbResenia_Analisis.Size = new System.Drawing.Size(749, 482);
            this.gbResenia_Analisis.TabIndex = 2;
            this.gbResenia_Analisis.TabStop = false;
            this.gbResenia_Analisis.Text = "Seleccione el producto a realizar su reseña/análisis";
            // 
            // lstbProductos
            // 
            this.lstbProductos.FormattingEnabled = true;
            this.lstbProductos.ItemHeight = 28;
            this.lstbProductos.Location = new System.Drawing.Point(18, 37);
            this.lstbProductos.Name = "lstbProductos";
            this.lstbProductos.Size = new System.Drawing.Size(280, 340);
            this.lstbProductos.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblNombreUsuario.Location = new System.Drawing.Point(348, 37);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(177, 28);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre Completo";
            // 
            // lblCorreoUsuario
            // 
            this.lblCorreoUsuario.AutoSize = true;
            this.lblCorreoUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCorreoUsuario.Location = new System.Drawing.Point(348, 109);
            this.lblCorreoUsuario.Name = "lblCorreoUsuario";
            this.lblCorreoUsuario.Size = new System.Drawing.Size(174, 28);
            this.lblCorreoUsuario.TabIndex = 4;
            this.lblCorreoUsuario.Text = "Correo Electrónico";
            // 
            // lblValoracionUsuario
            // 
            this.lblValoracionUsuario.AutoSize = true;
            this.lblValoracionUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblValoracionUsuario.Location = new System.Drawing.Point(348, 182);
            this.lblValoracionUsuario.Name = "lblValoracionUsuario";
            this.lblValoracionUsuario.Size = new System.Drawing.Size(104, 28);
            this.lblValoracionUsuario.TabIndex = 5;
            this.lblValoracionUsuario.Text = "Valoración";
            // 
            // lblComentariosUsuarios
            // 
            this.lblComentariosUsuarios.AutoSize = true;
            this.lblComentariosUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblComentariosUsuarios.Location = new System.Drawing.Point(348, 247);
            this.lblComentariosUsuarios.Name = "lblComentariosUsuarios";
            this.lblComentariosUsuarios.Size = new System.Drawing.Size(123, 28);
            this.lblComentariosUsuarios.TabIndex = 6;
            this.lblComentariosUsuarios.Text = "Comentarios";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(351, 71);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(361, 34);
            this.txtNombreUsuario.TabIndex = 7;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Location = new System.Drawing.Point(351, 146);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(361, 34);
            this.txtCorreoUsuario.TabIndex = 8;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(351, 281);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentarios.Size = new System.Drawing.Size(361, 114);
            this.txtComentarios.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalir.Location = new System.Drawing.Point(382, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(163, 40);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // nupValoracion
            // 
            this.nupValoracion.Location = new System.Drawing.Point(351, 213);
            this.nupValoracion.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupValoracion.Name = "nupValoracion";
            this.nupValoracion.Size = new System.Drawing.Size(120, 34);
            this.nupValoracion.TabIndex = 13;
            this.nupValoracion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmPPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 515);
            this.Controls.Add(this.gbResenia_Analisis);
            this.Name = "FrmPPrincipal";
            this.Text = "Reseña/Análisis de productos - AdventureWorks";
            this.Load += new System.EventHandler(this.FrmPPrincipal_Load);
            this.gbResenia_Analisis.ResumeLayout(false);
            this.gbResenia_Analisis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValoracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbResenia_Analisis;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblComentariosUsuarios;
        private System.Windows.Forms.Label lblValoracionUsuario;
        private System.Windows.Forms.Label lblCorreoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ListBox lstbProductos;
        private System.Windows.Forms.NumericUpDown nupValoracion;
    }
}

