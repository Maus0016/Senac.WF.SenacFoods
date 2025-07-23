namespace SenacFoods
{
    partial class FormUsuario
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
            UsuarioFechar = new Button();
            label1 = new Label();
            button4 = new Button();
            TxtPesquisaDeUsuario = new TextBox();
            groupBox1 = new GroupBox();
            btnEditarIUsuario = new Button();
            btnExcluirUsuario = new Button();
            dataGridView1 = new DataGridView();
            BtnEditar = new Button();
            btnAdicionarUsuario = new Button();
            BtnExcluir = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(UsuarioFechar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(TxtPesquisaDeUsuario);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 79);
            panel1.TabIndex = 6;
            // 
            // UsuarioFechar
            // 
            UsuarioFechar.Location = new Point(982, 14);
            UsuarioFechar.Name = "UsuarioFechar";
            UsuarioFechar.Size = new Size(46, 51);
            UsuarioFechar.TabIndex = 5;
            UsuarioFechar.Text = "x";
            UsuarioFechar.UseVisualStyleBackColor = true;
            UsuarioFechar.Click += UsuarioFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 27);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar Usuario";
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
            // TxtPesquisaDeUsuario
            // 
            TxtPesquisaDeUsuario.BackColor = SystemColors.Window;
            TxtPesquisaDeUsuario.Location = new Point(240, 27);
            TxtPesquisaDeUsuario.Margin = new Padding(3, 5, 3, 5);
            TxtPesquisaDeUsuario.Name = "TxtPesquisaDeUsuario";
            TxtPesquisaDeUsuario.Size = new Size(697, 31);
            TxtPesquisaDeUsuario.TabIndex = 2;
            TxtPesquisaDeUsuario.TextChanged += TxtPesquisaDeUsuario_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEditarIUsuario);
            groupBox1.Controls.Add(btnExcluirUsuario);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(BtnEditar);
            groupBox1.Controls.Add(btnAdicionarUsuario);
            groupBox1.Controls.Add(BtnExcluir);
            groupBox1.Location = new Point(3, 76);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(1063, 415);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardapio";
            // 
            // btnEditarIUsuario
            // 
            btnEditarIUsuario.BackColor = Color.FromArgb(255, 255, 128);
            btnEditarIUsuario.Enabled = false;
            btnEditarIUsuario.ForeColor = SystemColors.ControlText;
            btnEditarIUsuario.Location = new Point(794, 342);
            btnEditarIUsuario.Margin = new Padding(3, 5, 3, 5);
            btnEditarIUsuario.Name = "btnEditarIUsuario";
            btnEditarIUsuario.Size = new Size(168, 52);
            btnEditarIUsuario.TabIndex = 9;
            btnEditarIUsuario.Text = "Editar";
            btnEditarIUsuario.UseVisualStyleBackColor = false;
            btnEditarIUsuario.Click += btnEditarIUsuario_Click;
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.BackColor = Color.FromArgb(192, 0, 0);
            btnExcluirUsuario.Location = new Point(620, 342);
            btnExcluirUsuario.Margin = new Padding(3, 5, 3, 5);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(168, 52);
            btnExcluirUsuario.TabIndex = 8;
            btnExcluirUsuario.Text = "Excluir";
            btnExcluirUsuario.UseVisualStyleBackColor = false;
            btnExcluirUsuario.Click += btnExcluirUsuario_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(910, 248);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.FromArgb(255, 255, 128);
            BtnEditar.Enabled = false;
            BtnEditar.ForeColor = SystemColors.ControlText;
            BtnEditar.Location = new Point(1096, 513);
            BtnEditar.Margin = new Padding(3, 5, 3, 5);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(168, 52);
            BtnEditar.TabIndex = 2;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarUsuario
            // 
            btnAdicionarUsuario.BackColor = Color.GreenYellow;
            btnAdicionarUsuario.ForeColor = Color.Black;
            btnAdicionarUsuario.Location = new Point(52, 38);
            btnAdicionarUsuario.Margin = new Padding(3, 5, 3, 5);
            btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            btnAdicionarUsuario.Size = new Size(168, 52);
            btnAdicionarUsuario.TabIndex = 1;
            btnAdicionarUsuario.Text = "Adicionar Usuario";
            btnAdicionarUsuario.UseVisualStyleBackColor = false;
            btnAdicionarUsuario.Click += btnAdicionarUsuario_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = Color.FromArgb(192, 0, 0);
            BtnExcluir.Location = new Point(922, 513);
            BtnExcluir.Margin = new Padding(3, 5, 3, 5);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(168, 52);
            BtnExcluir.TabIndex = 1;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 545);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUsuario";
            Text = "FormUsuario";
            Load += FormUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button UsuarioFechar;
        private Label label1;
        private Button button4;
        private TextBox TxtPesquisaDeUsuario;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button BtnEditar;
        private Button btnAdicionarUsuario;
        private Button BtnExcluir;
        private Button btnExcluirUsuario;
        private Button btnEditarIUsuario;
    }
}