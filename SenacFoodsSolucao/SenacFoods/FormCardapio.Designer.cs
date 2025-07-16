namespace SenacFoods
{
    partial class FormCardapio
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
            dataGridView1 = new DataGridView();
            BtnEditar = new Button();
            btnAdicionar = new Button();
            BtnExcluir = new Button();
            label1 = new Label();
            TxtPesquisa = new TextBox();
            button4 = new Button();
            panel1 = new Panel();
            CardapioFechar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(BtnEditar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(BtnExcluir);
            groupBox1.Location = new Point(44, 113);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(1307, 583);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardapio";
           
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
            dataGridView1.Size = new Size(1179, 376);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            BtnEditar.Click += BtnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.GreenYellow;
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Location = new Point(52, 38);
            btnAdicionar.Margin = new Padding(3, 5, 3, 5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(168, 52);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "+ Item";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
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
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 27);
            label1.Name = "label1";
            label1.Size = new Size(134, 38);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar";
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.BackColor = SystemColors.Window;
            TxtPesquisa.Location = new Point(198, 27);
            TxtPesquisa.Margin = new Padding(3, 5, 3, 5);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(697, 45);
            TxtPesquisa.TabIndex = 2;
            TxtPesquisa.TextChanged += TxtPesquisa_TextChanged;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(CardapioFechar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(TxtPesquisa);
            panel1.Location = new Point(-4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1376, 107);
            panel1.TabIndex = 5;
            // 
            // CardapioFechar
            // 
            CardapioFechar.Location = new Point(1266, 14);
            CardapioFechar.Name = "CardapioFechar";
            CardapioFechar.Size = new Size(46, 51);
            CardapioFechar.TabIndex = 5;
            CardapioFechar.Text = "x";
            CardapioFechar.UseVisualStyleBackColor = true;
            CardapioFechar.Click += button1_Click;
            // 
            // FormCardapio
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1369, 708);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 5, 3, 5);
            Name = "FormCardapio";
            Text = "FormCardapio";
            Load += FormCardapio_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Label label1;
        private TextBox TxtPesquisa;
        private Button btnAdicionar;
        private Button button4;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button CardapioFechar;
    }
}