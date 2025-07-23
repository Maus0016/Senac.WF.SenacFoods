namespace SenacFoods
{
    partial class FormMesaCad
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
            panel1 = new Panel();
            BtnFecharMesaCad = new Button();
            label1 = new Label();
            button4 = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtNumeroMesa = new TextBox();
            label2 = new Label();
            button5 = new Button();
            button7 = new Button();
            BtnCanselarMesa = new Button();
            btnSalvarMesa = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(BtnFecharMesaCad);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1106, 117);
            panel1.TabIndex = 7;
            panel1.Tag = "";
            // 
            // BtnFecharMesaCad
            // 
            BtnFecharMesaCad.BackColor = Color.Black;
            BtnFecharMesaCad.FlatAppearance.BorderSize = 0;
            BtnFecharMesaCad.FlatStyle = FlatStyle.Flat;
            BtnFecharMesaCad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFecharMesaCad.ForeColor = Color.White;
            BtnFecharMesaCad.Location = new Point(1051, 13);
            BtnFecharMesaCad.Name = "BtnFecharMesaCad";
            BtnFecharMesaCad.Size = new Size(39, 40);
            BtnFecharMesaCad.TabIndex = 5;
            BtnFecharMesaCad.Text = "X";
            BtnFecharMesaCad.UseVisualStyleBackColor = false;
            BtnFecharMesaCad.Click += BtnFecharMesaCad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 27);
            label1.Name = "label1";
            label1.Size = new Size(276, 45);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Mesa";
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
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNumeroMesa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button7);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(2, 110);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(1105, 352);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 31);
            label4.Name = "label4";
            label4.Size = new Size(199, 32);
            label4.TabIndex = 11;
            label4.Tag = "";
            label4.Text = "Numero da Mesa";
            // 
            // txtNumeroMesa
            // 
            txtNumeroMesa.Location = new Point(15, 66);
            txtNumeroMesa.Name = "txtNumeroMesa";
            txtNumeroMesa.Size = new Size(465, 39);
            txtNumeroMesa.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 36);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 3;
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
            // BtnCanselarMesa
            // 
            BtnCanselarMesa.BackColor = Color.FromArgb(192, 0, 0);
            BtnCanselarMesa.Location = new Point(758, 463);
            BtnCanselarMesa.Margin = new Padding(3, 5, 3, 5);
            BtnCanselarMesa.Name = "BtnCanselarMesa";
            BtnCanselarMesa.Size = new Size(168, 52);
            BtnCanselarMesa.TabIndex = 11;
            BtnCanselarMesa.Text = "Cancelar";
            BtnCanselarMesa.UseVisualStyleBackColor = false;
            BtnCanselarMesa.Click += BtnCanselarMesa_Click;
            // 
            // btnSalvarMesa
            // 
            btnSalvarMesa.BackColor = Color.FromArgb(255, 255, 128);
            btnSalvarMesa.ForeColor = SystemColors.ControlText;
            btnSalvarMesa.Location = new Point(932, 463);
            btnSalvarMesa.Margin = new Padding(3, 5, 3, 5);
            btnSalvarMesa.Name = "btnSalvarMesa";
            btnSalvarMesa.Size = new Size(168, 52);
            btnSalvarMesa.TabIndex = 12;
            btnSalvarMesa.Text = "Salvar";
            btnSalvarMesa.UseVisualStyleBackColor = false;
            btnSalvarMesa.Click += btnSalvarMesa_Click;
            // 
            // FormMesaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 529);
            Controls.Add(btnSalvarMesa);
            Controls.Add(BtnCanselarMesa);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMesaCad";
            Text = "FormMesaCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnFecharMesaCad;
        private Label label1;
        private Button button4;
        private GroupBox groupBox1;
        private Button button5;
        private Button button7;
        private TextBox txtNumeroMesa;
        private Label label2;
        private Label label4;
        private Button BtnCanselarMesa;
        private Button btnSalvarMesa;
    }
}