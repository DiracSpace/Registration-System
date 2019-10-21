namespace Registration
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelnombre = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.labelprimerA = new System.Windows.Forms.Label();
            this.primerA = new System.Windows.Forms.TextBox();
            this.labelsegundoA = new System.Windows.Forms.Label();
            this.segundoA = new System.Windows.Forms.TextBox();
            this.edad = new System.Windows.Forms.TextBox();
            this.labeledad = new System.Windows.Forms.Label();
            this.accept = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idcliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.ruta = new System.Windows.Forms.TextBox();
            this.destino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clientcode = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.Label();
            this.dbbackup = new System.Windows.Forms.Button();
            this.bdview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelnombre.Location = new System.Drawing.Point(7, 78);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(245, 29);
            this.labelnombre.TabIndex = 0;
            this.labelnombre.Text = "Ingrese su nombre: ";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(346, 81);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(185, 20);
            this.nombre.TabIndex = 1;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // labelprimerA
            // 
            this.labelprimerA.AutoSize = true;
            this.labelprimerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelprimerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprimerA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelprimerA.Location = new System.Drawing.Point(7, 128);
            this.labelprimerA.Name = "labelprimerA";
            this.labelprimerA.Size = new System.Drawing.Size(300, 29);
            this.labelprimerA.TabIndex = 2;
            this.labelprimerA.Text = "Ingrese primer apellido: ";
            // 
            // primerA
            // 
            this.primerA.Location = new System.Drawing.Point(346, 137);
            this.primerA.Name = "primerA";
            this.primerA.Size = new System.Drawing.Size(185, 20);
            this.primerA.TabIndex = 3;
            // 
            // labelsegundoA
            // 
            this.labelsegundoA.AutoSize = true;
            this.labelsegundoA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelsegundoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsegundoA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelsegundoA.Location = new System.Drawing.Point(7, 192);
            this.labelsegundoA.Name = "labelsegundoA";
            this.labelsegundoA.Size = new System.Drawing.Size(325, 29);
            this.labelsegundoA.TabIndex = 4;
            this.labelsegundoA.Text = "Ingrese segundo apellido: ";
            // 
            // segundoA
            // 
            this.segundoA.Location = new System.Drawing.Point(346, 201);
            this.segundoA.Name = "segundoA";
            this.segundoA.Size = new System.Drawing.Size(185, 20);
            this.segundoA.TabIndex = 5;
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(346, 259);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(185, 20);
            this.edad.TabIndex = 9;
            // 
            // labeledad
            // 
            this.labeledad.AutoSize = true;
            this.labeledad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labeledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeledad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeledad.Location = new System.Drawing.Point(7, 250);
            this.labeledad.Name = "labeledad";
            this.labeledad.Size = new System.Drawing.Size(215, 29);
            this.labeledad.TabIndex = 8;
            this.labeledad.Text = "Ingrese su edad: ";
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(40, 489);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(111, 38);
            this.accept.TabIndex = 14;
            this.accept.Text = "Aceptar";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(157, 489);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(111, 38);
            this.editar.TabIndex = 15;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(274, 489);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(111, 38);
            this.actualizar.TabIndex = 16;
            this.actualizar.Text = "Buscar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(391, 489);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(111, 38);
            this.btnsalir.TabIndex = 17;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Su ID: ";
            // 
            // idcliente
            // 
            this.idcliente.Location = new System.Drawing.Point(347, 25);
            this.idcliente.Name = "idcliente";
            this.idcliente.Size = new System.Drawing.Size(185, 20);
            this.idcliente.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(551, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ingrese su foto: ";
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(556, 93);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(428, 390);
            this.imagen.TabIndex = 21;
            this.imagen.TabStop = false;
            this.imagen.Click += new System.EventHandler(this.imagen_Click);
            // 
            // ruta
            // 
            this.ruta.Location = new System.Drawing.Point(555, 66);
            this.ruta.Name = "ruta";
            this.ruta.Size = new System.Drawing.Size(429, 20);
            this.ruta.TabIndex = 22;
            // 
            // destino
            // 
            this.destino.Location = new System.Drawing.Point(346, 319);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(185, 20);
            this.destino.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(7, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ingrese su correo: ";
            // 
            // clientcode
            // 
            this.clientcode.Location = new System.Drawing.Point(346, 376);
            this.clientcode.Name = "clientcode";
            this.clientcode.Size = new System.Drawing.Size(185, 20);
            this.clientcode.TabIndex = 25;
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.code.Location = new System.Drawing.Point(7, 367);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(202, 29);
            this.code.TabIndex = 26;
            this.code.Text = "Ingrese código: ";
            // 
            // dbbackup
            // 
            this.dbbackup.Location = new System.Drawing.Point(556, 489);
            this.dbbackup.Name = "dbbackup";
            this.dbbackup.Size = new System.Drawing.Size(111, 38);
            this.dbbackup.TabIndex = 27;
            this.dbbackup.Text = "Respaldo";
            this.dbbackup.UseVisualStyleBackColor = true;
            this.dbbackup.Click += new System.EventHandler(this.dbbackup_Click);
            // 
            // bdview
            // 
            this.bdview.Location = new System.Drawing.Point(673, 489);
            this.bdview.Name = "bdview";
            this.bdview.Size = new System.Drawing.Size(111, 38);
            this.bdview.TabIndex = 28;
            this.bdview.Text = "Ver respaldo";
            this.bdview.UseVisualStyleBackColor = true;
            this.bdview.Click += new System.EventHandler(this.bdview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 536);
            this.Controls.Add(this.bdview);
            this.Controls.Add(this.dbbackup);
            this.Controls.Add(this.clientcode);
            this.Controls.Add(this.code);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ruta);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idcliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.labeledad);
            this.Controls.Add(this.segundoA);
            this.Controls.Add(this.labelsegundoA);
            this.Controls.Add(this.primerA);
            this.Controls.Add(this.labelprimerA);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.labelnombre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registration App";
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label labelprimerA;
        private System.Windows.Forms.TextBox primerA;
        private System.Windows.Forms.Label labelsegundoA;
        private System.Windows.Forms.TextBox segundoA;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.Label labeledad;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.TextBox ruta;
        private System.Windows.Forms.TextBox destino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clientcode;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.Button dbbackup;
        private System.Windows.Forms.Button bdview;
    }
}

