namespace Commercial_Automation_Database
{
    partial class ÜRÜNLER
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(527, 483);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(558, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 483);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÜRÜN EKLE";
            // 
            // button1
            // 
            button1.Location = new Point(152, 435);
            button1.Name = "button1";
            button1.Size = new Size(185, 29);
            button1.TabIndex = 16;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(152, 382);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(185, 27);
            textBox5.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(25, 381);
            label7.Name = "label7";
            label7.Size = new Size(121, 28);
            label7.TabIndex = 14;
            label7.Text = "SATIŞ FİYATI:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(152, 333);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(185, 27);
            textBox6.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(36, 333);
            label8.Name = "label8";
            label8.Size = new Size(110, 28);
            label8.TabIndex = 12;
            label8.Text = "ALIŞ FİYATI:";
            label8.Click += label8_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(152, 294);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(185, 27);
            numericUpDown1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(83, 293);
            label6.Name = "label6";
            label6.Size = new Size(63, 28);
            label6.TabIndex = 10;
            label6.Text = "ADET:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(105, 245);
            label5.Name = "label5";
            label5.Size = new Size(41, 28);
            label5.TabIndex = 9;
            label5.Text = "YIL:";
            label5.Click += label5_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(152, 249);
            maskedTextBox1.Mask = "0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(185, 27);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox4
            // 
            textBox4.Location = new Point(152, 199);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(185, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(64, 195);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 6;
            label4.Text = "MODEL:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(62, 143);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 4;
            label3.Text = "MARKA:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(38, 87);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 2;
            label2.Text = "ÜRÜN ADI:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(111, 38);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // ÜRÜNLER
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 507);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "ÜRÜNLER";
            Text = "ÜRÜNLER";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label5;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Button button1;
    }
}