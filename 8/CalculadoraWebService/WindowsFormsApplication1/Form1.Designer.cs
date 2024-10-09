namespace WindowsFormsApplication1
{
    partial class CalculadoraConClase
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.EntradaC = new System.Windows.Forms.TextBox();
            this.Uno = new System.Windows.Forms.Button();
            this.Dos = new System.Windows.Forms.Button();
            this.Tres = new System.Windows.Forms.Button();
            this.Cuatro = new System.Windows.Forms.Button();
            this.Cinco = new System.Windows.Forms.Button();
            this.Seis = new System.Windows.Forms.Button();
            this.Siete = new System.Windows.Forms.Button();
            this.Ocho = new System.Windows.Forms.Button();
            this.Nueve = new System.Windows.Forms.Button();
            this.Cero = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Multipli = new System.Windows.Forms.Button();
            this.Divisi = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.Infi = new System.Windows.Forms.Button();
            this.Prefi = new System.Windows.Forms.Button();
            this.Espa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EntradaC
            // 
            this.EntradaC.Enabled = false;
            this.EntradaC.Location = new System.Drawing.Point(12, 12);
            this.EntradaC.Name = "EntradaC";
            this.EntradaC.Size = new System.Drawing.Size(260, 20);
            this.EntradaC.TabIndex = 0;
            // 
            // Uno
            // 
            this.Uno.Location = new System.Drawing.Point(15, 48);
            this.Uno.Name = "Uno";
            this.Uno.Size = new System.Drawing.Size(75, 23);
            this.Uno.TabIndex = 1;
            this.Uno.Text = "1";
            this.Uno.UseVisualStyleBackColor = true;
            this.Uno.Click += new System.EventHandler(this.composicion_click);
            // 
            // Dos
            // 
            this.Dos.Location = new System.Drawing.Point(107, 48);
            this.Dos.Name = "Dos";
            this.Dos.Size = new System.Drawing.Size(75, 23);
            this.Dos.TabIndex = 2;
            this.Dos.Text = "2";
            this.Dos.UseVisualStyleBackColor = true;
            this.Dos.Click += new System.EventHandler(this.composicion_click);
            // 
            // Tres
            // 
            this.Tres.Location = new System.Drawing.Point(197, 48);
            this.Tres.Name = "Tres";
            this.Tres.Size = new System.Drawing.Size(75, 23);
            this.Tres.TabIndex = 3;
            this.Tres.Text = "3";
            this.Tres.UseVisualStyleBackColor = true;
            this.Tres.Click += new System.EventHandler(this.composicion_click);
            // 
            // Cuatro
            // 
            this.Cuatro.Location = new System.Drawing.Point(15, 88);
            this.Cuatro.Name = "Cuatro";
            this.Cuatro.Size = new System.Drawing.Size(75, 23);
            this.Cuatro.TabIndex = 4;
            this.Cuatro.Text = "4";
            this.Cuatro.UseVisualStyleBackColor = true;
            this.Cuatro.Click += new System.EventHandler(this.composicion_click);
            // 
            // Cinco
            // 
            this.Cinco.Location = new System.Drawing.Point(107, 88);
            this.Cinco.Name = "Cinco";
            this.Cinco.Size = new System.Drawing.Size(75, 23);
            this.Cinco.TabIndex = 5;
            this.Cinco.Text = "5";
            this.Cinco.UseVisualStyleBackColor = true;
            this.Cinco.Click += new System.EventHandler(this.composicion_click);
            // 
            // Seis
            // 
            this.Seis.Location = new System.Drawing.Point(197, 88);
            this.Seis.Name = "Seis";
            this.Seis.Size = new System.Drawing.Size(75, 23);
            this.Seis.TabIndex = 6;
            this.Seis.Text = "6";
            this.Seis.UseVisualStyleBackColor = true;
            this.Seis.Click += new System.EventHandler(this.composicion_click);
            // 
            // Siete
            // 
            this.Siete.Location = new System.Drawing.Point(15, 130);
            this.Siete.Name = "Siete";
            this.Siete.Size = new System.Drawing.Size(75, 23);
            this.Siete.TabIndex = 7;
            this.Siete.Text = "7";
            this.Siete.UseVisualStyleBackColor = true;
            this.Siete.Click += new System.EventHandler(this.composicion_click);
            // 
            // Ocho
            // 
            this.Ocho.Location = new System.Drawing.Point(107, 130);
            this.Ocho.Name = "Ocho";
            this.Ocho.Size = new System.Drawing.Size(75, 23);
            this.Ocho.TabIndex = 8;
            this.Ocho.Text = "8";
            this.Ocho.UseVisualStyleBackColor = true;
            this.Ocho.Click += new System.EventHandler(this.composicion_click);
            // 
            // Nueve
            // 
            this.Nueve.Location = new System.Drawing.Point(197, 130);
            this.Nueve.Name = "Nueve";
            this.Nueve.Size = new System.Drawing.Size(75, 23);
            this.Nueve.TabIndex = 9;
            this.Nueve.Text = "9";
            this.Nueve.UseVisualStyleBackColor = true;
            this.Nueve.Click += new System.EventHandler(this.composicion_click);
            // 
            // Cero
            // 
            this.Cero.Location = new System.Drawing.Point(107, 168);
            this.Cero.Name = "Cero";
            this.Cero.Size = new System.Drawing.Size(75, 23);
            this.Cero.TabIndex = 10;
            this.Cero.Text = "0";
            this.Cero.UseVisualStyleBackColor = true;
            this.Cero.Click += new System.EventHandler(this.composicion_click);
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(15, 205);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 23);
            this.Suma.TabIndex = 11;
            this.Suma.Text = "+";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.composicion_click);
            // 
            // Resta
            // 
            this.Resta.Location = new System.Drawing.Point(197, 205);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(75, 23);
            this.Resta.TabIndex = 12;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.composicion_click);
            // 
            // Multipli
            // 
            this.Multipli.Location = new System.Drawing.Point(105, 243);
            this.Multipli.Name = "Multipli";
            this.Multipli.Size = new System.Drawing.Size(75, 23);
            this.Multipli.TabIndex = 13;
            this.Multipli.Text = "*";
            this.Multipli.UseVisualStyleBackColor = true;
            this.Multipli.Click += new System.EventHandler(this.composicion_click);
            // 
            // Divisi
            // 
            this.Divisi.Location = new System.Drawing.Point(105, 205);
            this.Divisi.Name = "Divisi";
            this.Divisi.Size = new System.Drawing.Size(75, 23);
            this.Divisi.TabIndex = 14;
            this.Divisi.Text = "/";
            this.Divisi.UseVisualStyleBackColor = true;
            this.Divisi.Click += new System.EventHandler(this.composicion_click);
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(15, 243);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(75, 23);
            this.Clean.TabIndex = 15;
            this.Clean.Text = "Clear";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Igual
            // 
            this.Igual.Location = new System.Drawing.Point(105, 282);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(75, 23);
            this.Igual.TabIndex = 16;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // Infi
            // 
            this.Infi.Location = new System.Drawing.Point(15, 168);
            this.Infi.Name = "Infi";
            this.Infi.Size = new System.Drawing.Size(75, 23);
            this.Infi.TabIndex = 17;
            this.Infi.Text = "Infija";
            this.Infi.UseVisualStyleBackColor = true;
            this.Infi.Click += new System.EventHandler(this.button17_Click);
            // 
            // Prefi
            // 
            this.Prefi.Location = new System.Drawing.Point(197, 168);
            this.Prefi.Name = "Prefi";
            this.Prefi.Size = new System.Drawing.Size(75, 23);
            this.Prefi.TabIndex = 19;
            this.Prefi.Text = "Prefija";
            this.Prefi.UseVisualStyleBackColor = true;
            this.Prefi.Click += new System.EventHandler(this.button19_Click);
            // 
            // Espa
            // 
            this.Espa.Location = new System.Drawing.Point(197, 243);
            this.Espa.Name = "Espa";
            this.Espa.Size = new System.Drawing.Size(75, 23);
            this.Espa.TabIndex = 20;
            this.Espa.Text = "Space";
            this.Espa.UseVisualStyleBackColor = true;
            this.Espa.Click += new System.EventHandler(this.button20_Click);
            // 
            // CalculadoraConClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 327);
            this.Controls.Add(this.Espa);
            this.Controls.Add(this.Prefi);
            this.Controls.Add(this.Infi);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Divisi);
            this.Controls.Add(this.Multipli);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Cero);
            this.Controls.Add(this.Nueve);
            this.Controls.Add(this.Ocho);
            this.Controls.Add(this.Siete);
            this.Controls.Add(this.Seis);
            this.Controls.Add(this.Cinco);
            this.Controls.Add(this.Cuatro);
            this.Controls.Add(this.Tres);
            this.Controls.Add(this.Dos);
            this.Controls.Add(this.Uno);
            this.Controls.Add(this.EntradaC);
            this.Name = "CalculadoraConClase";
            this.Text = "CalculadoraConClase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EntradaC;
        private System.Windows.Forms.Button Uno;
        private System.Windows.Forms.Button Dos;
        private System.Windows.Forms.Button Tres;
        private System.Windows.Forms.Button Cuatro;
        private System.Windows.Forms.Button Cinco;
        private System.Windows.Forms.Button Seis;
        private System.Windows.Forms.Button Siete;
        private System.Windows.Forms.Button Ocho;
        private System.Windows.Forms.Button Nueve;
        private System.Windows.Forms.Button Cero;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Multipli;
        private System.Windows.Forms.Button Divisi;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button Infi;
        private System.Windows.Forms.Button Prefi;
        private System.Windows.Forms.Button Espa;
    }
}

