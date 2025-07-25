namespace SenacFoods
{
    partial class FormComanda
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
            button4 = new Button();
            TxtPesquisa = new TextBox();
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
            groupBox1.Location = new Point(-2, 95);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(1154, 569);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardapio";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(120, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(993, 376);
            dataGridView1.TabIndex = 2;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.FromArgb(255, 255, 128);
            BtnEditar.Enabled = false;
            BtnEditar.ForeColor = SystemColors.ControlText;
            BtnEditar.Location = new Point(936, 470);
            BtnEditar.Margin = new Padding(3, 5, 3, 5);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(168, 52);
            BtnEditar.TabIndex = 4;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.GreenYellow;
            btnAdicionar.ForeColor = Color.Black;
            btnAdicionar.Location = new Point(117, 38);
            btnAdicionar.Margin = new Padding(3, 5, 3, 5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(168, 52);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "+ Item";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = Color.FromArgb(192, 0, 0);
            BtnExcluir.Location = new Point(777, 470);
            BtnExcluir.Margin = new Padding(3, 5, 3, 5);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(168, 52);
            BtnExcluir.TabIndex = 3;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 27);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar";
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
            // TxtPesquisa
            // 
            TxtPesquisa.BackColor = SystemColors.Window;
            TxtPesquisa.Location = new Point(198, 27);
            TxtPesquisa.Margin = new Padding(3, 5, 3, 5);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(697, 31);
            TxtPesquisa.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(CardapioFechar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(TxtPesquisa);
            panel1.Location = new Point(-2, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1154, 107);
            panel1.TabIndex = 7;
            // 
            // CardapioFechar
            // 
            CardapioFechar.Location = new Point(1002, 18);
            CardapioFechar.Name = "CardapioFechar";
            CardapioFechar.Size = new Size(46, 51);
            CardapioFechar.TabIndex = 5;
            CardapioFechar.Text = "x";
            CardapioFechar.UseVisualStyleBackColor = true;
            // 
            // FormComanda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 667);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormComanda";
            Text = "FormComanda";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button BtnEditar;
        private Button btnAdicionar;
        private Button BtnExcluir;
        private Label label1;
        private Button button4;
        private TextBox TxtPesquisa;
        private Panel panel1;
        private Button CardapioFechar;
    }
}