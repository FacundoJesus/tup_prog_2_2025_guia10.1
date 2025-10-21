namespace Ejercicio1
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
            groupBox1 = new GroupBox();
            btnRecibirCorrespondencia = new Button();
            tbDireccion = new TextBox();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lsbVerSectorCarga = new ListBox();
            btnPrepararCamion = new Button();
            groupBox3 = new GroupBox();
            lsbListadoAEntregar = new ListBox();
            label7 = new Label();
            btnEntregarPaquete = new Button();
            btnIniciarReparto = new Button();
            groupBox4 = new GroupBox();
            lbDireccionEntrega = new Label();
            lbNombreEntrega = new Label();
            lbDNIEntrega = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRecibirCorrespondencia);
            groupBox1.Controls.Add(tbDireccion);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbDNI);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 294);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sector de atención al cliente";
            // 
            // btnRecibirCorrespondencia
            // 
            btnRecibirCorrespondencia.Location = new Point(95, 238);
            btnRecibirCorrespondencia.Name = "btnRecibirCorrespondencia";
            btnRecibirCorrespondencia.Size = new Size(124, 41);
            btnRecibirCorrespondencia.TabIndex = 6;
            btnRecibirCorrespondencia.Text = "Recibir Correspondencia";
            btnRecibirCorrespondencia.UseVisualStyleBackColor = true;
            btnRecibirCorrespondencia.Click += btnRecibirCorrespondencia_Click;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(95, 131);
            tbDireccion.Multiline = true;
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(124, 99);
            tbDireccion.TabIndex = 5;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(95, 72);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(124, 23);
            tbNombre.TabIndex = 4;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(95, 31);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(124, 23);
            tbDNI.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 134);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 75);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsbVerSectorCarga);
            groupBox2.Controls.Add(btnPrepararCamion);
            groupBox2.Location = new Point(265, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(264, 294);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Paquetes en el Sector de Embarque";
            // 
            // lsbVerSectorCarga
            // 
            lsbVerSectorCarga.FormattingEnabled = true;
            lsbVerSectorCarga.ItemHeight = 15;
            lsbVerSectorCarga.Location = new Point(18, 31);
            lsbVerSectorCarga.Name = "lsbVerSectorCarga";
            lsbVerSectorCarga.Size = new Size(229, 199);
            lsbVerSectorCarga.TabIndex = 8;
            // 
            // btnPrepararCamion
            // 
            btnPrepararCamion.Location = new Point(52, 238);
            btnPrepararCamion.Name = "btnPrepararCamion";
            btnPrepararCamion.Size = new Size(124, 41);
            btnPrepararCamion.TabIndex = 7;
            btnPrepararCamion.Text = "Preparar Camión";
            btnPrepararCamion.UseVisualStyleBackColor = true;
            btnPrepararCamion.Click += btnPrepararCamion_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lsbListadoAEntregar);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(btnEntregarPaquete);
            groupBox3.Controls.Add(btnIniciarReparto);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(535, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(245, 294);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tarea de reparto";
            // 
            // lsbListadoAEntregar
            // 
            lsbListadoAEntregar.FormattingEnabled = true;
            lsbListadoAEntregar.ItemHeight = 15;
            lsbListadoAEntregar.Location = new Point(15, 216);
            lsbListadoAEntregar.Name = "lsbListadoAEntregar";
            lsbListadoAEntregar.Size = new Size(204, 64);
            lsbListadoAEntregar.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 198);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 10;
            label7.Text = "Listado a entregar:";
            // 
            // btnEntregarPaquete
            // 
            btnEntregarPaquete.Enabled = false;
            btnEntregarPaquete.Location = new Point(148, 144);
            btnEntregarPaquete.Name = "btnEntregarPaquete";
            btnEntregarPaquete.Size = new Size(82, 41);
            btnEntregarPaquete.TabIndex = 11;
            btnEntregarPaquete.Text = "Entregar Paquete";
            btnEntregarPaquete.UseVisualStyleBackColor = true;
            btnEntregarPaquete.Click += btnEntregarPaquete_Click;
            // 
            // btnIniciarReparto
            // 
            btnIniciarReparto.Location = new Point(15, 144);
            btnIniciarReparto.Name = "btnIniciarReparto";
            btnIniciarReparto.Size = new Size(82, 41);
            btnIniciarReparto.TabIndex = 9;
            btnIniciarReparto.Text = "Iniciar Reparto";
            btnIniciarReparto.UseVisualStyleBackColor = true;
            btnIniciarReparto.Click += btnIniciarReparto_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbDireccionEntrega);
            groupBox4.Controls.Add(lbNombreEntrega);
            groupBox4.Controls.Add(lbDNIEntrega);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(15, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(215, 116);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Próximo a entregar";
            // 
            // lbDireccionEntrega
            // 
            lbDireccionEntrega.BackColor = SystemColors.ActiveBorder;
            lbDireccionEntrega.Location = new Point(98, 88);
            lbDireccionEntrega.Name = "lbDireccionEntrega";
            lbDireccionEntrega.Size = new Size(100, 15);
            lbDireccionEntrega.TabIndex = 12;
            // 
            // lbNombreEntrega
            // 
            lbNombreEntrega.BackColor = SystemColors.ActiveBorder;
            lbNombreEntrega.Location = new Point(98, 58);
            lbNombreEntrega.Name = "lbNombreEntrega";
            lbNombreEntrega.Size = new Size(100, 15);
            lbNombreEntrega.TabIndex = 11;
            // 
            // lbDNIEntrega
            // 
            lbDNIEntrega.BackColor = SystemColors.ActiveBorder;
            lbDNIEntrega.Location = new Point(98, 28);
            lbDNIEntrega.Name = "lbDNIEntrega";
            lbDNIEntrega.Size = new Size(100, 15);
            lbDNIEntrega.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 28);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 7;
            label6.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 88);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Dirección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 59);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "Nombre:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 318);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRecibirCorrespondencia;
        private TextBox tbDireccion;
        private TextBox tbNombre;
        private TextBox tbDNI;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnPrepararCamion;
        private ListBox lsbVerSectorCarga;
        private GroupBox groupBox3;
        private ListBox lsbListadoAEntregar;
        private Label label7;
        private Button btnEntregarPaquete;
        private Button btnIniciarReparto;
        private GroupBox groupBox4;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label lbDireccionEntrega;
        private Label lbNombreEntrega;
        private Label lbDNIEntrega;
    }
}
