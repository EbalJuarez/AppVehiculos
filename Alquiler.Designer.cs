namespace AppVehiculos
{
    partial class Alquiler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNit = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaca = new System.Windows.Forms.ComboBox();
            this.monthCalendarAlquiler = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarDevolucion = new System.Windows.Forms.MonthCalendar();
            this.textBoxKmRecorrido = new System.Windows.Forms.TextBox();
            this.buttonRegAl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el NIT del arredentario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione la placa del vehiculo que rentara:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = " Seleccione la fecha de alquiler:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleccione la fecha de devolucion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingrese los Km recorridos:";
            // 
            // comboBoxNit
            // 
            this.comboBoxNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNit.FormattingEnabled = true;
            this.comboBoxNit.Location = new System.Drawing.Point(288, 39);
            this.comboBoxNit.Name = "comboBoxNit";
            this.comboBoxNit.Size = new System.Drawing.Size(124, 28);
            this.comboBoxNit.TabIndex = 5;
            // 
            // comboBoxPlaca
            // 
            this.comboBoxPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlaca.FormattingEnabled = true;
            this.comboBoxPlaca.Location = new System.Drawing.Point(354, 86);
            this.comboBoxPlaca.Name = "comboBoxPlaca";
            this.comboBoxPlaca.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPlaca.TabIndex = 6;
            // 
            // monthCalendarAlquiler
            // 
            this.monthCalendarAlquiler.Location = new System.Drawing.Point(34, 160);
            this.monthCalendarAlquiler.Name = "monthCalendarAlquiler";
            this.monthCalendarAlquiler.TabIndex = 7;
            // 
            // monthCalendarDevolucion
            // 
            this.monthCalendarDevolucion.Location = new System.Drawing.Point(354, 160);
            this.monthCalendarDevolucion.Name = "monthCalendarDevolucion";
            this.monthCalendarDevolucion.TabIndex = 8;
            // 
            // textBoxKmRecorrido
            // 
            this.textBoxKmRecorrido.Location = new System.Drawing.Point(228, 333);
            this.textBoxKmRecorrido.Name = "textBoxKmRecorrido";
            this.textBoxKmRecorrido.Size = new System.Drawing.Size(100, 20);
            this.textBoxKmRecorrido.TabIndex = 9;
            // 
            // buttonRegAl
            // 
            this.buttonRegAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegAl.Location = new System.Drawing.Point(527, 383);
            this.buttonRegAl.Name = "buttonRegAl";
            this.buttonRegAl.Size = new System.Drawing.Size(75, 25);
            this.buttonRegAl.TabIndex = 10;
            this.buttonRegAl.Text = "Alquilar";
            this.buttonRegAl.UseVisualStyleBackColor = true;
            this.buttonRegAl.Click += new System.EventHandler(this.buttonRegAl_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Regresar al menu principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRegAl);
            this.Controls.Add(this.textBoxKmRecorrido);
            this.Controls.Add(this.monthCalendarDevolucion);
            this.Controls.Add(this.monthCalendarAlquiler);
            this.Controls.Add(this.comboBoxPlaca);
            this.Controls.Add(this.comboBoxNit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alquiler";
            this.Text = "Alquiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxNit;
        private System.Windows.Forms.ComboBox comboBoxPlaca;
        private System.Windows.Forms.MonthCalendar monthCalendarAlquiler;
        private System.Windows.Forms.MonthCalendar monthCalendarDevolucion;
        private System.Windows.Forms.TextBox textBoxKmRecorrido;
        private System.Windows.Forms.Button buttonRegAl;
        private System.Windows.Forms.Button button1;
    }
}