namespace Reto
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
            lblTitular = new Label();
            lblSaldo = new Label();
            nudMonto = new NumericUpDown();
            btnDepositar = new Button();
            btnRetirar = new Button();
            btnTransferir = new Button();
            lstMovimientos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            SuspendLayout();
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Location = new Point(59, 57);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(58, 20);
            lblTitular.TabIndex = 0;
            lblTitular.Text = "Titular: ";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(59, 134);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(70, 20);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "Saldo: $0";
            // 
            // nudMonto
            // 
            nudMonto.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMonto.Location = new Point(59, 228);
            nudMonto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(150, 27);
            nudMonto.TabIndex = 2;
            nudMonto.ThousandsSeparator = true;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(331, 57);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(94, 29);
            btnDepositar.TabIndex = 3;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(331, 130);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(94, 29);
            btnRetirar.TabIndex = 4;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(331, 226);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(94, 29);
            btnTransferir.TabIndex = 5;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // lstMovimientos
            // 
            lstMovimientos.FormattingEnabled = true;
            lstMovimientos.Location = new Point(483, 12);
            lstMovimientos.Name = "lstMovimientos";
            lstMovimientos.Size = new Size(305, 104);
            lstMovimientos.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstMovimientos);
            Controls.Add(btnTransferir);
            Controls.Add(btnRetirar);
            Controls.Add(btnDepositar);
            Controls.Add(nudMonto);
            Controls.Add(lblSaldo);
            Controls.Add(lblTitular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitular;
        private Label lblSaldo;
        private NumericUpDown nudMonto;
        private Button btnDepositar;
        private Button btnRetirar;
        private Button btnTransferir;
        private ListBox lstMovimientos;
    }
}
