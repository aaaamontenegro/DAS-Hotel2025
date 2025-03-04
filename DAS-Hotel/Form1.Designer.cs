namespace DAS_Hotel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDui = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            this.cbHabitacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNoches = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNumHab = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listReservasOn = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbCancelacion = new System.Windows.Forms.Label();
            this.tbNumeroHabitaciones = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dui";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(104, 97);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(161, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // tbDui
            // 
            this.tbDui.Location = new System.Drawing.Point(104, 71);
            this.tbDui.Name = "tbDui";
            this.tbDui.Size = new System.Drawing.Size(161, 20);
            this.tbDui.TabIndex = 4;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(104, 126);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(161, 20);
            this.tbTelefono.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Agregar Cliente";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(84, 329);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Continuar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.Location = new System.Drawing.Point(325, 71);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(255, 485);
            this.lstHabitaciones.TabIndex = 8;
            // 
            // cbHabitacion
            // 
            this.cbHabitacion.FormattingEnabled = true;
            this.cbHabitacion.Items.AddRange(new object[] {
            "Sencilla",
            "Doble",
            "Suite"});
            this.cbHabitacion.Location = new System.Drawing.Point(51, 210);
            this.cbHabitacion.Name = "cbHabitacion";
            this.cbHabitacion.Size = new System.Drawing.Size(214, 21);
            this.cbHabitacion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de habitacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Informacion Reserva";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dias a Hospedar";
            // 
            // tbNoches
            // 
            this.tbNoches.Location = new System.Drawing.Point(140, 241);
            this.tbNoches.Name = "tbNoches";
            this.tbNoches.Size = new System.Drawing.Size(125, 20);
            this.tbNoches.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "# Habitacion";
            // 
            // tbNumHab
            // 
            this.tbNumHab.Location = new System.Drawing.Point(140, 274);
            this.tbNumHab.Name = "tbNumHab";
            this.tbNumHab.Size = new System.Drawing.Size(125, 20);
            this.tbNumHab.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Habitaciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(625, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Reservas Activas";
            // 
            // listReservasOn
            // 
            this.listReservasOn.FormattingEnabled = true;
            this.listReservasOn.Location = new System.Drawing.Point(628, 71);
            this.listReservasOn.Name = "listReservasOn";
            this.listReservasOn.Size = new System.Drawing.Size(572, 485);
            this.listReservasOn.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1212, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(176, 41);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "CANCELAR RESERVACION";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbCancelacion
            // 
            this.lbCancelacion.AutoSize = true;
            this.lbCancelacion.Location = new System.Drawing.Point(1219, 74);
            this.lbCancelacion.Name = "lbCancelacion";
            this.lbCancelacion.Size = new System.Drawing.Size(164, 13);
            this.lbCancelacion.TabIndex = 20;
            this.lbCancelacion.Text = "Numero de habitacion a cancelar";
            this.lbCancelacion.Visible = false;
            // 
            // tbNumeroHabitaciones
            // 
            this.tbNumeroHabitaciones.Location = new System.Drawing.Point(1222, 97);
            this.tbNumeroHabitaciones.Name = "tbNumeroHabitaciones";
            this.tbNumeroHabitaciones.Size = new System.Drawing.Size(121, 20);
            this.tbNumeroHabitaciones.TabIndex = 21;
            this.tbNumeroHabitaciones.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1219, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cancelacion de reservas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DAS_Hotel.Properties.Resources.DAS_Hotel;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 790);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbNumeroHabitaciones);
            this.Controls.Add(this.lbCancelacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.listReservasOn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbNumHab);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbNoches);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbHabitacion);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbDui);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDui;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstHabitaciones;
        private System.Windows.Forms.ComboBox cbHabitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNoches;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNumHab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listReservasOn;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbCancelacion;
        private System.Windows.Forms.TextBox tbNumeroHabitaciones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

