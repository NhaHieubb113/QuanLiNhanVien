﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLNV_De5_n17dccn048
{
    public partial class main : DevExpress.XtraEditors.XtraForm
    {
        public delegate void NewHome();
        public event NewHome OnNewHome;
        String conn = "Data Source=NGUYENHIEU;Initial Catalog=QLNV;Persist Security Info=True;User ID=sa;Password=123";
        SqlConnection con = null;

        public main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
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

        private void main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNVDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            OnNewHome += new NewHome(Form1_OnNewHome);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate formUpdate = new QLNV_De5_n17dccn048.FormUpdate();
            formUpdate.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // SQL Dependency
        int count = 1;
        public void de_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency de = sender as SqlDependency;
            de.OnChange -= de_OnChange;
            if (OnNewHome != null)
            {
                OnNewHome();
            }

            if (e.Type == SqlNotificationType.Change)
            {
                // your code
                rtBox.AppendText("#" + count + "\n");
                rtBox.AppendText("Info: " + e.Info.ToString() + "\n");
                rtBox.AppendText("Source: " + e.Source.ToString() + "\n");
                rtBox.AppendText("Type: " + e.Type.ToString() + "\n\n");
                lbNotification.Text = "Đã có " + count + " thay đổi!";
                count++;
            }
        }

        public void Form1_OnNewHome()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)//tab
            {
                NewHome dd = new NewHome(Form1_OnNewHome);
                i.BeginInvoke(dd, null);
                return;
            }
            LoadData();
        }

        //Ham load data
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.nHANVIENTableAdapter.Fill(this.qLNVDataSet.NHANVIEN);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.nHANVIENTableAdapter.Fill(this.qLNVDataSet.NHANVIEN);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.nHANVIENTableAdapter.Fill(this.qLNVDataSet.NHANVIEN);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
