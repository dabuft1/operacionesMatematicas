namespace operacionesMatematicas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.btnsumar = new System.Windows.Forms.Button();
            this.btnrestar = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.Location = new System.Drawing.Point(153, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones Matemáticas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el primer numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa el segundo numero";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtnumero1.Location = new System.Drawing.Point(382, 94);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(113, 38);
            this.txtnumero1.TabIndex = 3;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtnumero2.Location = new System.Drawing.Point(382, 146);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(113, 38);
            this.txtnumero2.TabIndex = 4;
            // 
            // btnsumar
            // 
            this.btnsumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnsumar.Location = new System.Drawing.Point(94, 230);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(117, 59);
            this.btnsumar.TabIndex = 5;
            this.btnsumar.Text = "Sumar";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // btnrestar
            // 
            this.btnrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnrestar.Location = new System.Drawing.Point(237, 230);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(117, 59);
            this.btnrestar.TabIndex = 6;
            this.btnrestar.Text = "Restar";
            this.btnrestar.UseVisualStyleBackColor = true;
            this.btnrestar.Click += new System.EventHandler(this.btnrestar_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnmultiplicar.Location = new System.Drawing.Point(394, 230);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(150, 59);
            this.btnmultiplicar.TabIndex = 7;
            this.btnmultiplicar.Text = "Multiplicar";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btndividir
            // 
            this.btndividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btndividir.Location = new System.Drawing.Point(570, 230);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(117, 59);
            this.btndividir.TabIndex = 8;
            this.btndividir.Text = "Dividir";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(189, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultado =";
            this.label4.Visible = false;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblresultado.Location = new System.Drawing.Point(376, 337);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(29, 31);
            this.lblresultado.TabIndex = 10;
            this.lblresultado.Text = "0";
            this.lblresultado.Visible = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnlimpiar.Location = new System.Drawing.Point(580, 379);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(150, 59);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Button btnrestar;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

