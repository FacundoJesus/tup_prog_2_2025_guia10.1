namespace Ejercicio1
{
    partial class FormDatoCamion
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
            nudCapacidad = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 0;
            label1.Text = "Capacidad del Camión:";
            // 
            // nudCapacidad
            // 
            nudCapacidad.Location = new Point(161, 17);
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(83, 23);
            nudCapacidad.TabIndex = 1;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(93, 61);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 2;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormDatoCamion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 107);
            Controls.Add(button1);
            Controls.Add(nudCapacidad);
            Controls.Add(label1);
            Name = "FormDatoCamion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Camión";
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public NumericUpDown nudCapacidad;
        private Button button1;
    }
}