namespace SenacFoods
{
    partial class FormComandaCad
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
            groupBox1 = new GroupBox();
            txtTitulo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button5 = new Button();
            button7 = new Button();
            panel1 = new Panel();
            BtnFecha = new Button();
            label1 = new Label();
            button4 = new Button();
            BtnSalvar = new Button();
            BtbCancelar = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button7);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(2, 89);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(1143, 432);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comanda";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(15, 72);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(578, 39);
            txtTitulo.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 193);
            label4.Name = "label4";
            label4.Size = new Size(109, 32);
            label4.TabIndex = 5;
            label4.Text = "Cardapio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 135);
            label3.Name = "label3";
            label3.Size = new Size(76, 32);
            label3.TabIndex = 4;
            label3.Text = "Mesa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 36);
            label2.Name = "label2";
            label2.Size = new Size(197, 32);
            label2.TabIndex = 3;
            label2.Text = "Nome do Cliente";
            // 
            // button5
            // 
            button5.BackColor = Color.Salmon;
            button5.Location = new Point(1210, 573);
            button5.Margin = new Padding(3, 5, 3, 5);
            button5.Name = "button5";
            button5.Size = new Size(168, 52);
            button5.TabIndex = 2;
            button5.Text = "Editar";
            button5.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Red;
            button7.Location = new Point(1020, 573);
            button7.Margin = new Padding(3, 5, 3, 5);
            button7.Name = "button7";
            button7.Size = new Size(168, 52);
            button7.TabIndex = 1;
            button7.Text = "Excluir";
            button7.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(BtnFecha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1148, 104);
            panel1.TabIndex = 12;
            panel1.Tag = "";
            // 
            // BtnFecha
            // 
            BtnFecha.BackColor = Color.Black;
            BtnFecha.FlatAppearance.BorderSize = 0;
            BtnFecha.FlatStyle = FlatStyle.Flat;
            BtnFecha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFecha.ForeColor = Color.White;
            BtnFecha.Location = new Point(1085, 12);
            BtnFecha.Name = "BtnFecha";
            BtnFecha.Size = new Size(39, 40);
            BtnFecha.TabIndex = 6;
            BtnFecha.Text = "X";
            BtnFecha.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(156, 45);
            label1.TabIndex = 1;
            label1.Text = "Comanda";
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1457, 14);
            button4.Name = "button4";
            button4.Size = new Size(39, 40);
            button4.TabIndex = 4;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.Salmon;
            BtnSalvar.Location = new Point(955, 530);
            BtnSalvar.Margin = new Padding(3, 5, 3, 5);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(168, 52);
            BtnSalvar.TabIndex = 11;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            // 
            // BtbCancelar
            // 
            BtbCancelar.BackColor = Color.Red;
            BtbCancelar.Location = new Point(781, 531);
            BtbCancelar.Margin = new Padding(3, 5, 3, 5);
            BtbCancelar.Name = "BtbCancelar";
            BtbCancelar.Size = new Size(168, 52);
            BtbCancelar.TabIndex = 10;
            BtbCancelar.Text = "Cancelar";
            BtbCancelar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(443, 40);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(150, 193);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(383, 40);
            comboBox2.TabIndex = 7;
            // 
            // FormComandaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 596);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(BtnSalvar);
            Controls.Add(BtbCancelar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormComandaCad";
            Text = "FormComandaCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTitulo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button5;
        private Button button7;
        private Panel panel1;
        private Button BtnFecha;
        private Label label1;
        private Button button4;
        private Button BtnSalvar;
        private Button BtbCancelar;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}