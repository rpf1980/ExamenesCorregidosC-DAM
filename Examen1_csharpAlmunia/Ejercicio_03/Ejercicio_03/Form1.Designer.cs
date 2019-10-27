namespace Ejercicio_03
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idN1MuestraComplejo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.idN1ParteImaginaria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idN1ParteReal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idN2MuestraComplejo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.idN2ParteImaginaria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idN2ParteReal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.idTbSuma = new System.Windows.Forms.TextBox();
            this.idTbProducto = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idN1MuestraComplejo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.idN1ParteImaginaria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.idN1ParteReal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(105, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NÚMERO 1";
            // 
            // idN1MuestraComplejo
            // 
            this.idN1MuestraComplejo.Location = new System.Drawing.Point(29, 315);
            this.idN1MuestraComplejo.Name = "idN1MuestraComplejo";
            this.idN1MuestraComplejo.Size = new System.Drawing.Size(182, 22);
            this.idN1MuestraComplejo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "NÚMERO COMPLEJO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "MOSTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idN1ParteImaginaria
            // 
            this.idN1ParteImaginaria.Location = new System.Drawing.Point(29, 157);
            this.idN1ParteImaginaria.Name = "idN1ParteImaginaria";
            this.idN1ParteImaginaria.Size = new System.Drawing.Size(116, 22);
            this.idN1ParteImaginaria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "PARTE IMAGINARIA";
            // 
            // idN1ParteReal
            // 
            this.idN1ParteReal.Location = new System.Drawing.Point(29, 75);
            this.idN1ParteReal.Name = "idN1ParteReal";
            this.idN1ParteReal.Size = new System.Drawing.Size(116, 22);
            this.idN1ParteReal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARTE REAL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.idN2MuestraComplejo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.idN2ParteImaginaria);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.idN2ParteReal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(499, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 379);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NÚMERO 2";
            // 
            // idN2MuestraComplejo
            // 
            this.idN2MuestraComplejo.Location = new System.Drawing.Point(29, 315);
            this.idN2MuestraComplejo.Name = "idN2MuestraComplejo";
            this.idN2MuestraComplejo.Size = new System.Drawing.Size(182, 22);
            this.idN2MuestraComplejo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "NÚMERO COMPLEJO";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "MOSTRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idN2ParteImaginaria
            // 
            this.idN2ParteImaginaria.Location = new System.Drawing.Point(29, 157);
            this.idN2ParteImaginaria.Name = "idN2ParteImaginaria";
            this.idN2ParteImaginaria.Size = new System.Drawing.Size(116, 22);
            this.idN2ParteImaginaria.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "PARTE IMAGINARIA";
            // 
            // idN2ParteReal
            // 
            this.idN2ParteReal.Location = new System.Drawing.Point(29, 75);
            this.idN2ParteReal.Name = "idN2ParteReal";
            this.idN2ParteReal.Size = new System.Drawing.Size(116, 22);
            this.idN2ParteReal.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "PARTE REAL";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(847, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "SUMA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idTbSuma
            // 
            this.idTbSuma.Location = new System.Drawing.Point(847, 148);
            this.idTbSuma.Name = "idTbSuma";
            this.idTbSuma.Size = new System.Drawing.Size(191, 22);
            this.idTbSuma.TabIndex = 9;
            // 
            // idTbProducto
            // 
            this.idTbProducto.Location = new System.Drawing.Point(847, 270);
            this.idTbProducto.Name = "idTbProducto";
            this.idTbProducto.Size = new System.Drawing.Size(191, 22);
            this.idTbProducto.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(847, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "PRODUCTO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1090, 469);
            this.Controls.Add(this.idTbProducto);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.idTbSuma);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "NÚMEROS COMPLEJOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idN1MuestraComplejo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idN1ParteImaginaria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idN1ParteReal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox idN2MuestraComplejo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox idN2ParteImaginaria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idN2ParteReal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox idTbSuma;
        private System.Windows.Forms.TextBox idTbProducto;
        private System.Windows.Forms.Button button4;
    }
}

