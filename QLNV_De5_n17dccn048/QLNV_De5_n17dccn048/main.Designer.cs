
namespace QLNV_De5_n17dccn048
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mACNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANGTHAIDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNVDataSet = new QLNV_De5_n17dccn048.QLNVDataSet();
            this.rtBox = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.nHANVIENTableAdapter = new QLNV_De5_n17dccn048.QLNVDataSetTableAdapters.NHANVIENTableAdapter();
            this.lbNotification = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.hODataGridViewTextBoxColumn,
            this.tENDataGridViewTextBoxColumn,
            this.pHAIDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.lUONGDataGridViewTextBoxColumn,
            this.mACNDataGridViewTextBoxColumn,
            this.tRANGTHAIDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.nHANVIENBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(37, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(842, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MÃ NV";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hODataGridViewTextBoxColumn
            // 
            this.hODataGridViewTextBoxColumn.DataPropertyName = "HO";
            this.hODataGridViewTextBoxColumn.HeaderText = "HỌ";
            this.hODataGridViewTextBoxColumn.Name = "hODataGridViewTextBoxColumn";
            this.hODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENDataGridViewTextBoxColumn
            // 
            this.tENDataGridViewTextBoxColumn.DataPropertyName = "TEN";
            this.tENDataGridViewTextBoxColumn.HeaderText = "TÊN";
            this.tENDataGridViewTextBoxColumn.Name = "tENDataGridViewTextBoxColumn";
            this.tENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pHAIDataGridViewTextBoxColumn
            // 
            this.pHAIDataGridViewTextBoxColumn.DataPropertyName = "PHAI";
            this.pHAIDataGridViewTextBoxColumn.HeaderText = "PHÁI";
            this.pHAIDataGridViewTextBoxColumn.Name = "pHAIDataGridViewTextBoxColumn";
            this.pHAIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "ĐỊA CHỈ";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGÀY SINH";
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            this.nGAYSINHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lUONGDataGridViewTextBoxColumn
            // 
            this.lUONGDataGridViewTextBoxColumn.DataPropertyName = "LUONG";
            this.lUONGDataGridViewTextBoxColumn.HeaderText = "LƯƠNG";
            this.lUONGDataGridViewTextBoxColumn.Name = "lUONGDataGridViewTextBoxColumn";
            this.lUONGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mACNDataGridViewTextBoxColumn
            // 
            this.mACNDataGridViewTextBoxColumn.DataPropertyName = "MACN";
            this.mACNDataGridViewTextBoxColumn.HeaderText = "MÃ CN";
            this.mACNDataGridViewTextBoxColumn.Name = "mACNDataGridViewTextBoxColumn";
            this.mACNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRANGTHAIDataGridViewCheckBoxColumn
            // 
            this.tRANGTHAIDataGridViewCheckBoxColumn.DataPropertyName = "TRANGTHAI";
            this.tRANGTHAIDataGridViewCheckBoxColumn.HeaderText = "ĐÃ NGHỈ VIỆC";
            this.tRANGTHAIDataGridViewCheckBoxColumn.Name = "tRANGTHAIDataGridViewCheckBoxColumn";
            this.tRANGTHAIDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLNVDataSetBindingSource;
            // 
            // qLNVDataSetBindingSource
            // 
            this.qLNVDataSetBindingSource.DataSource = this.qLNVDataSet;
            this.qLNVDataSetBindingSource.Position = 0;
            // 
            // qLNVDataSet
            // 
            this.qLNVDataSet.DataSetName = "QLNVDataSet";
            this.qLNVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rtBox
            // 
            this.rtBox.Location = new System.Drawing.Point(656, 73);
            this.rtBox.Name = "rtBox";
            this.rtBox.Size = new System.Drawing.Size(223, 80);
            this.rtBox.TabIndex = 1;
            this.rtBox.Text = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(37, 73);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnExit.Location = new System.Drawing.Point(37, 123);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // lbNotification
            // 
            this.lbNotification.AutoSize = true;
            this.lbNotification.Location = new System.Drawing.Point(376, 73);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(0, 13);
            this.lbNotification.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 384);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbNotification);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rtBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rtBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource qLNVDataSetBindingSource;
        private QLNVDataSet qLNVDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLNVDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.Label lbNotification;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tRANGTHAIDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label9;
    }
}

