using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        private BindingList<Sinh_Vien> studentList;
        private List<LopHoc> classList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initialize in-memory lists
            classList = new List<LopHoc>
            {
                new LopHoc { MaLop = "CSE0001", TenLop = "CSE - 1" },
                new LopHoc { MaLop = "CSE0002", TenLop = "CSE - 2" }
            };

            studentList = new BindingList<Sinh_Vien>();

            // bind classes to comboBox1
            comboBox1.DataSource = classList;

            // bind students to grid
            dataGridView1.DataSource = studentList;

            // set initial focus and button states
            ActiveControl = textBox1; // txtMaSV
            button2.Enabled = true; // Thêm
            button3.Enabled = false; // Sửa
            button4.Enabled = false; // Xóa

            // wire events
            textBox1.Leave += textBox1_Leave;
            button2.Click += btnAdd_Click;
            button3.Click += btnEdit_Click;
            button4.Click += btnDelete_Click;
            button5.Click += btnRefresh_Click;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            var key = textBox1.Text?.Trim();
            if (string.IsNullOrEmpty(key)) return;

            var found = studentList.FirstOrDefault(s => string.Equals(s.MaSV, key, StringComparison.OrdinalIgnoreCase));
            if (found != null)
            {
                LoadStudentToForm(found);
                textBox1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                // not found - clear other inputs and enable Add
                ClearForm(keepMaSv: true);
                textBox1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void LoadStudentToForm(Sinh_Vien s)
        {
            if (s == null) return;
            textBox2.Text = s.HoTen;
            dateTimePicker1.Value = s.NgaySinh == DateTime.MinValue ? DateTime.Today : s.NgaySinh;
            // select class by MaLop
            var cls = classList.FirstOrDefault(c => c.MaLop == s.MaLop);
            if (cls != null) comboBox1.SelectedItem = cls;
            radioButton1.Checked = string.Equals(s.GioiTinh, "Nam", StringComparison.OrdinalIgnoreCase);
            radioButton2.Checked = !radioButton1.Checked;
            textBox4.Text = s.Email;
            textBox5.Text = s.SoDienThoai;
            comboBox2.Text = s.TrangThai;
        }

        private Sinh_Vien GetStudentFromForm()
        {
            var s = new Sinh_Vien
            {
                MaSV = textBox1.Text?.Trim(),
                HoTen = textBox2.Text?.Trim(),
                MaLop = (comboBox1.SelectedItem as LopHoc)?.MaLop,
                NgaySinh = dateTimePicker1.Value,
                GioiTinh = radioButton1.Checked ? "Nam" : "Nữ",
                Email = textBox4.Text?.Trim(),
                SoDienThoai = textBox5.Text?.Trim(),
                TrangThai = comboBox2.Text?.Trim()
            };
            return s;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var s = GetStudentFromForm();
            if (studentList.Any(x => string.Equals(x.MaSV, s.MaSV, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("MaSV already exists.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!s.Validate(out var results))
            {
                MessageBox.Show(string.Join("\n", results.Select(r => r.ErrorMessage)), "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            studentList.Add(s);
            MessageBox.Show("Student added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var key = textBox1.Text?.Trim();
            var existing = studentList.FirstOrDefault(s => string.Equals(s.MaSV, key, StringComparison.OrdinalIgnoreCase));
            if (existing == null) return;

            var updated = GetStudentFromForm();
            if (!updated.Validate(out var results))
            {
                MessageBox.Show(string.Join("\n", results.Select(r => r.ErrorMessage)), "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // confirm
            if (MessageBox.Show("Apply changes to the selected student?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            // update properties
            existing.HoTen = updated.HoTen;
            existing.MaLop = updated.MaLop;
            existing.NgaySinh = updated.NgaySinh;
            existing.GioiTinh = updated.GioiTinh;
            existing.Email = updated.Email;
            existing.SoDienThoai = updated.SoDienThoai;
            existing.TrangThai = updated.TrangThai;

            // refresh grid
            dataGridView1.Refresh();
            MessageBox.Show("Student updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var key = textBox1.Text?.Trim();
            var existing = studentList.FirstOrDefault(s => string.Equals(s.MaSV, key, StringComparison.OrdinalIgnoreCase));
            if (existing == null) return;

            if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            studentList.Remove(existing);
            MessageBox.Show("Student removed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm(bool keepMaSv = false)
        {
            if (!keepMaSv) textBox1.Text = string.Empty;
            textBox1.Enabled = true;
            textBox2.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Today;
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = true;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            comboBox2.SelectedIndex = -1;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
            ActiveControl = textBox1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var s = dataGridView1.Rows[e.RowIndex].DataBoundItem as Sinh_Vien;
            if (s == null) return;
            LoadStudentToForm(s);
            textBox1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        // Designer event handler stubs (kept empty intentionally)
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
    }
}
