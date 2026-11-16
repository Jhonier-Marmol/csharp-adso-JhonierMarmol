namespace Practica2
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
            components = new System.ComponentModel.Container();
            txtNombre = new TextBox();
            nudEdad = new NumericUpDown();
            cmbPrograma = new ComboBox();
            rdbManana = new RadioButton();
            rdbTarde = new RadioButton();
            chkTerminos = new CheckBox();
            btnInscribir = new Button();
            listInscritos = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(38, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 27);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(38, 134);
            nudEdad.Minimum = new decimal(new int[] { 14, 0, 0, 0 });
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(150, 27);
            nudEdad.TabIndex = 1;
            nudEdad.Value = new decimal(new int[] { 14, 0, 0, 0 });
            // 
            // cmbPrograma
            // 
            cmbPrograma.FormattingEnabled = true;
            cmbPrograma.Items.AddRange(new object[] { "ADSO", "Multimedia", "Contabilidad" });
            cmbPrograma.Location = new Point(37, 210);
            cmbPrograma.Name = "cmbPrograma";
            cmbPrograma.Size = new Size(151, 28);
            cmbPrograma.TabIndex = 2;
            cmbPrograma.Text = "Elige tu carrera";
            // 
            // rdbManana
            // 
            rdbManana.AutoSize = true;
            rdbManana.Location = new Point(286, 214);
            rdbManana.Name = "rdbManana";
            rdbManana.Size = new Size(83, 24);
            rdbManana.TabIndex = 3;
            rdbManana.TabStop = true;
            rdbManana.Text = "Mañana";
            rdbManana.UseVisualStyleBackColor = true;
            // 
            // rdbTarde
            // 
            rdbTarde.AutoSize = true;
            rdbTarde.Location = new Point(414, 214);
            rdbTarde.Name = "rdbTarde";
            rdbTarde.Size = new Size(66, 24);
            rdbTarde.TabIndex = 4;
            rdbTarde.TabStop = true;
            rdbTarde.Text = "Tarde";
            rdbTarde.UseVisualStyleBackColor = true;
            // 
            // chkTerminos
            // 
            chkTerminos.AutoSize = true;
            chkTerminos.Location = new Point(37, 307);
            chkTerminos.Name = "chkTerminos";
            chkTerminos.Size = new Size(258, 24);
            chkTerminos.TabIndex = 5;
            chkTerminos.Text = "Acepto los terminos y condiciones";
            chkTerminos.UseVisualStyleBackColor = true;
            // 
            // btnInscribir
            // 
            btnInscribir.Font = new Font("Segoe UI", 9F);
            btnInscribir.Location = new Point(38, 381);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(167, 40);
            btnInscribir.TabIndex = 6;
            btnInscribir.Text = "Inscribirme";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // listInscritos
            // 
            listInscritos.FormattingEnabled = true;
            listInscritos.Location = new Point(559, 12);
            listInscritos.Name = "listInscritos";
            listInscritos.Size = new Size(229, 104);
            listInscritos.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listInscritos);
            Controls.Add(btnInscribir);
            Controls.Add(chkTerminos);
            Controls.Add(rdbTarde);
            Controls.Add(rdbManana);
            Controls.Add(cmbPrograma);
            Controls.Add(nudEdad);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private NumericUpDown nudEdad;
        private ComboBox cmbPrograma;
        private RadioButton rdbManana;
        private RadioButton rdbTarde;
        private CheckBox chkTerminos;
        private Button btnInscribir;
        private ListBox listInscritos;
        private ErrorProvider errorProvider1;
    }
}
