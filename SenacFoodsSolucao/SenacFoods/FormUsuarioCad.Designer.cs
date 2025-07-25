namespace SenacFoods
{
    partial class FormUsuarioCad
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
            BtnFecharUsuarioCad = new Button();
            label1 = new Label();
            button4 = new Button();
            label4 = new Label();
            txtNomeDoUsuario = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtSenhaDoUsuario = new TextBox();
            label5 = new Label();
            txtConfirmarSenha = new TextBox();
            Perfil = new ComboBox();
            label6 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnCancelarUsuario = new Button();
            btnSalvarUsuario = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(BtnFecharUsuarioCad);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1230, 104);
            panel1.TabIndex = 7;
            panel1.Tag = "";
            // 
            // BtnFecharUsuarioCad
            // 
            BtnFecharUsuarioCad.BackColor = Color.Black;
            BtnFecharUsuarioCad.FlatAppearance.BorderSize = 0;
            BtnFecharUsuarioCad.FlatStyle = FlatStyle.Flat;
            BtnFecharUsuarioCad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFecharUsuarioCad.ForeColor = Color.White;
            BtnFecharUsuarioCad.Location = new Point(1175, 3);
            BtnFecharUsuarioCad.Name = "BtnFecharUsuarioCad";
            BtnFecharUsuarioCad.Size = new Size(39, 40);
            BtnFecharUsuarioCad.TabIndex = 7;
            BtnFecharUsuarioCad.Text = "X";
            BtnFecharUsuarioCad.UseVisualStyleBackColor = false;
            BtnFecharUsuarioCad.Click += BtnFecharUsuarioCad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 27);
            label1.Name = "label1";
            label1.Size = new Size(322, 90);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Usuarios\r\n\r\n";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 114);
            label4.Name = "label4";
            label4.Size = new Size(153, 25);
            label4.TabIndex = 12;
            label4.Tag = "";
            label4.Text = "Nome do Usuario";
            // 
            // txtNomeDoUsuario
            // 
            txtNomeDoUsuario.Location = new Point(26, 142);
            txtNomeDoUsuario.Name = "txtNomeDoUsuario";
            txtNomeDoUsuario.Size = new Size(333, 31);
            txtNomeDoUsuario.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 180);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 14;
            label2.Tag = "";
            label2.Text = "E-Mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(333, 31);
            txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 255);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 16;
            label3.Tag = "";
            label3.Text = "Senha";
            // 
            // txtSenhaDoUsuario
            // 
            txtSenhaDoUsuario.Location = new Point(26, 287);
            txtSenhaDoUsuario.Name = "txtSenhaDoUsuario";
            txtSenhaDoUsuario.Size = new Size(333, 31);
            txtSenhaDoUsuario.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 323);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 18;
            label5.Tag = "";
            label5.Text = "Confirmar Senha";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(26, 357);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(333, 31);
            txtConfirmarSenha.TabIndex = 3;
            // 
            // Perfil
            // 
            Perfil.FormattingEnabled = true;
            Perfil.Items.AddRange(new object[] { "Dono", "Gênercia", "Colaborador", "Cliente" });
            Perfil.Location = new Point(26, 419);
            Perfil.Name = "Perfil";
            Perfil.Size = new Size(182, 33);
            Perfil.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 391);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 21;
            label6.Tag = "";
            label6.Text = "Perfil";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnCancelarUsuario
            // 
            btnCancelarUsuario.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelarUsuario.Location = new Point(503, 460);
            btnCancelarUsuario.Margin = new Padding(3, 5, 3, 5);
            btnCancelarUsuario.Name = "btnCancelarUsuario";
            btnCancelarUsuario.Size = new Size(168, 52);
            btnCancelarUsuario.TabIndex = 5;
            btnCancelarUsuario.Text = "Cancelar";
            btnCancelarUsuario.UseVisualStyleBackColor = false;
            btnCancelarUsuario.Click += btnCancelarUsuario_Click;
            // 
            // btnSalvarUsuario
            // 
            btnSalvarUsuario.BackColor = Color.FromArgb(255, 255, 128);
            btnSalvarUsuario.ForeColor = SystemColors.ControlText;
            btnSalvarUsuario.Location = new Point(677, 460);
            btnSalvarUsuario.Margin = new Padding(3, 5, 3, 5);
            btnSalvarUsuario.Name = "btnSalvarUsuario";
            btnSalvarUsuario.Size = new Size(168, 52);
            btnSalvarUsuario.TabIndex = 6;
            btnSalvarUsuario.Text = "Salvar";
            btnSalvarUsuario.UseVisualStyleBackColor = false;
            btnSalvarUsuario.Click += btnSalvarUsuario_Click;
            // 
            // FormUsuarioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 526);
            Controls.Add(btnSalvarUsuario);
            Controls.Add(btnCancelarUsuario);
            Controls.Add(label6);
            Controls.Add(Perfil);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(label5);
            Controls.Add(txtSenhaDoUsuario);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNomeDoUsuario);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUsuarioCad";
            Text = "UsuarioCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BtnFecha;
        private Label label1;
        private Button button4;
        private Label label4;
        private TextBox txtNomeDoUsuario;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtSenhaDoUsuario;
        private Label label5;
        private TextBox txtConfirmarSenha;
        private ComboBox Perfil;
        private Label label6;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnCancelarUsuario;
        private Button btnSalvarUsuario;
        private Button BtnFecharUsuarioCad;
    }
}