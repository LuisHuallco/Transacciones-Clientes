namespace Transacciones.Views
{
    partial class frm_Transacciones
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
            txtIdOrigen = new TextBox();
            txtIdDestino = new TextBox();
            label2 = new Label();
            txtMonto = new TextBox();
            label3 = new Label();
            btnTransferir = new Button();
            btnEliminar = new Button();
            txtEliminar = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 98);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 0;
            label1.Text = "ID Origen:";
            // 
            // txtIdOrigen
            // 
            txtIdOrigen.Location = new Point(46, 133);
            txtIdOrigen.Name = "txtIdOrigen";
            txtIdOrigen.Size = new Size(377, 39);
            txtIdOrigen.TabIndex = 1;
            // 
            // txtIdDestino
            // 
            txtIdDestino.Location = new Point(46, 215);
            txtIdDestino.Name = "txtIdDestino";
            txtIdDestino.Size = new Size(377, 39);
            txtIdDestino.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 180);
            label2.Name = "label2";
            label2.Size = new Size(131, 32);
            label2.TabIndex = 2;
            label2.Text = "ID Destino:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(46, 297);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(377, 39);
            txtMonto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 262);
            label3.Name = "label3";
            label3.Size = new Size(212, 32);
            label3.TabIndex = 4;
            label3.Text = "Monto a transferir:";
            // 
            // btnTransferir
            // 
            btnTransferir.BackColor = Color.CornflowerBlue;
            btnTransferir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnTransferir.Location = new Point(101, 360);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(260, 73);
            btnTransferir.TabIndex = 6;
            btnTransferir.Text = "Transferir Saldo";
            btnTransferir.UseVisualStyleBackColor = false;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEliminar.Location = new Point(616, 360);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(260, 73);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar Cliente";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtEliminar
            // 
            txtEliminar.Location = new Point(533, 297);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(377, 39);
            txtEliminar.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(533, 262);
            label4.Name = "label4";
            label4.Size = new Size(236, 32);
            label4.TabIndex = 9;
            label4.Text = "ID Cliente a eliminar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(315, 23);
            label5.Name = "label5";
            label5.Size = new Size(454, 54);
            label5.TabIndex = 10;
            label5.Text = "Gestion de Transaccion";
            // 
            // frm_Transacciones
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 516);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEliminar);
            Controls.Add(btnEliminar);
            Controls.Add(btnTransferir);
            Controls.Add(txtMonto);
            Controls.Add(label3);
            Controls.Add(txtIdDestino);
            Controls.Add(label2);
            Controls.Add(txtIdOrigen);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frm_Transacciones";
            Text = "frm_Transacciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdOrigen;
        private TextBox txtIdDestino;
        private Label label2;
        private TextBox txtMonto;
        private Label label3;
        private Button btnTransferir;
        private Button btnEliminar;
        private TextBox txtEliminar;
        private Label label4;
        private Label label5;
    }
}
