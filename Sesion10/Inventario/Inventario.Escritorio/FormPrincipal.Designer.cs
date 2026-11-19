namespace Inventario.Escritorio
{
    partial class FormPrincipal
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
            dgvProductos = new DataGridView();
            txtBuscar = new TextBox();
            lblValor = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnVender = new Button();
            btnAgregarStock = new Button();
            nudCantidad = new NumericUpDown();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblEstadoCantidad = new ToolStripStatusLabel();
            lblEstadoHora = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            btnReportes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(56, 113);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(395, 188);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            dgvProductos.DataBindingComplete += dgvProductos_DataBindingComplete_1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(56, 50);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(56, 352);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(50, 20);
            lblValor.TabIndex = 2;
            lblValor.Text = "label1";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(235, 48);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(357, 50);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(657, 162);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(94, 29);
            btnVender.TabIndex = 5;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.Location = new Point(480, 253);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(94, 48);
            btnAgregarStock.TabIndex = 6;
            btnAgregarStock.Text = "Agregar Stock";
            btnAgregarStock.UseVisualStyleBackColor = true;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(492, 164);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(150, 27);
            nudCantidad.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(158, 26);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEstadoCantidad, lblEstadoHora });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblEstadoCantidad
            // 
            lblEstadoCantidad.Name = "lblEstadoCantidad";
            lblEstadoCantidad.Size = new Size(151, 20);
            lblEstadoCantidad.Text = "toolStripStatusLabel1";
            // 
            // lblEstadoHora
            // 
            lblEstadoHora.Name = "lblEstadoHora";
            lblEstadoHora.Size = new Size(151, 20);
            lblEstadoHora.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(656, 271);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(94, 29);
            btnReportes.TabIndex = 10;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReportes);
            Controls.Add(statusStrip1);
            Controls.Add(nudCantidad);
            Controls.Add(btnAgregarStock);
            Controls.Add(btnVender);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lblValor);
            Controls.Add(txtBuscar);
            Controls.Add(dgvProductos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private TextBox txtBuscar;
        private Label lblValor;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnVender;
        private Button btnAgregarStock;
        private NumericUpDown nudCantidad;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblEstadoCantidad;
        private ToolStripStatusLabel lblEstadoHora;
        private System.Windows.Forms.Timer timer1;
        private Button btnReportes;
    }
}
