namespace prova2b
{
    partial class Form1
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
            Label label1;
            cb_8 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            label10 = new Label();
            tx_box1 = new TextBox();
            tx_box2 = new TextBox();
            tx_box3 = new TextBox();
            tx_box4 = new TextBox();
            tx_box6 = new TextBox();
            tx_box7 = new TextBox();
            tx_box5 = new TextBox();
            label11 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(223, 21);
            label1.Name = "label1";
            label1.Size = new Size(294, 41);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produto";
            label1.TextAlign = ContentAlignment.BottomCenter;
            label1.Click += label1_Click;
            // 
            // cb_8
            // 
            cb_8.DisplayMember = "HSFJHSDF";
            cb_8.FormattingEnabled = true;
            cb_8.Items.AddRange(new object[] { "UN", "LT", "KL" });
            cb_8.Location = new Point(586, 102);
            cb_8.Name = "cb_8";
            cb_8.Size = new Size(151, 28);
            cb_8.TabIndex = 3;
            cb_8.Tag = "HVBDFBVD";
            cb_8.Text = "UN";
            cb_8.ValueMember = "HSFJHSDF";
            cb_8.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 110);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "Unidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 105);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 3;
            label3.Text = "Código:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 165);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 4;
            label4.Text = "Descrição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 224);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 5;
            label5.Text = "Valor:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(512, 224);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 6;
            label6.Text = "PIS:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 295);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 7;
            label7.Text = "ICMS:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(512, 295);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 8;
            label8.Text = "CONFINS:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(104, 364);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 9;
            label9.Text = "LUCRO:";
            // 
            // button1
            // 
            button1.Location = new Point(486, 360);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(504, 412);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 11;
            // 
            // tx_box1
            // 
            tx_box1.Location = new Point(171, 102);
            tx_box1.Name = "tx_box1";
            tx_box1.Size = new Size(276, 27);
            tx_box1.TabIndex = 12;
            // 
            // tx_box2
            // 
            tx_box2.Location = new Point(171, 158);
            tx_box2.Name = "tx_box2";
            tx_box2.Size = new Size(276, 27);
            tx_box2.TabIndex = 13;
            // 
            // tx_box3
            // 
            tx_box3.Location = new Point(149, 221);
            tx_box3.Name = "tx_box3";
            tx_box3.Size = new Size(160, 27);
            tx_box3.TabIndex = 14;
            // 
            // tx_box4
            // 
            tx_box4.Location = new Point(156, 292);
            tx_box4.Name = "tx_box4";
            tx_box4.Size = new Size(128, 27);
            tx_box4.TabIndex = 15;
            // 
            // tx_box6
            // 
            tx_box6.Location = new Point(550, 217);
            tx_box6.Name = "tx_box6";
            tx_box6.Size = new Size(100, 27);
            tx_box6.TabIndex = 16;
            // 
            // tx_box7
            // 
            tx_box7.Location = new Point(586, 292);
            tx_box7.Name = "tx_box7";
            tx_box7.Size = new Size(108, 27);
            tx_box7.TabIndex = 17;
            // 
            // tx_box5
            // 
            tx_box5.Location = new Point(168, 357);
            tx_box5.Name = "tx_box5";
            tx_box5.Size = new Size(168, 27);
            tx_box5.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(486, 392);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 19;
            label11.Text = "TesteTEste";
            label11.Click += label11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(tx_box5);
            Controls.Add(tx_box7);
            Controls.Add(tx_box6);
            Controls.Add(tx_box4);
            Controls.Add(tx_box3);
            Controls.Add(tx_box2);
            Controls.Add(tx_box1);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cb_8);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cb_8;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private Label label10;
        private TextBox tx_box1;
        private TextBox tx_box2;
        private TextBox tx_box3;
        private TextBox tx_box4;
        private TextBox tx_box6;
        private TextBox tx_box7;
        private TextBox tx_box5;
        private Label label11;
    }
}