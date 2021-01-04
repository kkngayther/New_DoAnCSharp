namespace IronOCR
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapTimKiem = new System.Windows.Forms.TextBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new IronOCR.Database1DataSet();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbbLoaiDuLieu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentDataset = new IronOCR.StudentDataset();
            this.studentDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new IronOCR.Database1DataSetTableAdapters.StudentTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDatasetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập:";
            // 
            // txtNhapTimKiem
            // 
            this.txtNhapTimKiem.Location = new System.Drawing.Point(199, 70);
            this.txtNhapTimKiem.Name = "txtNhapTimKiem";
            this.txtNhapTimKiem.Size = new System.Drawing.Size(210, 20);
            this.txtNhapTimKiem.TabIndex = 2;
            // 
            // dgv2
            // 
            this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv2.AutoGenerateColumns = false;
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.session,
            this.department});
            this.dgv2.DataSource = this.studentBindingSource;
            this.dgv2.Location = new System.Drawing.Point(33, 126);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(540, 312);
            this.dgv2.TabIndex = 0;
            this.dgv2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(467, 62);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(106, 36);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbbLoaiDuLieu
            // 
            this.cbbLoaiDuLieu.FormattingEnabled = true;
            this.cbbLoaiDuLieu.Items.AddRange(new object[] {
            "ID",
            "Họ và Tên",
            "Khóa",
            "Khoa"});
            this.cbbLoaiDuLieu.Location = new System.Drawing.Point(12, 69);
            this.cbbLoaiDuLieu.Name = "cbbLoaiDuLieu";
            this.cbbLoaiDuLieu.Size = new System.Drawing.Size(116, 21);
            this.cbbLoaiDuLieu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại dữ liệu tìm kiếm:";
            // 
            // studentDataset
            // 
            this.studentDataset.DataSetName = "StudentDataset";
            this.studentDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDatasetBindingSource
            // 
            this.studentDatasetBindingSource.DataSource = this.studentDataset;
            this.studentDatasetBindingSource.Position = 0;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Họ và Tên";
            this.name.Name = "name";
            // 
            // session
            // 
            this.session.DataPropertyName = "session";
            this.session.HeaderText = "Khóa";
            this.session.Name = "session";
            // 
            // department
            // 
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "Khoa";
            this.department.Name = "department";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbLoaiDuLieu);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.txtNhapTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDatasetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        public System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.ComboBox cbbLoaiDuLieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource studentDatasetBindingSource;
        private StudentDataset studentDataset;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Database1DataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn session;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
    }
}