namespace practica09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSaludo = new Label();
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            lblResultado = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            txtResultado = new TextBox();
            btnRestar = new Button();
            btnSumar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(598, 355);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(0, 20);
            lblSaludo.TabIndex = 3;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(114, 104);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(75, 20);
            lblNumero1.TabIndex = 4;
            lblNumero1.Text = "Numero 1";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(114, 170);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(75, 20);
            lblNumero2.TabIndex = 5;
            lblNumero2.Text = "Numero 2";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(114, 240);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(202, 104);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(125, 27);
            txtNumero1.TabIndex = 7;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(202, 163);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(125, 27);
            txtNumero2.TabIndex = 8;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(202, 237);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(125, 27);
            txtResultado.TabIndex = 9;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(495, 128);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(94, 29);
            btnRestar.TabIndex = 10;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(369, 128);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(94, 29);
            btnSumar.TabIndex = 11;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(369, 201);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(94, 29);
            btnMultiplicar.TabIndex = 12;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(495, 201);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(94, 29);
            btnDividir.TabIndex = 13;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSumar);
            Controls.Add(btnRestar);
            Controls.Add(txtResultado);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblResultado);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Controls.Add(lblSaludo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSaludo;
        private Label lblNumero1;
        private Label lblNumero2;
        private Label lblResultado;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private TextBox txtResultado;
        private Button btnRestar;
        private Button btnSumar;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}
