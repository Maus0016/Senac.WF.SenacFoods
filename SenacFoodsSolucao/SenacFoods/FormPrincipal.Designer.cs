namespace SenacFoods
{
    partial class FormPrincipal
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
            btnUsuarios = new Button();
            btnPedidoCozinha = new Button();
            btnComanda = new Button();
            btnCarpadio = new Button();
            btnFechar = new Button();
            btnMinimizar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUsuarios);
            groupBox1.Controls.Add(btnPedidoCozinha);
            groupBox1.Controls.Add(btnComanda);
            groupBox1.Controls.Add(btnCarpadio);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(119, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senac Foods";
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.LightSalmon;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 11F);
            btnUsuarios.ForeColor = Color.Black;
            btnUsuarios.Location = new Point(479, 43);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(112, 80);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnPedidoCozinha
            // 
            btnPedidoCozinha.BackColor = Color.SeaGreen;
            btnPedidoCozinha.FlatAppearance.BorderSize = 0;
            btnPedidoCozinha.FlatStyle = FlatStyle.Flat;
            btnPedidoCozinha.Font = new Font("Segoe UI", 10F);
            btnPedidoCozinha.ForeColor = Color.Black;
            btnPedidoCozinha.Location = new Point(335, 43);
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.Size = new Size(112, 80);
            btnPedidoCozinha.TabIndex = 0;
            btnPedidoCozinha.Text = "Pedido Cozinha";
            btnPedidoCozinha.UseVisualStyleBackColor = false;
            btnPedidoCozinha.Click += btnPedidoCozinha_Click;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.YellowGreen;
            btnComanda.FlatAppearance.BorderSize = 0;
            btnComanda.FlatStyle = FlatStyle.Flat;
            btnComanda.Font = new Font("Segoe UI", 10F);
            btnComanda.ForeColor = Color.Black;
            btnComanda.Location = new Point(195, 43);
            btnComanda.Name = "btnComanda";
            btnComanda.Size = new Size(112, 80);
            btnComanda.TabIndex = 0;
            btnComanda.Text = "Comanda";
            btnComanda.UseVisualStyleBackColor = false;
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCarpadio
            // 
            btnCarpadio.BackColor = Color.Gold;
            btnCarpadio.FlatAppearance.BorderSize = 0;
            btnCarpadio.FlatStyle = FlatStyle.Flat;
            btnCarpadio.Font = new Font("Segoe UI", 10F);
            btnCarpadio.ForeColor = Color.Black;
            btnCarpadio.Location = new Point(59, 43);
            btnCarpadio.Name = "btnCarpadio";
            btnCarpadio.Size = new Size(112, 80);
            btnCarpadio.TabIndex = 0;
            btnCarpadio.Text = "Cardapio";
            btnCarpadio.UseVisualStyleBackColor = false;
            btnCarpadio.Click += btnCarpadio_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.White;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(806, 28);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(39, 34);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.White;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(761, 28);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(39, 34);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.Text = "___";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(885, 396);
            Controls.Add(btnMinimizar);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCarpadio;
        private Button btnUsuarios;
        private Button btnPedidoCozinha;
        private Button btnComanda;
        private Button btnFechar;
        private Button btnMinimizar;
    }
}