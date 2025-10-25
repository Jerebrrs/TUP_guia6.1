namespace Ejercicio_1
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
            btnRegistrar = new Button();
            tbPatente = new TextBox();
            tbNombre = new TextBox();
            tbDni = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnVerRegistros = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(tbPatente);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbDni);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 154);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta de Registro";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(278, 60);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(83, 35);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(150, 96);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(117, 23);
            tbPatente.TabIndex = 5;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(150, 62);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(117, 23);
            tbNombre.TabIndex = 4;
            // 
            // tbDni
            // 
            tbDni.Location = new Point(150, 33);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(117, 23);
            tbDni.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 104);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Patente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 70);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 41);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // btnVerRegistros
            // 
            btnVerRegistros.Location = new Point(180, 172);
            btnVerRegistros.Name = "btnVerRegistros";
            btnVerRegistros.Size = new Size(83, 35);
            btnVerRegistros.TabIndex = 7;
            btnVerRegistros.Text = "Ver Registros";
            btnVerRegistros.UseVisualStyleBackColor = true;
            btnVerRegistros.Click += btnVerRegistros_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 223);
            Controls.Add(btnVerRegistros);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRegistrar;
        private TextBox tbPatente;
        private TextBox tbNombre;
        private TextBox tbDni;
        private Button btnVerRegistros;
    }
}
