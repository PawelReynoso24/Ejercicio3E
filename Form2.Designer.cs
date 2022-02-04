namespace Ejercicio3E
{
    partial class Form2
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
            this.textBoxNumCuenta = new System.Windows.Forms.TextBox();
            this.textBox2DPICliente = new System.Windows.Forms.TextBox();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelNumCuenta = new System.Windows.Forms.Label();
            this.labelDPICliente = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. de Cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DPI del Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo:";
            // 
            // textBoxNumCuenta
            // 
            this.textBoxNumCuenta.Location = new System.Drawing.Point(205, 57);
            this.textBoxNumCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNumCuenta.Name = "textBoxNumCuenta";
            this.textBoxNumCuenta.Size = new System.Drawing.Size(209, 26);
            this.textBoxNumCuenta.TabIndex = 3;
            // 
            // textBox2DPICliente
            // 
            this.textBox2DPICliente.Location = new System.Drawing.Point(205, 122);
            this.textBox2DPICliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2DPICliente.Name = "textBox2DPICliente";
            this.textBox2DPICliente.Size = new System.Drawing.Size(209, 26);
            this.textBox2DPICliente.TabIndex = 4;
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.Location = new System.Drawing.Point(205, 191);
            this.textBoxSaldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(209, 26);
            this.textBoxSaldo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(205, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 79);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ingresar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(504, 282);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 79);
            this.button2.TabIndex = 7;
            this.button2.Text = "Mostrar Datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelNumCuenta
            // 
            this.labelNumCuenta.AutoSize = true;
            this.labelNumCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCuenta.Location = new System.Drawing.Point(516, 60);
            this.labelNumCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumCuenta.Name = "labelNumCuenta";
            this.labelNumCuenta.Size = new System.Drawing.Size(18, 20);
            this.labelNumCuenta.TabIndex = 8;
            this.labelNumCuenta.Text = "0";
            // 
            // labelDPICliente
            // 
            this.labelDPICliente.AutoSize = true;
            this.labelDPICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDPICliente.Location = new System.Drawing.Point(516, 125);
            this.labelDPICliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDPICliente.Name = "labelDPICliente";
            this.labelDPICliente.Size = new System.Drawing.Size(18, 20);
            this.labelDPICliente.TabIndex = 9;
            this.labelDPICliente.Text = "0";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(516, 194);
            this.labelSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(40, 20);
            this.labelSaldo.TabIndex = 10;
            this.labelSaldo.Text = "0.00";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 427);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.labelDPICliente);
            this.Controls.Add(this.labelNumCuenta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.textBox2DPICliente);
            this.Controls.Add(this.textBoxNumCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumCuenta;
        private System.Windows.Forms.TextBox textBox2DPICliente;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelNumCuenta;
        private System.Windows.Forms.Label labelDPICliente;
        private System.Windows.Forms.Label labelSaldo;
    }
}