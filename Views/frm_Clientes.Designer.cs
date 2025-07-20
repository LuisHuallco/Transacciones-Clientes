namespace Transacciones.Views
{
    partial class frm_Clientes
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtSaldo = new TextBox();
            label3 = new Label();
            btnRegistrar = new Button();
            dgvClientes = new DataGridView();
            btnMostrar = new Button();
            label4 = new Label();
            btnEditar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 93);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(39, 128);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(416, 39);
            txtNombre.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(39, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(416, 39);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 184);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(39, 318);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(416, 39);
            txtSaldo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 283);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 4;
            label3.Text = "Saldo Inicial:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.CornflowerBlue;
            btnRegistrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnRegistrar.Location = new Point(23, 378);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(212, 69);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar Cliente";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(505, 93);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(740, 264);
            dgvClientes.TabIndex = 7;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.SeaGreen;
            btnMostrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMostrar.Location = new Point(774, 378);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(236, 69);
            btnMostrar.TabIndex = 8;
            btnMostrar.Text = "Mostrar Clientes";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(416, 9);
            label4.Name = "label4";
            label4.Size = new Size(389, 54);
            label4.TabIndex = 9;
            label4.Text = "Sistema de Clientes";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.IndianRed;
            btnEditar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEditar.Location = new Point(254, 378);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(212, 69);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGray;
            btnCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCancelar.Location = new Point(149, 467);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(212, 69);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frm_Clientes
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 559);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(label4);
            Controls.Add(btnMostrar);
            Controls.Add(dgvClientes);
            Controls.Add(btnRegistrar);
            Controls.Add(txtSaldo);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frm_Clientes";
            Text = "Form1";
            Load += frm_Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtSaldo;
        private Label label3;
        private Button btnRegistrar;
        private DataGridView dgvClientes;
        private Button btnMostrar;
        private Label label4;
        private Button btnEditar;
        private Button btnCancelar;
    }
}