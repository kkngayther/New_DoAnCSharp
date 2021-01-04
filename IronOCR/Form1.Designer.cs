namespace IronOCR
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCapture = new System.Windows.Forms.Button();
            this.pnlAppearances = new System.Windows.Forms.Panel();
            this.dgvAppearances = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTheSinhVien = new System.Windows.Forms.Panel();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.ptbAnhSinhVien = new System.Windows.Forms.PictureBox();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.lbKhoas = new System.Windows.Forms.Label();
            this.lbTenSinhVien = new System.Windows.Forms.Label();
            this.ptbKhungCamera = new System.Windows.Forms.PictureBox();
            this.pnlAppearances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppearances)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlTheSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKhungCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(10, 37);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 47);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.Maroon;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.ForeColor = System.Drawing.Color.White;
            this.btnCapture.Location = new System.Drawing.Point(146, 37);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(112, 47);
            this.btnCapture.TabIndex = 5;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // pnlAppearances
            // 
            this.pnlAppearances.Controls.Add(this.dgvAppearances);
            this.pnlAppearances.Location = new System.Drawing.Point(507, 96);
            this.pnlAppearances.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAppearances.Name = "pnlAppearances";
            this.pnlAppearances.Size = new System.Drawing.Size(407, 243);
            this.pnlAppearances.TabIndex = 12;
            // 
            // dgvAppearances
            // 
            this.dgvAppearances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppearances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppearances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppearances.Location = new System.Drawing.Point(0, 0);
            this.dgvAppearances.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAppearances.Name = "dgvAppearances";
            this.dgvAppearances.RowHeadersWidth = 51;
            this.dgvAppearances.RowTemplate.Height = 24;
            this.dgvAppearances.Size = new System.Drawing.Size(407, 243);
            this.dgvAppearances.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýDữLiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýDữLiệuToolStripMenuItem
            // 
            this.quảnLýDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dữLiệuToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
            this.quảnLýDữLiệuToolStripMenuItem.Name = "quảnLýDữLiệuToolStripMenuItem";
            this.quảnLýDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.quảnLýDữLiệuToolStripMenuItem.Text = "Quản lý dữ liệu";
            // 
            // dữLiệuToolStripMenuItem
            // 
            this.dữLiệuToolStripMenuItem.Name = "dữLiệuToolStripMenuItem";
            this.dữLiệuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dữLiệuToolStripMenuItem.Text = "Dữ liệu";
            this.dữLiệuToolStripMenuItem.Click += new System.EventHandler(this.dữLiệuToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // pnlTheSinhVien
            // 
            this.pnlTheSinhVien.BackgroundImage = global::IronOCR.Properties.Resources.khungthesinhvien;
            this.pnlTheSinhVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTheSinhVien.Controls.Add(this.lbMSSV);
            this.pnlTheSinhVien.Controls.Add(this.ptbAnhSinhVien);
            this.pnlTheSinhVien.Controls.Add(this.lbKhoa);
            this.pnlTheSinhVien.Controls.Add(this.lbKhoas);
            this.pnlTheSinhVien.Controls.Add(this.lbTenSinhVien);
            this.pnlTheSinhVien.Location = new System.Drawing.Point(507, 345);
            this.pnlTheSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTheSinhVien.Name = "pnlTheSinhVien";
            this.pnlTheSinhVien.Size = new System.Drawing.Size(407, 243);
            this.pnlTheSinhVien.TabIndex = 11;
            // 
            // lbMSSV
            // 
            this.lbMSSV.BackColor = System.Drawing.Color.Transparent;
            this.lbMSSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Location = new System.Drawing.Point(10, 206);
            this.lbMSSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(82, 22);
            this.lbMSSV.TabIndex = 15;
            this.lbMSSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbAnhSinhVien
            // 
            this.ptbAnhSinhVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbAnhSinhVien.Location = new System.Drawing.Point(10, 84);
            this.ptbAnhSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.ptbAnhSinhVien.Name = "ptbAnhSinhVien";
            this.ptbAnhSinhVien.Size = new System.Drawing.Size(82, 122);
            this.ptbAnhSinhVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnhSinhVien.TabIndex = 6;
            this.ptbAnhSinhVien.TabStop = false;
            // 
            // lbKhoa
            // 
            this.lbKhoa.BackColor = System.Drawing.Color.Transparent;
            this.lbKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoa.Location = new System.Drawing.Point(92, 164);
            this.lbKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(276, 28);
            this.lbKhoa.TabIndex = 14;
            this.lbKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKhoas
            // 
            this.lbKhoas.BackColor = System.Drawing.Color.Transparent;
            this.lbKhoas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoas.Location = new System.Drawing.Point(92, 142);
            this.lbKhoas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKhoas.Name = "lbKhoas";
            this.lbKhoas.Size = new System.Drawing.Size(276, 28);
            this.lbKhoas.TabIndex = 13;
            this.lbKhoas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTenSinhVien
            // 
            this.lbTenSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.lbTenSinhVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSinhVien.Location = new System.Drawing.Point(92, 109);
            this.lbTenSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenSinhVien.Name = "lbTenSinhVien";
            this.lbTenSinhVien.Size = new System.Drawing.Size(276, 28);
            this.lbTenSinhVien.TabIndex = 12;
            this.lbTenSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbKhungCamera
            // 
            this.ptbKhungCamera.Location = new System.Drawing.Point(10, 96);
            this.ptbKhungCamera.Margin = new System.Windows.Forms.Padding(2);
            this.ptbKhungCamera.Name = "ptbKhungCamera";
            this.ptbKhungCamera.Size = new System.Drawing.Size(483, 492);
            this.ptbKhungCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbKhungCamera.TabIndex = 1;
            this.ptbKhungCamera.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 595);
            this.Controls.Add(this.pnlAppearances);
            this.Controls.Add(this.pnlTheSinhVien);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ptbKhungCamera);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Identification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlAppearances.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppearances)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTheSinhVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKhungCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbKhungCamera;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.PictureBox ptbAnhSinhVien;
        private System.Windows.Forms.Panel pnlTheSinhVien;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Label lbKhoas;
        private System.Windows.Forms.Label lbTenSinhVien;
        private System.Windows.Forms.Panel pnlAppearances;
        private System.Windows.Forms.DataGridView dgvAppearances;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
    }
}

