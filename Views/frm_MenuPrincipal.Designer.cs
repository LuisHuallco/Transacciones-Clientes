namespace Transacciones.Views
{
    partial class frm_MenuPrincipal
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
            btnClientes = new Button();
            btnTransacciones = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.DodgerBlue;
            btnClientes.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btnClientes.Location = new Point(62, 206);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(318, 144);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "\U0001f9d1‍💼 Gestión de Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnTransacciones
            // 
            btnTransacciones.BackColor = Color.MediumSeaGreen;
            btnTransacciones.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            btnTransacciones.Location = new Point(422, 206);
            btnTransacciones.Name = "btnTransacciones";
            btnTransacciones.Size = new Size(318, 144);
            btnTransacciones.TabIndex = 1;
            btnTransacciones.Text = "💸 Transacciones";
            btnTransacciones.UseVisualStyleBackColor = false;
            btnTransacciones.Click += btnTransacciones_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 80);
            label1.Name = "label1";
            label1.Size = new Size(383, 54);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Gestion";
            // 
            // frm_MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnTransacciones);
            Controls.Add(btnClientes);
            Name = "frm_MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private Button btnTransacciones;
        private Label label1;
    }
}