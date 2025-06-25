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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(57, 152);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(1579, 635);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardapio";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 87);
            dataGridView1.Margin = new Padding(3, 5, 3, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1498, 480);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1195, 577);
            button1.Margin = new Padding(3, 5, 3, 5);
            button1.Name = "button1";
            button1.Size = new Size(168, 52);
            button1.TabIndex = 1;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1369, 577);
            button2.Margin = new Padding(3, 5, 3, 5);
            button2.Name = "button2";
            button2.Size = new Size(168, 52);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 62);
            label1.Name = "label1";
            label1.Size = new Size(134, 38);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 62);
            textBox1.Margin = new Padding(3, 5, 3, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(697, 45);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // FormCardapio
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1686, 871);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 5, 3, 5);
            Name = "FormCardapio";
            Text = "FormCardapio";
            TransparencyKey = Color.White;
            Load += FormCardapio_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
    }
}