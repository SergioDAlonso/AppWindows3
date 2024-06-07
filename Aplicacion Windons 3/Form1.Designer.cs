namespace Aplicacion_Windons_3
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
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxEdad = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDirec = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.bttAceptar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.tbxDirec = new System.Windows.Forms.TextBox();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbxApellido
            // 
            this.tbxApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxApellido.Location = new System.Drawing.Point(100, 12);
            this.tbxApellido.MaxLength = 300;
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(431, 20);
            this.tbxApellido.TabIndex = 0;
            // 
            // tbxNombre
            // 
            this.tbxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxNombre.Location = new System.Drawing.Point(100, 59);
            this.tbxNombre.MaxLength = 300;
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(431, 20);
            this.tbxNombre.TabIndex = 1;
            // 
            // tbxEdad
            // 
            this.tbxEdad.Location = new System.Drawing.Point(100, 107);
            this.tbxEdad.MaxLength = 3;
            this.tbxEdad.Name = "tbxEdad";
            this.tbxEdad.Size = new System.Drawing.Size(100, 20);
            this.tbxEdad.TabIndex = 3;
            this.tbxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEdad_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(12, 13);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(71, 16);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(12, 111);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(45, 16);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "EDAD";
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirec.Location = new System.Drawing.Point(12, 156);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(80, 16);
            this.lblDirec.TabIndex = 7;
            this.lblDirec.Text = "DIRECCÍON";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 199);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(90, 16);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "RESULTADO";
            // 
            // bttAceptar
            // 
            this.bttAceptar.FlatAppearance.BorderSize = 5;
            this.bttAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttAceptar.Location = new System.Drawing.Point(100, 375);
            this.bttAceptar.Name = "bttAceptar";
            this.bttAceptar.Size = new System.Drawing.Size(75, 23);
            this.bttAceptar.TabIndex = 10;
            this.bttAceptar.Text = "Aceptar";
            this.bttAceptar.UseVisualStyleBackColor = true;
            this.bttAceptar.Click += new System.EventHandler(this.bttAceptar_Click);
            // 
            // bttCancelar
            // 
            this.bttCancelar.FlatAppearance.BorderSize = 5;
            this.bttCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttCancelar.Location = new System.Drawing.Point(343, 375);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttCancelar.TabIndex = 11;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            this.bttCancelar.Click += new System.EventHandler(this.bttCancelar_Click);
            // 
            // tbxDirec
            // 
            this.tbxDirec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxDirec.Location = new System.Drawing.Point(100, 152);
            this.tbxDirec.MaxLength = 300;
            this.tbxDirec.Name = "tbxDirec";
            this.tbxDirec.Size = new System.Drawing.Size(431, 20);
            this.tbxDirec.TabIndex = 2;
            // 
            // rtbResultado
            // 
            this.rtbResultado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbResultado.Location = new System.Drawing.Point(15, 218);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.ReadOnly = true;
            this.rtbResultado.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbResultado.Size = new System.Drawing.Size(524, 151);
            this.rtbResultado.TabIndex = 12;
            this.rtbResultado.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(551, 410);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttAceptar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDirec);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbxEdad);
            this.Controls.Add(this.tbxDirec);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxEdad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button bttAceptar;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.TextBox tbxDirec;
        private System.Windows.Forms.RichTextBox rtbResultado;
    }
}

