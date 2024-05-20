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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbCam = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pbDisplayCam = new System.Windows.Forms.PictureBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.cbCam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayCam)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbTitle.Location = new System.Drawing.Point(336, 29);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(182, 31);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Quét mã vạch";
            // 
            // lbCam
            // 
            this.lbCam.AutoSize = true;
            this.lbCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCam.Location = new System.Drawing.Point(89, 96);
            this.lbCam.Name = "lbCam";
            this.lbCam.Size = new System.Drawing.Size(92, 17);
            this.lbCam.TabIndex = 1;
            this.lbCam.Text = "Chọn camera";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(92, 210);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Bật";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(92, 263);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Tắt";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pbDisplayCam
            // 
            this.pbDisplayCam.Location = new System.Drawing.Point(234, 163);
            this.pbDisplayCam.Name = "pbDisplayCam";
            this.pbDisplayCam.Size = new System.Drawing.Size(413, 207);
            this.pbDisplayCam.TabIndex = 5;
            this.pbDisplayCam.TabStop = false;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbResult.Location = new System.Drawing.Point(89, 398);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(57, 17);
            this.lbResult.TabIndex = 6;
            this.lbResult.Text = "Kết quả";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(234, 398);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(413, 20);
            this.tbResult.TabIndex = 7;
            // 
            // cbCam
            // 
            this.cbCam.FormattingEnabled = true;
            this.cbCam.Location = new System.Drawing.Point(234, 96);
            this.cbCam.Name = "cbCam";
            this.cbCam.Size = new System.Drawing.Size(413, 21);
            this.cbCam.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCam);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.pbDisplayCam);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbCam);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbCam;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pbDisplayCam;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.ComboBox cbCam;
    }
}

