namespace Reto
{
    partial class FormPin
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
            txtPin = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // txtPin
            // 
            txtPin.Location = new Point(95, 91);
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.Size = new Size(125, 27);
            txtPin.TabIndex = 0;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(275, 91);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FormPin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(txtPin);
            Name = "FormPin";
            Text = "FormPin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPin;
        private Button btnIngresar;
    }
}