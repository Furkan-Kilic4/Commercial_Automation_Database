namespace Commercial_Automation_Database
{
    partial class GİDERLER
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
            CBYIL = new ComboBox();
            CBAY = new ComboBox();
            TXTMAASLAR = new TextBox();
            TXTİNTERNET = new TextBox();
            TXTDOGALGAZ = new TextBox();
            label10 = new Label();
            BTNSIL = new Button();
            BTNKAYDET = new Button();
            label7 = new Label();
            TXTKİRA = new TextBox();
            label8 = new Label();
            NUADET = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            TXTSU = new TextBox();
            label3 = new Label();
            TXTELEKTIRIK = new TextBox();
            label2 = new Label();
            TXTID = new TextBox();
            label1 = new Label();
            BTNGUNCELLE = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUADET).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CBYIL);
            groupBox1.Controls.Add(CBAY);
            groupBox1.Controls.Add(TXTMAASLAR);
            groupBox1.Controls.Add(TXTİNTERNET);
            groupBox1.Controls.Add(TXTDOGALGAZ);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(BTNSIL);
            groupBox1.Controls.Add(BTNKAYDET);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TXTKİRA);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(NUADET);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TXTSU);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TXTELEKTIRIK);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TXTID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(741, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 574);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "GİDERLER";
            // 
            // CBYIL
            // 
            CBYIL.FormattingEnabled = true;
            CBYIL.Items.AddRange(new object[] { "2025", "2026\t", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040" });
            CBYIL.Location = new Point(159, 291);
            CBYIL.Name = "CBYIL";
            CBYIL.Size = new Size(185, 28);
            CBYIL.TabIndex = 30;
            // 
            // CBAY
            // 
            CBAY.FormattingEnabled = true;
            CBAY.Items.AddRange(new object[] { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos ", "Eylül", "Ekim", "Kasım", "Aralık" });
            CBAY.Location = new Point(159, 253);
            CBAY.Name = "CBAY";
            CBAY.Size = new Size(185, 28);
            CBAY.TabIndex = 29;
            // 
            // TXTMAASLAR
            // 
            TXTMAASLAR.Location = new Point(159, 220);
            TXTMAASLAR.Name = "TXTMAASLAR";
            TXTMAASLAR.Size = new Size(185, 27);
            TXTMAASLAR.TabIndex = 28;
            // 
            // TXTİNTERNET
            // 
            TXTİNTERNET.Location = new Point(159, 154);
            TXTİNTERNET.Name = "TXTİNTERNET";
            TXTİNTERNET.Size = new Size(185, 27);
            TXTİNTERNET.TabIndex = 27;
            // 
            // TXTDOGALGAZ
            // 
            TXTDOGALGAZ.Location = new Point(159, 121);
            TXTDOGALGAZ.Name = "TXTDOGALGAZ";
            TXTDOGALGAZ.Size = new Size(185, 27);
            TXTDOGALGAZ.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.Location = new Point(47, 219);
            label10.Name = "label10";
            label10.Size = new Size(106, 28);
            label10.TabIndex = 25;
            label10.Text = "MAAŞLAR:";
            // 
            // BTNSIL
            // 
            BTNSIL.Location = new Point(159, 367);
            BTNSIL.Name = "BTNSIL";
            BTNSIL.Size = new Size(185, 29);
            BTNSIL.TabIndex = 17;
            BTNSIL.Text = "SİL";
            BTNSIL.UseVisualStyleBackColor = true;
            BTNSIL.Click += BTNSIL_Click;
            // 
            // BTNKAYDET
            // 
            BTNKAYDET.Location = new Point(159, 332);
            BTNKAYDET.Name = "BTNKAYDET";
            BTNKAYDET.Size = new Size(185, 29);
            BTNKAYDET.TabIndex = 16;
            BTNKAYDET.Text = "KAYDET";
            BTNKAYDET.UseVisualStyleBackColor = true;
            BTNKAYDET.Click += BTNKAYDET_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(112, 287);
            label7.Name = "label7";
            label7.Size = new Size(41, 28);
            label7.TabIndex = 14;
            label7.Text = "YIL:";
            // 
            // TXTKİRA
            // 
            TXTKİRA.Location = new Point(159, 187);
            TXTKİRA.Name = "TXTKİRA";
            TXTKİRA.Size = new Size(185, 27);
            TXTKİRA.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(114, 253);
            label8.Name = "label8";
            label8.Size = new Size(39, 28);
            label8.TabIndex = 12;
            label8.Text = "AY:";
            // 
            // NUADET
            // 
            NUADET.Location = new Point(159, 274);
            NUADET.Name = "NUADET";
            NUADET.Size = new Size(0, 27);
            NUADET.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(95, 187);
            label6.Name = "label6";
            label6.Size = new Size(58, 28);
            label6.TabIndex = 10;
            label6.Text = "KİRA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(34, 117);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 9;
            label5.Text = "DOĞALGAZ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(50, 153);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 6;
            label4.Text = "İNTERNET:";
            // 
            // TXTSU
            // 
            TXTSU.Location = new Point(159, 88);
            TXTSU.Name = "TXTSU";
            TXTSU.Size = new Size(185, 27);
            TXTSU.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(112, 87);
            label3.Name = "label3";
            label3.Size = new Size(41, 28);
            label3.TabIndex = 4;
            label3.Text = "SU:";
            // 
            // TXTELEKTIRIK
            // 
            TXTELEKTIRIK.Location = new Point(159, 55);
            TXTELEKTIRIK.Name = "TXTELEKTIRIK";
            TXTELEKTIRIK.Size = new Size(185, 27);
            TXTELEKTIRIK.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(52, 54);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 2;
            label2.Text = "ELEKTİRİK:";
            // 
            // TXTID
            // 
            TXTID.Location = new Point(159, 22);
            TXTID.Name = "TXTID";
            TXTID.Size = new Size(185, 27);
            TXTID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(118, 18);
            label1.Name = "label1";
            label1.Size = new Size(35, 28);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // BTNGUNCELLE
            // 
            BTNGUNCELLE.Location = new Point(159, 364);
            BTNGUNCELLE.Name = "BTNGUNCELLE";
            BTNGUNCELLE.Size = new Size(185, 29);
            BTNGUNCELLE.TabIndex = 18;
            BTNGUNCELLE.Text = "GÜNCELLE";
            BTNGUNCELLE.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(694, 574);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // GİDERLER
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 615);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "GİDERLER";
            Text = "GİDERLER";
            Load += GİDERLER_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUADET).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label10;
        private TextBox TXTGOREV;
        private Label label9;
        private RichTextBox RTXTADRES;
        private ComboBox CBILCE;
        private ComboBox CBIL;
        private MaskedTextBox MTXTTC;
        private Button BTNGUNCELLE;
        private Button BTNSIL;
        private Button BTNKAYDET;
        private Label label7;
        private TextBox TXTKİRA;
        private Label label8;
        private NumericUpDown NUADET;
        private Label label6;
        private Label label5;
        private MaskedTextBox MTXTTEL;
        private Label label4;
        private TextBox TXTSU;
        private Label label3;
        private TextBox TXTELEKTIRIK;
        private Label label2;
        private TextBox TXTID;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox TXTİNTERNET;
        private TextBox TXTDOGALGAZ;
        private ComboBox CBYIL;
        private ComboBox CBAY;
        private TextBox TXTMAASLAR;
    }
}