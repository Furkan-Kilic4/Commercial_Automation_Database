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
            button2 = new Button();
            button1 = new Button();
            TXTSATIS = new TextBox();
            label7 = new Label();
            TXTALIS = new TextBox();
            label8 = new Label();
            NUADET = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            MTXTYIL = new MaskedTextBox();
            TXTMODEL = new TextBox();
            label4 = new Label();
            TXTMARKA = new TextBox();
            label3 = new Label();
            TXTAD = new TextBox();
            label2 = new Label();
            TXTID = new TextBox();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUADET).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(694, 574);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(TXTSATIS);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TXTALIS);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(NUADET);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(MTXTYIL);
            groupBox1.Controls.Add(TXTMODEL);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TXTMARKA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TXTAD);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TXTID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(741, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 574);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÜRÜN EKLE-SİL";
            // 
            // button2
            // 
            button2.Location = new Point(152, 485);
            button2.Name = "button2";
            button2.Size = new Size(185, 29);
            button2.TabIndex = 17;
            button2.Text = "SİL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(152, 435);
            button1.Name = "button1";
            button1.Size = new Size(185, 29);
            button1.TabIndex = 16;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TXTSATIS
            // 
            TXTSATIS.Location = new Point(152, 382);
            TXTSATIS.Name = "TXTSATIS";
            TXTSATIS.Size = new Size(185, 27);
            TXTSATIS.TabIndex = 15;
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
            // TXTALIS
            // 
            TXTALIS.Location = new Point(152, 333);
            TXTALIS.Name = "TXTALIS";
            TXTALIS.Size = new Size(185, 27);
            TXTALIS.TabIndex = 13;
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
            // NUADET
            // 
            NUADET.Location = new Point(152, 294);
            NUADET.Name = "NUADET";
            NUADET.Size = new Size(185, 27);
            NUADET.TabIndex = 11;
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
            // MTXTYIL
            // 
            MTXTYIL.Location = new Point(152, 249);
            MTXTYIL.Mask = "0000";
            MTXTYIL.Name = "MTXTYIL";
            MTXTYIL.Size = new Size(185, 27);
            MTXTYIL.TabIndex = 8;
            MTXTYIL.ValidatingType = typeof(int);
            // 
            // TXTMODEL
            // 
            TXTMODEL.Location = new Point(152, 199);
            TXTMODEL.Name = "TXTMODEL";
            TXTMODEL.Size = new Size(185, 27);
            TXTMODEL.TabIndex = 7;
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
            // TXTMARKA
            // 
            TXTMARKA.Location = new Point(152, 144);
            TXTMARKA.Name = "TXTMARKA";
            TXTMARKA.Size = new Size(185, 27);
            TXTMARKA.TabIndex = 5;
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
            // TXTAD
            // 
            TXTAD.Location = new Point(152, 91);
            TXTAD.Name = "TXTAD";
            TXTAD.Size = new Size(185, 27);
            TXTAD.TabIndex = 3;
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
            // TXTID
            // 
            TXTID.Location = new Point(152, 42);
            TXTID.Name = "TXTID";
            TXTID.Size = new Size(185, 27);
            TXTID.TabIndex = 1;
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
            // button3
            // 
            button3.Location = new Point(152, 539);
            button3.Name = "button3";
            button3.Size = new Size(185, 29);
            button3.TabIndex = 18;
            button3.Text = "GÜNCELLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ÜRÜNLER
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 615);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "ÜRÜNLER";
            Text = "ÜRÜNLER";
            Load += ÜRÜNLER_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUADET).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox TXTMODEL;
        private Label label4;
        private TextBox TXTMARKA;
        private Label label3;
        private TextBox TXTAD;
        private Label label2;
        private TextBox TXTID;
        private Label label1;
        private Label label5;
        private MaskedTextBox MTXTYIL;
        private TextBox TXTSATIS;
        private Label label7;
        private TextBox TXTALIS;
        private Label label8;
        private NumericUpDown NUADET;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}