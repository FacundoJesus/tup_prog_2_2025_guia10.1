namespace Ejercicio3
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
            btnAtender = new Button();
            lsbPedidosEntrantes = new ListBox();
            tbDireccion = new TextBox();
            tbTelefono = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnAsignarCoche = new Button();
            lsbOcupado = new ListBox();
            lsbDisponibles = new ListBox();
            label4 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            nudNroV = new NumericUpDown();
            label7 = new Label();
            btnLiberarCoche = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNroV).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAtender);
            groupBox1.Controls.Add(lsbPedidosEntrantes);
            groupBox1.Controls.Add(tbDireccion);
            groupBox1.Controls.Add(tbTelefono);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 388);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recibir Pedido Taxi";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(57, 326);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(149, 48);
            btnAtender.TabIndex = 12;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // lsbPedidosEntrantes
            // 
            lsbPedidosEntrantes.FormattingEnabled = true;
            lsbPedidosEntrantes.ItemHeight = 15;
            lsbPedidosEntrantes.Location = new Point(17, 206);
            lsbPedidosEntrantes.Name = "lsbPedidosEntrantes";
            lsbPedidosEntrantes.Size = new Size(228, 109);
            lsbPedidosEntrantes.TabIndex = 5;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(78, 87);
            tbDireccion.Multiline = true;
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(167, 75);
            tbDireccion.TabIndex = 4;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(78, 33);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(167, 23);
            tbTelefono.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 188);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Pedidos Entrantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 87);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Dirección:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Teléfono:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAsignarCoche);
            groupBox2.Controls.Add(lsbOcupado);
            groupBox2.Controls.Add(lsbDisponibles);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(282, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(264, 388);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Central de Taxis";
            // 
            // btnAsignarCoche
            // 
            btnAsignarCoche.Location = new Point(58, 326);
            btnAsignarCoche.Name = "btnAsignarCoche";
            btnAsignarCoche.Size = new Size(149, 48);
            btnAsignarCoche.TabIndex = 9;
            btnAsignarCoche.Text = "Asignar Coche a Cliente";
            btnAsignarCoche.UseVisualStyleBackColor = true;
            btnAsignarCoche.Click += btnAsignarCoche_Click;
            // 
            // lsbOcupado
            // 
            lsbOcupado.FormattingEnabled = true;
            lsbOcupado.ItemHeight = 15;
            lsbOcupado.Location = new Point(17, 206);
            lsbOcupado.Name = "lsbOcupado";
            lsbOcupado.Size = new Size(228, 109);
            lsbOcupado.TabIndex = 11;
            // 
            // lsbDisponibles
            // 
            lsbDisponibles.FormattingEnabled = true;
            lsbDisponibles.ItemHeight = 15;
            lsbDisponibles.Location = new Point(17, 54);
            lsbDisponibles.Name = "lsbDisponibles";
            lsbDisponibles.Size = new Size(228, 109);
            lsbDisponibles.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 188);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 9;
            label4.Text = "Vehiculos Ocupados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 36);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 7;
            label5.Text = "Vehiculos Disponibles";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nudNroV);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(btnLiberarCoche);
            groupBox3.Location = new Point(553, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(264, 388);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Acciones del Chofer";
            // 
            // nudNroV
            // 
            nudNroV.Location = new Point(59, 65);
            nudNroV.Name = "nudNroV";
            nudNroV.Size = new Size(149, 23);
            nudNroV.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 36);
            label7.Name = "label7";
            label7.Size = new Size(118, 15);
            label7.TabIndex = 7;
            label7.Text = "Número de Vehículo:";
            // 
            // btnLiberarCoche
            // 
            btnLiberarCoche.Location = new Point(59, 326);
            btnLiberarCoche.Name = "btnLiberarCoche";
            btnLiberarCoche.Size = new Size(149, 48);
            btnLiberarCoche.TabIndex = 6;
            btnLiberarCoche.Text = "Liberar Coche";
            btnLiberarCoche.UseVisualStyleBackColor = true;
            btnLiberarCoche.Click += btnLiberarCoche_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 412);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 3";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNroV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbTelefono;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAtender;
        private ListBox lsbPedidosEntrantes;
        private TextBox tbDireccion;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox lsbOcupados;
        private Label label5;
        private Button button2;
        private TextBox textBox3;
        private GroupBox groupBox3;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Button btnLiberarCoche;
        private ListBox lsbDisponibles;
        private Button btnAsignarCoche;
        private ListBox lsbOcupado;
        private NumericUpDown nudNroV;
    }
}
