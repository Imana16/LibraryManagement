namespace LibraryManagement
{
    partial class GenerateReports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblselectreport = new Label();
            comboBoxReports = new ComboBox();
            btnGenerateReport = new Button();
            dgvReports = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // lblselectreport
            // 
            lblselectreport.AutoSize = true;
            lblselectreport.Location = new Point(30, 28);
            lblselectreport.Name = "lblselectreport";
            lblselectreport.Size = new Size(98, 20);
            lblselectreport.TabIndex = 0;
            lblselectreport.Text = "Select Report";
            // 
            // comboBoxReports
            // 
            comboBoxReports.FormattingEnabled = true;
            comboBoxReports.Location = new Point(150, 25);
            comboBoxReports.Name = "comboBoxReports";
            comboBoxReports.Size = new Size(237, 28);
            comboBoxReports.TabIndex = 1;
            comboBoxReports.SelectedIndexChanged += comboBoxReports_SelectedIndexChanged;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(408, 24);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(151, 29);
            btnGenerateReport.TabIndex = 2;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dgvReports
            // 
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(3, 75);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(954, 589);
            dgvReports.TabIndex = 3;
            // 
            // GenerateReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvReports);
            Controls.Add(btnGenerateReport);
            Controls.Add(comboBoxReports);
            Controls.Add(lblselectreport);
            Name = "GenerateReports";
            Size = new Size(957, 664);
            Load += GenerateReports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblselectreport;
        private ComboBox comboBoxReports;
        private Button btnGenerateReport;
        private DataGridView dgvReports;
    }
}
