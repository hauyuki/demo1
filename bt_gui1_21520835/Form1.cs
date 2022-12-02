using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bt_gui1_21520835
{
   
    public partial class Form1 : Form
    {
        string strcon = @"Data Source=LAPTOP-5NORLG2S\SQLEXPRESS;Initial Catalog=Sinhvien;Integrated Security=True";
        SqlConnection sqlcon = null;
        public Form1()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            txtMssv.Text = "";
            txtTen.Text = "";
            txtMalop.Text = "";
            txtGpa.Text = "";
        }
        public bool KTThongTin()
        {
            if (txtMssv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập MSSV sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMssv.Focus();
                return false;
            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return false;
            }
            if (txtMalop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã lớp sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMalop.Focus();
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void ShowList()
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strcon);
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from Student";

            sqlCmd.Connection = sqlcon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            listView1.Items.Clear();
            while (reader.Read())
            {
                int maSV = reader.GetInt32(0);
                string tenSV = reader.GetString(1);
                string lopSV = reader.GetString(2);
                float gpaSV = reader.GetFloat(3);

                ListViewItem lvi = new ListViewItem(maSV.ToString());
                lvi.SubItems.Add(tenSV);
                lvi.SubItems.Add(lopSV);
                lvi.SubItems.Add(gpaSV.ToString());

                listView1.Items.Add(lvi);
            }
            reader.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(strcon);
                }
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string mssv = txtMssv.Text.Trim();
                string ten = txtTen.Text.Trim();
                string malop = txtMalop.Text.Trim();
                string gpa = txtGpa.Text.Trim();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "insert into Student values('" + mssv + "',N'" + ten + "','" + malop + "'," + gpa + ")";

                sqlCmd.Connection = sqlcon;
                int kq = sqlCmd.ExecuteNonQuery();
                if (kq>0)
                {
                    ShowList();
                }

            
                string[] appendtext = {"MSSV: " + txtMssv.Text, "Tên: " + txtTen.Text, "Mã lớp: " + txtMalop.Text, "GPA: " + txtGpa.Text, "*****************" };
                File.AppendAllLines("D:\\codesource\\C#\\bt_gui1_21520835\\dssv.txt", appendtext);
                Reset();
                MessageBox.Show("Đã thêm mới sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (sqlcon == null)
            {
                sqlcon = new SqlConnection(strcon);
            }
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            string mssv = txtMssv.Text.Trim();
            string ten = txtTen.Text.Trim();
            string malop = txtMalop.Text.Trim();
            string gpa = txtGpa.Text.Trim();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update Student set Id = '"+mssv+"',Name = N'"+ten+"',Class = '"+malop+"',GPA = "+gpa+"where Id = '"+mssv+"'";

            sqlCmd.Connection = sqlcon;
            int kq = sqlCmd.ExecuteNonQuery();
            if (kq > 0)
            {
                ShowList();
            }


            string[] appendtext = { "MSSV: " + txtMssv.Text, "Tên: " + txtTen.Text, "Mã lớp: " + txtMalop.Text, "GPA: " + txtGpa.Text, "*****************" };
            File.AppendAllLines("D:\\codesource\\C#\\bt_gui1_21520835\\dssv.txt", appendtext);
            Reset();
            MessageBox.Show("Chỉnh sửa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem lvi = listView1.SelectedItems[0];
            txtMssv.Text = lvi.SubItems[0].Text;
            txtTen.Text = lvi.SubItems[1].Text;
            txtMalop.Text = lvi.SubItems[2].Text;
            txtGpa.Text = lvi.SubItems[3].Text;
        }
    }
}
