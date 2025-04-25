namespace SenacFoods
{
    partial class FormLogin
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tomato;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(txtLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(266, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 450);
            panel2.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Silver;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(190, 246);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(176, 53);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.Silver;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.CharacterCasing = CharacterCasing.Upper;
            txtSenha.Font = new Font("Segoe UI", 15F);
            txtSenha.ForeColor = Color.White;
            txtSenha.Location = new Point(119, 151);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(415, 40);
            txtSenha.TabIndex = 0;
            txtSenha.Text = "SENHA:";
            txtSenha.TextChanged += textBox2_TextChanged;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.Silver;
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.CharacterCasing = CharacterCasing.Upper;
            txtLogin.Font = new Font("Segoe UI", 15F);
            txtLogin.ForeColor = Color.White;
            txtLogin.Location = new Point(119, 96);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(415, 40);
            txtLogin.TabIndex = 0;
            txtLogin.Text = "USUARIO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(110, 108);
            label1.Name = "label1";
            label1.Size = new Size(375, 35);
            label1.TabIndex = 1;
            label1.Text = "________________________";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(110, 165);
            label2.Name = "label2";
            label2.Size = new Size(375, 35);
            label2.TabIndex = 1;
            label2.Text = "________________________";
            label2.Click += label1_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Label label1;
        private Label label2;
    }
}
