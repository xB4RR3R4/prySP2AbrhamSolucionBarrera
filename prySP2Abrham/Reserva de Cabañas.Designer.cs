namespace prySP2Abrham
{
    partial class Reserva_de_Cabañas
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
            gpbList = new GroupBox();
            lblTipo = new Label();
            label2 = new Label();
            label3 = new Label();
            gpbAddicionales = new GroupBox();
            gpbPago = new GroupBox();
            gpbTitular = new GroupBox();
            btnAceptar = new Button();
            gpbList.SuspendLayout();
            SuspendLayout();
            // 
            // gpbList
            // 
            gpbList.Controls.Add(label3);
            gpbList.Controls.Add(label2);
            gpbList.Controls.Add(lblTipo);
            gpbList.Location = new Point(12, 22);
            gpbList.Name = "gpbList";
            gpbList.Size = new Size(533, 93);
            gpbList.TabIndex = 0;
            gpbList.TabStop = false;
            gpbList.Text = "Lista de Cabañas";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(34, 46);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            lblTipo.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 46);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Personas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 46);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Dias";
            // 
            // gpbAddicionales
            // 
            gpbAddicionales.Location = new Point(17, 135);
            gpbAddicionales.Name = "gpbAddicionales";
            gpbAddicionales.Size = new Size(200, 102);
            gpbAddicionales.TabIndex = 1;
            gpbAddicionales.TabStop = false;
            gpbAddicionales.Text = "Adicionales";
            // 
            // gpbPago
            // 
            gpbPago.Location = new Point(223, 135);
            gpbPago.Name = "gpbPago";
            gpbPago.Size = new Size(324, 100);
            gpbPago.TabIndex = 2;
            gpbPago.TabStop = false;
            gpbPago.Text = "Formas de Pago";
            // 
            // gpbTitular
            // 
            gpbTitular.Location = new Point(17, 255);
            gpbTitular.Name = "gpbTitular";
            gpbTitular.Size = new Size(528, 143);
            gpbTitular.TabIndex = 3;
            gpbTitular.TabStop = false;
            gpbTitular.Text = "Titular de la Reserva";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(427, 418);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(118, 28);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // Reserva_de_Cabañas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 469);
            Controls.Add(btnAceptar);
            Controls.Add(gpbTitular);
            Controls.Add(gpbPago);
            Controls.Add(gpbAddicionales);
            Controls.Add(gpbList);
            Name = "Reserva_de_Cabañas";
            Text = "Reserva_de_Cabañas";
            Load += Reserva_de_Cabañas_Load;
            gpbList.ResumeLayout(false);
            gpbList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbList;
        private Label label3;
        private Label label2;
        private Label lblTipo;
        private GroupBox gpbAddicionales;
        private GroupBox gpbPago;
        private GroupBox gpbTitular;
        private Button btnAceptar;
    }
}