namespace SenacFoods
{
    partial class FrmCardapioCad
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
            BtnFecha = new Button();
            label1 = new Label();
            button4 = new Button();
            BtbCancelar = new Button();
            BtnSalvar = new Button();
            groupBox1 = new GroupBox();
            txtDescricao = new RichTextBox();
            txtPreco = new TextBox();
            txtTitulo = new TextBox();
            chkPossiuPreparo = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button5 = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(BtnFecha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1388, 104);
            panel1.TabIndex = 6;
            panel1.Tag = "";
            // 
            // BtnFecha
            // 
            BtnFecha.BackColor = Color.Black;
            BtnFecha.FlatAppearance.BorderSize = 0;
            BtnFecha.FlatStyle = FlatStyle.Flat;
            BtnFecha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnFecha.ForeColor = Color.White;
            BtnFecha.Location = new Point(1312, 3);
            BtnFecha.Name = "BtnFecha";
            BtnFecha.Size = new Size(39, 40);
            BtnFecha.TabIndex = 5;
            BtnFecha.Text = "X";
            BtnFecha.UseVisualStyleBackColor = false;
            BtnFecha.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 27);
            label1.Name = "label1";
            label1.Size = new Size(328, 45);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Cardapio";
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
            // BtbCancelar
            // 
            BtbCancelar.BackColor = Color.Red;
            BtbCancelar.Location = new Point(954, 571);
            BtbCancelar.Margin = new Padding(3, 5, 3, 5);
            BtbCancelar.Name = "BtbCancelar";
            BtbCancelar.Size = new Size(168, 52);
            BtbCancelar.TabIndex = 7;
            BtbCancelar.Text = "Cancelar";
            BtbCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.Salmon;
            BtnSalvar.Location = new Point(1141, 571);
            BtnSalvar.Margin = new Padding(3, 5, 3, 5);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(168, 52);
            BtnSalvar.TabIndex = 8;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtPreco);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(chkPossiuPreparo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button7);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(-3, 111);
            groupBox1.Margin = new Padding(3, 5, 3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 5, 3, 5);
            groupBox1.Size = new Size(1388, 432);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardapio";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(15, 141);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(465, 97);
            txtDescricao.TabIndex = 10;
            txtDescricao.Text = "";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(15, 276);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(465, 39);
            txtPreco.TabIndex = 9;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(15, 63);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(465, 39);
            txtTitulo.TabIndex = 7;
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            // 
            // chkPossiuPreparo
            // 
            chkPossiuPreparo.AutoSize = true;
            chkPossiuPreparo.Location = new Point(15, 345);
            chkPossiuPreparo.Name = "chkPossiuPreparo";
            chkPossiuPreparo.Size = new Size(207, 36);
            chkPossiuPreparo.TabIndex = 6;
            chkPossiuPreparo.Text = "Possui preparo?";
            chkPossiuPreparo.UseVisualStyleBackColor = true;
            chkPossiuPreparo.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 241);
            label4.Name = "label4";
            label4.Size = new Size(73, 32);
            label4.TabIndex = 5;
            label4.Text = "Preço";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 106);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 4;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 34);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 3;
            label2.Text = "Titulo";
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
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 637);
            Controls.Add(groupBox1);
            Controls.Add(BtnSalvar);
            Controls.Add(BtbCancelar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            Text = "FrmCardapioCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button4;
        private Button button1;
        private Button BtbCancelar;
        private Button BtnSalvar;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button5;
        private Button button7;
        private CheckBox chkPossiuPreparo;
        private RichTextBox txtDescricao;
        private TextBox txtPreco;
        private TextBox txtTitulo;
        private Button BtnFecha;
    }
}