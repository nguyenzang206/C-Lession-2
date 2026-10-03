namespace QuanLySinhVien
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            thông = new GroupBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label10 = new Label();
            txtTim = new TextBox();
            label11 = new Label();
            comboBox3 = new ComboBox();
            label12 = new Label();
            textBox3 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            panel2 = new Panel();
            label13 = new Label();
            txtTong = new Label();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            thông.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(381, 116);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nam";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(490, 116);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 24);
            radioButton2.TabIndex = 2;
            radioButton2.Text = "Nữ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 53);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã SV:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(87, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 53);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 6;
            label2.Text = "Họ Tên *";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Location = new Point(381, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(689, 53);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 8;
            label3.Text = "Lớp học";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 116);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 10;
            label4.Text = "Ngày sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(87, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.Value = new DateTime(2026, 10, 3, 9, 38, 35, 0);
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.Control;
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(775, 113);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(689, 116);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 15;
            label5.Text = "Điểm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(285, 116);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 16;
            label6.Text = "Giới tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 172);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 17;
            label7.Text = "Email*";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Menu;
            textBox4.Location = new Point(87, 165);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(284, 172);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 19;
            label8.Text = "Điện thoại";
            label8.Click += label8_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Menu;
            textBox5.Location = new Point(381, 169);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 27);
            textBox5.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(689, 176);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 21;
            label9.Text = "Trạng thái";
            // 
            // button2
            // 
            button2.Location = new Point(563, 234);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 23;
            button2.Text = "&Thêm";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(689, 234);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 24;
            button3.Text = "&Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(820, 234);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 25;
            button4.Text = "&Xóa";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(946, 234);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 26;
            button5.Text = "&Làm mới";
            button5.UseVisualStyleBackColor = true;
            // 
            // thông
            // 
            thông.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            thông.BackColor = SystemColors.Control;
            thông.Controls.Add(button1);
            thông.Controls.Add(comboBox2);
            thông.Controls.Add(comboBox1);
            thông.Controls.Add(label1);
            thông.Controls.Add(button5);
            thông.Controls.Add(textBox1);
            thông.Controls.Add(button4);
            thông.Controls.Add(label7);
            thông.Controls.Add(button3);
            thông.Controls.Add(textBox4);
            thông.Controls.Add(button2);
            thông.Controls.Add(label4);
            thông.Controls.Add(dateTimePicker1);
            thông.Controls.Add(label2);
            thông.Controls.Add(label9);
            thông.Controls.Add(textBox2);
            thông.Controls.Add(numericUpDown1);
            thông.Controls.Add(label5);
            thông.Controls.Add(label6);
            thông.Controls.Add(textBox5);
            thông.Controls.Add(radioButton1);
            thông.Controls.Add(label8);
            thông.Controls.Add(label3);
            thông.Controls.Add(radioButton2);
            thông.Location = new Point(28, 24);
            thông.Name = "thông";
            thông.Size = new Size(1216, 295);
            thông.TabIndex = 29;
            thông.TabStop = false;
            thông.Text = "Thông tin sinh viên";
            thông.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(1067, 234);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 27;
            button1.Text = "&Đóng";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.Menu;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(774, 172);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Menu;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(775, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtTim);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(30, 347);
            panel1.Name = "panel1";
            panel1.Size = new Size(1214, 63);
            panel1.TabIndex = 30;
            panel1.Paint += panel1_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 17);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 5;
            label10.Text = "từ khóa";
            label10.Click += label10_Click;
            // 
            // txtTim
            // 
            txtTim.BackColor = SystemColors.Menu;
            txtTim.Location = new Point(65, 17);
            txtTim.Name = "txtTim";
            txtTim.PlaceholderText = "Mã SV, Email, Điện thoại";
            txtTim.Size = new Size(181, 27);
            txtTim.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(332, 17);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 9;
            label11.Text = "Lớp học";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = SystemColors.Menu;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(400, 17);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(611, 20);
            label12.Name = "label12";
            label12.Size = new Size(63, 20);
            label12.TabIndex = 23;
            label12.Text = "Điểm từ";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Menu;
            textBox3.Location = new Point(699, 18);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 24;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button6
            // 
            button6.Location = new Point(919, 20);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 27;
            button6.Text = "&Tìm";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(1056, 20);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 28;
            button7.Text = "&Đóng";
            button7.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(txtTong);
            panel2.Controls.Add(label13);
            panel2.Location = new Point(30, 444);
            panel2.Name = "panel2";
            panel2.Size = new Size(1214, 294);
            panel2.TabIndex = 31;
            panel2.Paint += panel2_Paint;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 9);
            label13.Name = "label13";
            label13.Size = new Size(138, 20);
            label13.TabIndex = 5;
            label13.Text = "Danh sách sinh viên";
            // 
            // txtTong
            // 
            txtTong.AutoSize = true;
            txtTong.Location = new Point(1076, 9);
            txtTong.Name = "txtTong";
            txtTong.Size = new Size(43, 20);
            txtTong.TabIndex = 6;
            txtTong.Text = "Tổng";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Menu;
            textBox6.Location = new Point(1122, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(89, 27);
            textBox6.TabIndex = 25;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1208, 273);
            dataGridView1.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 761);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(thông);
            Name = "Form1";
            Text = "Ứng dụng quản lý";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            thông.ResumeLayout(false);
            thông.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private GroupBox thông;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Panel panel1;
        private Label label10;
        private TextBox txtTim;
        private Label label12;
        private TextBox textBox3;
        private ComboBox comboBox3;
        private Label label11;
        private Button button7;
        private Button button6;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBox6;
        private Label txtTong;
        private Label label13;
    }
}
