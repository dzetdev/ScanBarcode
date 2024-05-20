﻿namespace ScanBarcode
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
            this.tcScanBarcode = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbCam = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pbDisplayCamera = new System.Windows.Forms.PictureBox();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.lbCamera = new System.Windows.Forms.Label();
            this.btnBD = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbTimeImport = new System.Windows.Forms.Label();
            this.lbBarcode = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbTimeImport = new System.Windows.Forms.TextBox();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barcodeDataSet = new ScanBarcode.barcodeDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new ScanBarcode.barcodeDataSetTableAdapters.ProductTableAdapter();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeImportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcScanBarcode.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayCam)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayCamera)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcScanBarcode
            // 
            this.tcScanBarcode.Controls.Add(this.tabPage1);
            this.tcScanBarcode.Controls.Add(this.tabPage2);
            this.tcScanBarcode.Controls.Add(this.tabPage3);
            this.tcScanBarcode.Controls.Add(this.tabPage4);
            this.tcScanBarcode.Location = new System.Drawing.Point(12, 12);
            this.tcScanBarcode.Name = "tcScanBarcode";
            this.tcScanBarcode.SelectedIndex = 0;
            this.tcScanBarcode.Size = new System.Drawing.Size(858, 445);
            this.tcScanBarcode.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbResult);
            this.tabPage1.Controls.Add(this.lbCam);
            this.tabPage1.Controls.Add(this.btnImport);
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnStart);
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
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbResult.Location = new System.Drawing.Point(14, 389);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(49, 15);
            this.lbResult.TabIndex = 23;
            this.lbResult.Text = "Kết quả";
            // 
            // lbCam
            // 
            this.lbCam.AutoSize = true;
            this.lbCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbCam.Location = new System.Drawing.Point(14, 83);
            this.lbCam.Name = "lbCam";
            this.lbCam.Size = new System.Drawing.Size(81, 15);
            this.lbCam.TabIndex = 28;
            this.lbCam.Text = "Chọn camera";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(17, 220);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 27;
            this.btnImport.Text = "Nhập";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(17, 182);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 26;
            this.btnStop.Text = "Tắt";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(17, 144);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Bật";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lbresultdtgv
            // 
            this.lbresultdtgv.AutoSize = true;
            this.lbresultdtgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbresultdtgv.Location = new System.Drawing.Point(517, 83);
            this.lbresultdtgv.Name = "lbresultdtgv";
            this.lbresultdtgv.Size = new System.Drawing.Size(109, 15);
            this.lbresultdtgv.TabIndex = 20;
            this.lbresultdtgv.Text = "Danh sách kết quả";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(520, 122);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(324, 229);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnConfirm);
            this.tabPage3.Controls.Add(this.pbDisplayCamera);
            this.tabPage3.Controls.Add(this.cbCamera);
            this.tabPage3.Controls.Add(this.lbCamera);
            this.tabPage3.Controls.Add(this.btnBD);
            this.tabPage3.Controls.Add(this.btnInput);
            this.tabPage3.Controls.Add(this.btnOff);
            this.tabPage3.Controls.Add(this.lbPrice);
            this.tabPage3.Controls.Add(this.lbQuantity);
            this.tabPage3.Controls.Add(this.lbTimeImport);
            this.tabPage3.Controls.Add(this.lbBarcode);
            this.tabPage3.Controls.Add(this.lbName);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.tbPrice);
            this.tabPage3.Controls.Add(this.tbQuantity);
            this.tabPage3.Controls.Add(this.tbTimeImport);
            this.tabPage3.Controls.Add(this.tbBarcode);
            this.tabPage3.Controls.Add(this.tbProductName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(850, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tạo sản phẩm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(129, 365);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Lưu";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pbDisplayCamera
            // 
            this.pbDisplayCamera.Location = new System.Drawing.Point(349, 167);
            this.pbDisplayCamera.Name = "pbDisplayCamera";
            this.pbDisplayCamera.Size = new System.Drawing.Size(379, 161);
            this.pbDisplayCamera.TabIndex = 17;
            this.pbDisplayCamera.TabStop = false;
            // 
            // cbCamera
            // 
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(349, 119);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(379, 21);
            this.cbCamera.TabIndex = 16;
            // 
            // lbCamera
            // 
            this.lbCamera.AutoSize = true;
            this.lbCamera.Location = new System.Drawing.Point(753, 122);
            this.lbCamera.Name = "lbCamera";
            this.lbCamera.Size = new System.Drawing.Size(70, 13);
            this.lbCamera.TabIndex = 15;
            this.lbCamera.Text = "Chọn camera";
            // 
            // btnBD
            // 
            this.btnBD.Location = new System.Drawing.Point(753, 167);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(75, 23);
            this.btnBD.TabIndex = 14;
            this.btnBD.Text = "Mở";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(753, 256);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 13;
            this.btnInput.Text = "Nhập";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(753, 210);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOff.TabIndex = 12;
            this.btnOff.Text = "Tắt";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(37, 311);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(72, 13);
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Text = "Giá sản phẩm";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(37, 266);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(49, 13);
            this.lbQuantity.TabIndex = 10;
            this.lbQuantity.Text = "Số lượng";
            // 
            // lbTimeImport
            // 
            this.lbTimeImport.AutoSize = true;
            this.lbTimeImport.Location = new System.Drawing.Point(37, 220);
            this.lbTimeImport.Name = "lbTimeImport";
            this.lbTimeImport.Size = new System.Drawing.Size(78, 13);
            this.lbTimeImport.TabIndex = 9;
            this.lbTimeImport.Text = "Thời gian nhập";
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Location = new System.Drawing.Point(37, 173);
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(71, 13);
            this.lbBarcode.TabIndex = 8;
            this.lbBarcode.Text = "Mã sản phẩm";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(37, 125);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(75, 13);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(343, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tạo sản phẩm";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(129, 308);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(152, 20);
            this.tbPrice.TabIndex = 4;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(129, 259);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(152, 20);
            this.tbQuantity.TabIndex = 3;
            // 
            // tbTimeImport
            // 
            this.tbTimeImport.Location = new System.Drawing.Point(129, 217);
            this.tbTimeImport.Name = "tbTimeImport";
            this.tbTimeImport.Size = new System.Drawing.Size(152, 20);
            this.tbTimeImport.TabIndex = 2;
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(129, 170);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(152, 20);
            this.tbBarcode.TabIndex = 1;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(129, 122);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(152, 20);
            this.tbProductName.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(850, 419);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Danh sách sản phẩm";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.timeImportDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // barcodeDataSet
            // 
            this.barcodeDataSet.DataSetName = "barcodeDataSet";
            this.barcodeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.barcodeDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "productId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "productId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            // 
            // timeImportDataGridViewTextBoxColumn
            // 
            this.timeImportDataGridViewTextBoxColumn.DataPropertyName = "timeImport";
            this.timeImportDataGridViewTextBoxColumn.HeaderText = "timeImport";
            this.timeImportDataGridViewTextBoxColumn.Name = "timeImportDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 469);
            this.Controls.Add(this.tcScanBarcode);
            this.Name = "Form1";
            this.Text = "Barcode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcScanBarcode.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayCam)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayCamera)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lbresultdtgv;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbCam;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbTimeImport;
        private System.Windows.Forms.Label lbBarcode;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbTimeImport;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.PictureBox pbDisplayCamera;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.Label lbCamera;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private barcodeDataSet barcodeDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private barcodeDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeImportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

