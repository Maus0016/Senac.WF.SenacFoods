namespace SenacFoods
{
    partial class FormMesa
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
            CardapioFecharMesa = new Button();
            label1 = new Label();
            button4 = new Button();
            TxtPesquisa = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btEditarMesa = new Button();
            btnNovaMesa = new Button();
            BtnExcluirMesa = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(CardapioFecharMesa);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(TxtPesquisa);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 107);
            panel1.TabIndex = 6;
            // 
            // CardapioFecharMesa
            // 
            CardapioFecharMesa.Location = new Point(1071, 7);
            CardapioFecharMesa.Name = "CardapioFecharMesa";
            CardapioFecharMesa.Size = new Size(46, 51);
            CardapioFecharMesa.TabIndex = 5;
            CardapioFecharMesa.Text = "x";
            CardapioFecharMesa.UseVisualStyleBackColor = true;
            CardapioFecharMesa.Click += CardapioFechar_Click;
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
            TxtPesquisa.Location = new Point(167, 27);
            TxtPesquisa.Margin = new Padding(3, 5, 3, 5);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.Size = new Size(762, 31);
            TxtPesquisa.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btEditarMesa);
            groupBox1.Controls.Add(btnNovaMesa);
            groupBox1.Controls.Add(BtnExcluirMesa);
            groupBox1.Location = new Point(3, 109);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(1114, 448);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesa";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1041, 257);
            dataGridView1.TabIndex = 3;
            // 
            // btEditarMesa
            // 
            btEditarMesa.BackColor = Color.FromArgb(255, 255, 128);
            btEditarMesa.ForeColor = SystemColors.ControlText;
            btEditarMesa.Location = new Point(912, 344);
            btEditarMesa.Margin = new Padding(3, 5, 3, 5);
            btEditarMesa.Name = "btEditarMesa";
            btEditarMesa.Size = new Size(168, 52);
            btEditarMesa.TabIndex = 2;
            btEditarMesa.Text = "Editar";
            btEditarMesa.UseVisualStyleBackColor = false;
            // 
            // btnNovaMesa
            // 
            btnNovaMesa.BackColor = Color.GreenYellow;
            btnNovaMesa.ForeColor = Color.Black;
            btnNovaMesa.Location = new Point(52, 27);
            btnNovaMesa.Margin = new Padding(3, 5, 3, 5);
            btnNovaMesa.Name = "btnNovaMesa";
            btnNovaMesa.Size = new Size(168, 52);
            btnNovaMesa.TabIndex = 1;
            btnNovaMesa.Text = "Nova Mesa ";
            btnNovaMesa.UseVisualStyleBackColor = false;
            btnNovaMesa.Click += btnNovaMesa_Click_1;
            // 
            // BtnExcluirMesa
            // 
            BtnExcluirMesa.BackColor = Color.FromArgb(192, 0, 0);
            BtnExcluirMesa.Location = new Point(738, 344);
            BtnExcluirMesa.Margin = new Padding(3, 5, 3, 5);
            BtnExcluirMesa.Name = "BtnExcluirMesa";
            BtnExcluirMesa.Size = new Size(168, 52);
            BtnExcluirMesa.TabIndex = 1;
            BtnExcluirMesa.Text = "Excluir";
            BtnExcluirMesa.UseVisualStyleBackColor = false;
            // 
            // FormMesa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 560);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMesa";
            Text = "FormMesa";
            Load += FormMesa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button CardapioFecharMesa;
        private Label label1;
        private Button button4;
        private TextBox TxtPesquisa;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btEditarMesa;
        private Button btnNovaMesa;
        private Button BtnExcluirMesa;
    }
}