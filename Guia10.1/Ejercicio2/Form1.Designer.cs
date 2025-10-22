namespace Ejercicio2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbMotivo = new TextBox();
            tbNombre = new TextBox();
            btnRegistrarReclamo = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            lsbReclamos = new ListBox();
            btnCrearOrdenTrabajo = new Button();
            groupBox3 = new GroupBox();
            btnEjecutarOrdenTrabajo = new Button();
            lsbTrabajosEjecutados = new ListBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarReclamo);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbMotivo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 320);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recepción de Reclamos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 48);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos del reclamo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 80);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 129);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Motivo:";
            // 
            // tbMotivo
            // 
            tbMotivo.Location = new Point(71, 129);
            tbMotivo.Multiline = true;
            tbMotivo.Name = "tbMotivo";
            tbMotivo.ScrollBars = ScrollBars.Vertical;
            tbMotivo.Size = new Size(201, 120);
            tbMotivo.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(71, 77);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(201, 23);
            tbNombre.TabIndex = 4;
            // 
            // btnRegistrarReclamo
            // 
            btnRegistrarReclamo.Location = new Point(104, 255);
            btnRegistrarReclamo.Name = "btnRegistrarReclamo";
            btnRegistrarReclamo.Size = new Size(103, 47);
            btnRegistrarReclamo.TabIndex = 5;
            btnRegistrarReclamo.Text = "Registrar Reclamo";
            btnRegistrarReclamo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCrearOrdenTrabajo);
            groupBox2.Controls.Add(lsbReclamos);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(308, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 320);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Planificar Trabajo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 48);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 6;
            label4.Text = "Lista de reclamos";
            // 
            // lsbReclamos
            // 
            lsbReclamos.FormattingEnabled = true;
            lsbReclamos.ItemHeight = 15;
            lsbReclamos.Location = new Point(17, 80);
            lsbReclamos.Name = "lsbReclamos";
            lsbReclamos.Size = new Size(255, 169);
            lsbReclamos.TabIndex = 7;
            // 
            // btnCrearOrdenTrabajo
            // 
            btnCrearOrdenTrabajo.Location = new Point(93, 255);
            btnCrearOrdenTrabajo.Name = "btnCrearOrdenTrabajo";
            btnCrearOrdenTrabajo.Size = new Size(103, 47);
            btnCrearOrdenTrabajo.TabIndex = 6;
            btnCrearOrdenTrabajo.Text = "Crear Orden De Trabajo";
            btnCrearOrdenTrabajo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEjecutarOrdenTrabajo);
            groupBox3.Controls.Add(lsbTrabajosEjecutados);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(604, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(290, 320);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ordenes de trabajo";
            // 
            // btnEjecutarOrdenTrabajo
            // 
            btnEjecutarOrdenTrabajo.Location = new Point(93, 255);
            btnEjecutarOrdenTrabajo.Name = "btnEjecutarOrdenTrabajo";
            btnEjecutarOrdenTrabajo.Size = new Size(103, 47);
            btnEjecutarOrdenTrabajo.TabIndex = 6;
            btnEjecutarOrdenTrabajo.Text = "Ejecutar Orden de Trabajo";
            btnEjecutarOrdenTrabajo.UseVisualStyleBackColor = true;
            // 
            // lsbTrabajosEjecutados
            // 
            lsbTrabajosEjecutados.FormattingEnabled = true;
            lsbTrabajosEjecutados.ItemHeight = 15;
            lsbTrabajosEjecutados.Location = new Point(17, 80);
            lsbTrabajosEjecutados.Name = "lsbTrabajosEjecutados";
            lsbTrabajosEjecutados.Size = new Size(255, 169);
            lsbTrabajosEjecutados.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 48);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 6;
            label5.Text = "Trabajos ejecutados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 347);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistrarReclamo;
        private TextBox tbNombre;
        private TextBox tbMotivo;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private Button btnCrearOrdenTrabajo;
        private ListBox lsbReclamos;
        private GroupBox groupBox3;
        private Button btnEjecutarOrdenTrabajo;
        private ListBox lsbTrabajosEjecutados;
        private Label label5;
    }
}
