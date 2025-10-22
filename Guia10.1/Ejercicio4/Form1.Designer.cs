namespace Ejercicio4
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
            btnMostrarNodos = new Button();
            groupBox1 = new GroupBox();
            cb2doEvento = new ComboBox();
            lbResultado = new Label();
            cb1erEvento = new ComboBox();
            btnCalcular = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lsbResultado = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnMostrarNodos
            // 
            btnMostrarNodos.Location = new Point(336, 22);
            btnMostrarNodos.Name = "btnMostrarNodos";
            btnMostrarNodos.Size = new Size(321, 48);
            btnMostrarNodos.TabIndex = 0;
            btnMostrarNodos.Text = "Mostrar Todos los Nodos";
            btnMostrarNodos.UseVisualStyleBackColor = true;
            btnMostrarNodos.Click += btnMostrarNodos_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb2doEvento);
            groupBox1.Controls.Add(lbResultado);
            groupBox1.Controls.Add(cb1erEvento);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(336, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 243);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Probabilidad Condicional";
            // 
            // cb2doEvento
            // 
            cb2doEvento.FormattingEnabled = true;
            cb2doEvento.Location = new Point(72, 81);
            cb2doEvento.Name = "cb2doEvento";
            cb2doEvento.Size = new Size(243, 23);
            cb2doEvento.TabIndex = 6;
            // 
            // lbResultado
            // 
            lbResultado.BackColor = SystemColors.ActiveBorder;
            lbResultado.Location = new Point(165, 154);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(134, 22);
            lbResultado.TabIndex = 5;
            // 
            // cb1erEvento
            // 
            cb1erEvento.AutoCompleteCustomSource.AddRange(new string[] { "Evento: A - Probabilidad 1" });
            cb1erEvento.FormattingEnabled = true;
            cb1erEvento.Location = new Point(72, 35);
            cb1erEvento.Name = "cb1erEvento";
            cb1erEvento.Size = new Size(243, 23);
            cb1erEvento.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(125, 196);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(93, 30);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 154);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 2;
            label3.Text = "Probabilidad de que ocurra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 84);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "2º Evento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "1º Evento:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.diagrama_arbol;
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lsbResultado
            // 
            lsbResultado.BackColor = Color.LightGray;
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(336, 344);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.ScrollAlwaysVisible = true;
            lsbResultado.Size = new Size(321, 94);
            lsbResultado.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(671, 450);
            Controls.Add(lsbResultado);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnMostrarNodos);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 4";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrarNodos;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label lbResultado;
        private ComboBox cb1erEvento;
        private Button btnCalcular;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox lsbResultado;
        private ComboBox cb2doEvento;
    }
}
