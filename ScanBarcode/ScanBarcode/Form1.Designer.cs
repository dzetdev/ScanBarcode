namespace ScanBarcode
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
            this.tcScanBarcode = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbCam = new System.Windows.Forms.Label();
            this.lbresultdtgv = new System.Windows.Forms.Label();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.cbCam = new System.Windows.Forms.ComboBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.pbDisplayCam = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbtilte = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tcScanBarcode.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayCam)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tcScanBarcode
            // 
            this.tcScanBarcode.Controls.Add(this.tabPage1);
            this.tcScanBarcode.Controls.Add(this.tabPage2);
            this.tcScanBarcode.Location = new System.Drawing.Point(12, 12);
            this.tcScanBarcode.Name = "tcScanBarcode";
            this.tcScanBarcode.SelectedIndex = 0;
            this.tcScanBarcode.Size = new System.Drawing.Size(858, 445);
            this.tcScanBarcode.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lbresultdtgv);
            this.tabPage1.Controls.Add(this.dataGridViewResults);
            this.tabPage1.Controls.Add(this.cbCam);
            this.tabPage1.Controls.Add(this.tbResult);
            this.tabPage1.Controls.Add(this.pbDisplayCam);
            this.tabPage1.Controls.Add(this.lbTitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quét Barcode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.lbResult);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.lbCam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 413);
            this.panel1.TabIndex = 21;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(10, 132);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 24;
            this.btnImport.Text = "Nhập";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbResult.Location = new System.Drawing.Point(16, 302);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(49, 15);
            this.lbResult.TabIndex = 23;
            this.lbResult.Text = "Kết quả";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(7, 94);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Tắt";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(7, 56);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "Bật";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lbCam
            // 
            this.lbCam.AutoSize = true;
            this.lbCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbCam.Location = new System.Drawing.Point(4, 2);
            this.lbCam.Name = "lbCam";
            this.lbCam.Size = new System.Drawing.Size(81, 15);
            this.lbCam.TabIndex = 20;
            this.lbCam.Text = "Chọn camera";
            // 
            // lbresultdtgv
            // 
            this.lbresultdtgv.AutoSize = true;
            this.lbresultdtgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbresultdtgv.Location = new System.Drawing.Point(546, 83);
            this.lbresultdtgv.Name = "lbresultdtgv";
            this.lbresultdtgv.Size = new System.Drawing.Size(127, 17);
            this.lbresultdtgv.TabIndex = 20;
            this.lbresultdtgv.Text = "Danh sách kết quả";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(546, 122);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(298, 229);
            this.dataGridViewResults.TabIndex = 18;
            // 
            // cbCam
            // 
            this.cbCam.FormattingEnabled = true;
            this.cbCam.Location = new System.Drawing.Point(101, 83);
            this.cbCam.Name = "cbCam";
            this.cbCam.Size = new System.Drawing.Size(413, 21);
            this.cbCam.TabIndex = 17;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(101, 384);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(413, 20);
            this.tbResult.TabIndex = 16;
            // 
            // pbDisplayCam
            // 
            this.pbDisplayCam.Location = new System.Drawing.Point(101, 122);
            this.pbDisplayCam.Name = "pbDisplayCam";
            this.pbDisplayCam.Size = new System.Drawing.Size(413, 229);
            this.pbDisplayCam.TabIndex = 14;
            this.pbDisplayCam.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbTitle.Location = new System.Drawing.Point(332, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(182, 31);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Quét mã vạch";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pbResult);
            this.tabPage2.Controls.Add(this.tbInput);
            this.tabPage2.Controls.Add(this.lbtilte);
            this.tabPage2.Controls.Add(this.btnCreate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(850, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tạo Barcode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(729, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(161, 164);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(644, 181);
            this.pbResult.TabIndex = 3;
            this.pbResult.TabStop = false;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(161, 102);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(644, 20);
            this.tbInput.TabIndex = 2;
            // 
            // lbtilte
            // 
            this.lbtilte.AutoSize = true;
            this.lbtilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbtilte.Location = new System.Drawing.Point(344, 31);
            this.lbtilte.Name = "lbtilte";
            this.lbtilte.Size = new System.Drawing.Size(169, 31);
            this.lbtilte.TabIndex = 1;
            this.lbtilte.Text = "Tạo Barcode";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(32, 100);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 469);
            this.Controls.Add(this.tcScanBarcode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tcScanBarcode.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayCam)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcScanBarcode;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.ComboBox cbCam;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.PictureBox pbDisplayCam;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lbtilte;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbCam;
        private System.Windows.Forms.Label lbresultdtgv;
    }
}

