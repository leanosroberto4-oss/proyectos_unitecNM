namespace proyecto_final
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelEstado = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelDistancia = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelEstado2 = new System.Windows.Forms.Label();
            this.panelColor.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "COM5";
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(73, 100);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(107, 23);
            this.buttonConectar.TabIndex = 1;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Desconectar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelColor.Controls.Add(this.labelEstado);
            this.panelColor.Controls.Add(this.comboBox1);
            this.panelColor.Controls.Add(this.button2);
            this.panelColor.Controls.Add(this.buttonConectar);
            this.panelColor.Location = new System.Drawing.Point(34, 142);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(316, 279);
            this.panelColor.TabIndex = 3;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(75, 29);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(50, 16);
            this.labelEstado.TabIndex = 3;
            this.labelEstado.Text = "Estado";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(370, 270);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(397, 132);
            this.progressBar1.TabIndex = 4;
            // 
            // labelDistancia
            // 
            this.labelDistancia.AutoSize = true;
            this.labelDistancia.Location = new System.Drawing.Point(421, 182);
            this.labelDistancia.Name = "labelDistancia";
            this.labelDistancia.Size = new System.Drawing.Size(66, 16);
            this.labelDistancia.TabIndex = 5;
            this.labelDistancia.Text = "Distancia:\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(34, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 100);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingenieros Electromecanicos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "Omar Alonso Mendez Salvador\r\nRoberto Leaños Lopez\r\nEduardo Alvarado Ramirez\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::proyecto_final.Properties.Resources.integrantes_imagen;
            this.pictureBox1.Image = global::proyecto_final.Properties.Resources.integrantes_imagen;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // labelEstado2
            // 
            this.labelEstado2.AutoSize = true;
            this.labelEstado2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelEstado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelEstado2.ForeColor = System.Drawing.Color.Black;
            this.labelEstado2.Location = new System.Drawing.Point(456, 208);
            this.labelEstado2.Name = "labelEstado2";
            this.labelEstado2.Size = new System.Drawing.Size(109, 39);
            this.labelEstado2.TabIndex = 7;
            this.labelEstado2.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEstado2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelDistancia);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panelColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelColor.ResumeLayout(false);
            this.panelColor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelDistancia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelEstado2;
    }
}

