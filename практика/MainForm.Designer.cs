namespace MoscowDataViewer
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.listViewData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbAdmDistrict = new System.Windows.Forms.ComboBox();
            this.cmbCityDistrict = new System.Windows.Forms.ComboBox();
            this.lblAdmDistrict = new System.Windows.Forms.Label();
            this.lblCityDistrict = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 12);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(100, 30);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // listViewData
            // 
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewData.FullRowSelect = true;
            this.listViewData.GridLines = true;
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(12, 80);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(1000, 400);
            this.listViewData.TabIndex = 1;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Address";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AdmDistrict";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CityDistrict";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Latitude";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Longitude";
            this.columnHeader5.Width = 150;
            // 
            // cmbAdmDistrict
            // 
            this.cmbAdmDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdmDistrict.FormattingEnabled = true;
            this.cmbAdmDistrict.Location = new System.Drawing.Point(150, 50);
            this.cmbAdmDistrict.Name = "cmbAdmDistrict";
            this.cmbAdmDistrict.Size = new System.Drawing.Size(200, 21);
            this.cmbAdmDistrict.TabIndex = 2;
            this.cmbAdmDistrict.SelectedIndexChanged += new System.EventHandler(this.cmbAdmDistrict_SelectedIndexChanged);
            // 
            // cmbCityDistrict
            // 
            this.cmbCityDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCityDistrict.FormattingEnabled = true;
            this.cmbCityDistrict.Location = new System.Drawing.Point(400, 50);
            this.cmbCityDistrict.Name = "cmbCityDistrict";
            this.cmbCityDistrict.Size = new System.Drawing.Size(200, 21);
            this.cmbCityDistrict.TabIndex = 3;
            this.cmbCityDistrict.SelectedIndexChanged += new System.EventHandler(this.cmbCityDistrict_SelectedIndexChanged);
            // 
            // lblAdmDistrict
            // 
            this.lblAdmDistrict.AutoSize = true;
            this.lblAdmDistrict.ForeColor = System.Drawing.Color.White;
            this.lblAdmDistrict.Location = new System.Drawing.Point(150, 30);
            this.lblAdmDistrict.Name = "lblAdmDistrict";
            this.lblAdmDistrict.Size = new System.Drawing.Size(65, 13);
            this.lblAdmDistrict.TabIndex = 4;
            this.lblAdmDistrict.Text = "Adm District";
            // 
            // lblCityDistrict
            // 
            this.lblCityDistrict.AutoSize = true;
            this.lblCityDistrict.ForeColor = System.Drawing.Color.White;
            this.lblCityDistrict.Location = new System.Drawing.Point(400, 30);
            this.lblCityDistrict.Name = "lblCityDistrict";
            this.lblCityDistrict.Size = new System.Drawing.Size(60, 13);
            this.lblCityDistrict.TabIndex = 5;
            this.lblCityDistrict.Text = "City District";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 561);
            this.Controls.Add(this.lblCityDistrict);
            this.Controls.Add(this.lblAdmDistrict);
            this.Controls.Add(this.cmbCityDistrict);
            this.Controls.Add(this.cmbAdmDistrict);
            this.Controls.Add(this.listViewData);
            this.Controls.Add(this.btnLoadFile);
            this.Name = "MainForm";
            this.Text = "Moscow Data Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cmbAdmDistrict;
        private System.Windows.Forms.ComboBox cmbCityDistrict;
        private System.Windows.Forms.Label lblAdmDistrict;
        private System.Windows.Forms.Label lblCityDistrict;
    }
}
