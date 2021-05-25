﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace QLNV_De5_n17dccn048
{
    public partial class FormUpdate : Form
    {
        public delegate void NewHome();
        public event NewHome OnNewHome;
        String conn = "Data Source=NGUYENHIEU;Initial Catalog=QLNV;Persist Security Info=True;User ID=sa;Password=123";
        SqlConnection con = null;
        

        public FormUpdate()
        {
            InitializeComponent();
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();
            }
            catch (Exception)
            {

                throw;
            }
            SqlDependency.Stop(conn);
            SqlDependency.Start(conn);
            con = new SqlConnection(conn);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            func(Controls);
            cbPhai.SelectedIndex = -1;
            tbDate.Value = DateTime.Now;
            reLoadData();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            OnNewHome += new NewHome(Form1_OnNewHome);
            LoadData();

        }

        public void reLoadData()
        {
            this.nHANVIENTableAdapter.Fill(this.qLNVDataSet.NHANVIEN);
            this.nHANVIENBindingSource.ResetBindings(false);
        }

        public void Add( String HO, String TEN,
                                            String PHAI, String DIACHI, String NGAYSINH, String LUONG)
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;
           
            try
            {
                conn = new
                    SqlConnection("Data Source=NGUYENHIEU;Initial Catalog=QLNV;Persist Security Info=True;User ID=sa;Password=123");
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"Sp_ThemNV", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@HO", HO));
                cmd.Parameters.Add(new SqlParameter("@TEN", TEN));
                cmd.Parameters.Add(new SqlParameter("@PHAI", PHAI));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", DIACHI));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", NGAYSINH));
                cmd.Parameters.Add(new SqlParameter("@LUONG", LUONG));
                cmd.Parameters.Add(new SqlParameter("@MACN", "TPHCM"));

                // execute the command
                rdr = cmd.ExecuteReader();
                reLoadData();
                this.btnExit.PerformClick();
                MessageBox.Show("Thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Errors[0].Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }

        public void Delete(int MANV)
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;

            try
            {
                conn = new
                    SqlConnection("Data Source=NGUYENHIEU;Initial Catalog=QLNV;Persist Security Info=True;User ID=sa;Password=123");
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"Sp_DeleteNV", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MANV", MANV));

                // execute the command
                rdr = cmd.ExecuteReader();
                reLoadData();
                this.btnExit.PerformClick();
                MessageBox.Show("Thành công!");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }

        public void Update(int MANV, String HO, String TEN,
                                            String PHAI, String DIACHI, String NGAYSINH, String LUONG)
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;

            try
            {
                conn = new
                    SqlConnection("Data Source=NGUYENHIEU;Initial Catalog=QLNV;Persist Security Info=True;User ID=sa;Password=123");
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"Sp_UpdateNV", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MANV", MANV));
                cmd.Parameters.Add(new SqlParameter("@HO", HO));
                cmd.Parameters.Add(new SqlParameter("@TEN", TEN));
                cmd.Parameters.Add(new SqlParameter("@PHAI", PHAI));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", DIACHI));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", NGAYSINH));
                cmd.Parameters.Add(new SqlParameter("@LUONG", LUONG));
                cmd.Parameters.Add(new SqlParameter("@MACN", "TPHCM"));

                // execute the command
                rdr = cmd.ExecuteReader();
                reLoadData();
                this.btnExit.PerformClick();
                MessageBox.Show("Thành công!");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }

        // SQL Dependency
        public void de_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency de = sender as SqlDependency;
            de.OnChange -= de_OnChange;
            if (OnNewHome != null)
            {
                OnNewHome();
            }
        }

        public void Form1_OnNewHome()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)
            {
                NewHome dd = new NewHome(Form1_OnNewHome);
                i.BeginInvoke(dd, null);
                return;
            }
            LoadData();
        }

        void LoadData()
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT  MANV, HO, TEN, PHAI, DIACHI, NGAYSINH, LUONG, MACN, TRANGTHAI FROM[dbo].[NHANVIEN] WHERE TRANGTHAI = 'False'", con);
            cmd.Notification = null;

            SqlDependency de = new SqlDependency(cmd);
            de.OnChange += new OnChangeEventHandler(de_OnChange);

            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate() == false) return;

            Add(tbHo.Text, tbTen.Text, cbPhai.Text, tbDiaChi.Text, tbDate.Value.ToString("yyyyMMdd"), tbLuong.Text.Replace(".", ""));

        }

        
        private bool validate()
        {
            if (tbHo.Text == string.Empty)
            {
                MessageBox.Show("Nhập Họ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (tbTen.Text == string.Empty)
            {
                MessageBox.Show("Nhập Tên!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (tbDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Nhập Địa Chỉ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (cbPhai.SelectedIndex == -1)
            {
                MessageBox.Show("Nhập Phái!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (tbDate.Text == string.Empty)
            {
                MessageBox.Show("Nhập Ngày!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (tbLuong.Text == string.Empty)
            {
                MessageBox.Show("Nhập Lương!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
           
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validate() == false) return;
            Update(int.Parse(tbMaNV.Text), tbHo.Text, tbTen.Text, cbPhai.Text, tbDiaChi.Text, tbDate.Value.ToString("yyyyMMdd"), tbLuong.Text.Replace(".", ""));
        }


        int manv;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbMaNV.Text == string.Empty) MessageBox.Show("Nhập Mã NV!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if ((MessageBox.Show("Bạn có muốn xóa?", "Warning!",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                Delete(this.manv);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExit.PerformClick();

            if ((e.RowIndex + 1) == (dataGridView1.Rows.Count) || e.RowIndex < 0) return;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            this.manv = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.tbMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.tbHo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.tbTen.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.cbPhai.SelectedIndex = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "NAM" ? 0 : 1;
            this.tbDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.tbDate.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.tbLuong.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", double.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()));

        }

        private void tbLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            if (e.KeyChar == (char)13)
            {
                tbLuong.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", double.Parse(tbLuong.Text));
            }
        }



        private void tbMaNV_TextChanged(object sender, EventArgs e)
        {
            this.tbMaNV.ReadOnly = true;
        }

    }
}
