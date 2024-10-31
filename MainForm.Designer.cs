namespace QuoToPO
{
    partial class MainForm
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
            btnBrowse = new Button();
            txtQuotationPath = new TextBox();
            lblQuotation = new Label();
            grpPreview = new GroupBox();
            lblPage = new Label();
            quotationPreviewBox = new PictureBox();
            btnNext = new Button();
            btnPrev = new Button();
            pdfType = new ComboBox();
            btnExtract = new Button();
            grpExtractedData = new GroupBox();
            JpnPO = new RadioButton();
            EngPO = new RadioButton();
            DeliveryAddressList = new ComboBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            DatePicker = new DateTimePicker();
            label1 = new Label();
            SupplierName = new TextBox();
            label2 = new Label();
            quotationNo = new TextBox();
            SupplierAddress = new TextBox();
            PaymentTerms = new TextBox();
            label6 = new Label();
            label4 = new Label();
            DeliveryAddress = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtExtractedData = new TextBox();
            grpPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quotationPreviewBox).BeginInit();
            grpExtractedData.SuspendLayout();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.ImeMode = ImeMode.NoControl;
            btnBrowse.Location = new Point(766, 27);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += BrowseBtn_Click;
            // 
            // txtQuotationPath
            // 
            txtQuotationPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuotationPath.Location = new Point(12, 27);
            txtQuotationPath.MaximumSize = new Size(750, 23);
            txtQuotationPath.Name = "txtQuotationPath";
            txtQuotationPath.ReadOnly = true;
            txtQuotationPath.Size = new Size(748, 23);
            txtQuotationPath.TabIndex = 2;
            // 
            // lblQuotation
            // 
            lblQuotation.AutoSize = true;
            lblQuotation.ImeMode = ImeMode.NoControl;
            lblQuotation.Location = new Point(12, 9);
            lblQuotation.Name = "lblQuotation";
            lblQuotation.Size = new Size(61, 15);
            lblQuotation.TabIndex = 1;
            lblQuotation.Text = "Quotation";
            // 
            // grpPreview
            // 
            grpPreview.Controls.Add(lblPage);
            grpPreview.Controls.Add(quotationPreviewBox);
            grpPreview.Controls.Add(btnNext);
            grpPreview.Controls.Add(btnPrev);
            grpPreview.Location = new Point(12, 71);
            grpPreview.Name = "grpPreview";
            grpPreview.Size = new Size(312, 480);
            grpPreview.TabIndex = 4;
            grpPreview.TabStop = false;
            grpPreview.Text = "Preview";
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.ImeMode = ImeMode.NoControl;
            lblPage.Location = new Point(120, 454);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(65, 15);
            lblPage.TabIndex = 6;
            lblPage.Text = "Page 0 of 0";
            // 
            // quotationPreviewBox
            // 
            quotationPreviewBox.BackColor = SystemColors.ControlLight;
            quotationPreviewBox.ImeMode = ImeMode.NoControl;
            quotationPreviewBox.Location = new Point(6, 19);
            quotationPreviewBox.Name = "quotationPreviewBox";
            quotationPreviewBox.Size = new Size(300, 425);
            quotationPreviewBox.TabIndex = 3;
            quotationPreviewBox.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.ImeMode = ImeMode.NoControl;
            btnNext.Location = new Point(246, 450);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(60, 23);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += NextBtn_Click;
            // 
            // btnPrev
            // 
            btnPrev.ImeMode = ImeMode.NoControl;
            btnPrev.Location = new Point(6, 450);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(60, 23);
            btnPrev.TabIndex = 5;
            btnPrev.Text = "Previous";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += PrevBtn_Click;
            // 
            // pdfType
            // 
            pdfType.DropDownStyle = ComboBoxStyle.DropDownList;
            pdfType.Location = new Point(371, 257);
            pdfType.Name = "pdfType";
            pdfType.Size = new Size(121, 23);
            pdfType.Sorted = true;
            pdfType.TabIndex = 8;
            // 
            // btnExtract
            // 
            btnExtract.ImeMode = ImeMode.NoControl;
            btnExtract.Location = new Point(396, 286);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(75, 23);
            btnExtract.TabIndex = 9;
            btnExtract.Text = "Extract";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += ExtractBtn_Click;
            // 
            // grpExtractedData
            // 
            grpExtractedData.Controls.Add(JpnPO);
            grpExtractedData.Controls.Add(EngPO);
            grpExtractedData.Controls.Add(DeliveryAddressList);
            grpExtractedData.Controls.Add(comboBox1);
            grpExtractedData.Controls.Add(label7);
            grpExtractedData.Controls.Add(DatePicker);
            grpExtractedData.Controls.Add(label1);
            grpExtractedData.Controls.Add(SupplierName);
            grpExtractedData.Controls.Add(label2);
            grpExtractedData.Controls.Add(quotationNo);
            grpExtractedData.Controls.Add(SupplierAddress);
            grpExtractedData.Controls.Add(PaymentTerms);
            grpExtractedData.Controls.Add(label6);
            grpExtractedData.Controls.Add(label4);
            grpExtractedData.Controls.Add(DeliveryAddress);
            grpExtractedData.Controls.Add(label5);
            grpExtractedData.Controls.Add(label3);
            grpExtractedData.Location = new Point(525, 71);
            grpExtractedData.Name = "grpExtractedData";
            grpExtractedData.Size = new Size(450, 480);
            grpExtractedData.TabIndex = 10;
            grpExtractedData.TabStop = false;
            grpExtractedData.Text = "Data";
            // 
            // JpnPO
            // 
            JpnPO.AutoSize = true;
            JpnPO.Location = new Point(87, 19);
            JpnPO.Name = "JpnPO";
            JpnPO.Size = new Size(64, 19);
            JpnPO.TabIndex = 50;
            JpnPO.Text = "日本語";
            JpnPO.UseVisualStyleBackColor = true;
            JpnPO.CheckedChanged += JpnPO_CheckedChanged;
            // 
            // EngPO
            // 
            EngPO.AutoSize = true;
            EngPO.Checked = true;
            EngPO.Location = new Point(18, 19);
            EngPO.Name = "EngPO";
            EngPO.Size = new Size(63, 19);
            EngPO.TabIndex = 49;
            EngPO.TabStop = true;
            EngPO.Text = "English";
            EngPO.UseVisualStyleBackColor = true;
            EngPO.CheckedChanged += EngPO_CheckedChanged;
            // 
            // DeliveryAddressList
            // 
            DeliveryAddressList.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryAddressList.FormattingEnabled = true;
            DeliveryAddressList.Location = new Point(18, 301);
            DeliveryAddressList.Name = "DeliveryAddressList";
            DeliveryAddressList.Size = new Size(199, 23);
            DeliveryAddressList.TabIndex = 48;
            DeliveryAddressList.SelectedIndexChanged += DeliveryAddressList_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(231, 251);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(18, 103);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 44;
            label7.Text = "Supplier";
            // 
            // DatePicker
            // 
            DatePicker.CustomFormat = "MMMMdd, yyyy";
            DatePicker.Format = DateTimePickerFormat.Custom;
            DatePicker.Location = new Point(18, 70);
            DatePicker.Margin = new Padding(3, 3, 10, 10);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(200, 23);
            DatePicker.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(18, 52);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 33;
            label1.Text = "Create date";
            // 
            // SupplierName
            // 
            SupplierName.BorderStyle = BorderStyle.FixedSingle;
            SupplierName.Location = new Point(18, 121);
            SupplierName.Margin = new Padding(3, 3, 3, 10);
            SupplierName.Name = "SupplierName";
            SupplierName.Size = new Size(200, 23);
            SupplierName.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(231, 103);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 34;
            label2.Text = "Quotation no.";
            // 
            // quotationNo
            // 
            quotationNo.BorderStyle = BorderStyle.FixedSingle;
            quotationNo.Location = new Point(231, 121);
            quotationNo.Margin = new Padding(3, 3, 3, 10);
            quotationNo.Name = "quotationNo";
            quotationNo.Size = new Size(200, 23);
            quotationNo.TabIndex = 35;
            // 
            // SupplierAddress
            // 
            SupplierAddress.BorderStyle = BorderStyle.FixedSingle;
            SupplierAddress.Location = new Point(18, 172);
            SupplierAddress.Margin = new Padding(3, 3, 3, 10);
            SupplierAddress.Multiline = true;
            SupplierAddress.Name = "SupplierAddress";
            SupplierAddress.Size = new Size(413, 50);
            SupplierAddress.TabIndex = 43;
            // 
            // PaymentTerms
            // 
            PaymentTerms.BorderStyle = BorderStyle.FixedSingle;
            PaymentTerms.Location = new Point(17, 250);
            PaymentTerms.Margin = new Padding(3, 3, 3, 10);
            PaymentTerms.Name = "PaymentTerms";
            PaymentTerms.Size = new Size(200, 23);
            PaymentTerms.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(17, 154);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 42;
            label6.Text = "Supplier address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(17, 283);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 41;
            label4.Text = "Delivery address";
            // 
            // DeliveryAddress
            // 
            DeliveryAddress.BorderStyle = BorderStyle.FixedSingle;
            DeliveryAddress.Location = new Point(18, 330);
            DeliveryAddress.Multiline = true;
            DeliveryAddress.Name = "DeliveryAddress";
            DeliveryAddress.Size = new Size(413, 50);
            DeliveryAddress.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(231, 232);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 40;
            label5.Text = "Delivery terms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(18, 232);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 39;
            label3.Text = "Payment terms";
            // 
            // txtExtractedData
            // 
            txtExtractedData.Location = new Point(531, 557);
            txtExtractedData.Multiline = true;
            txtExtractedData.Name = "txtExtractedData";
            txtExtractedData.ScrollBars = ScrollBars.Vertical;
            txtExtractedData.Size = new Size(444, 451);
            txtExtractedData.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 1023);
            Controls.Add(txtExtractedData);
            Controls.Add(grpExtractedData);
            Controls.Add(btnBrowse);
            Controls.Add(txtQuotationPath);
            Controls.Add(lblQuotation);
            Controls.Add(grpPreview);
            Controls.Add(pdfType);
            Controls.Add(btnExtract);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuoToPO";
            grpPreview.ResumeLayout(false);
            grpPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quotationPreviewBox).EndInit();
            grpExtractedData.ResumeLayout(false);
            grpExtractedData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private TextBox txtQuotationPath;
        private Label lblQuotation;
        private GroupBox grpPreview;
        private Label lblPage;
        private PictureBox quotationPreviewBox;
        private Button btnNext;
        private Button btnPrev;
        private ComboBox pdfType;
        private Button btnExtract;
        private GroupBox grpExtractedData;
        private TextBox txtExtractedData;
        private DateTimePicker DatePicker;
        private TextBox SupplierName;
        private Label label7;
        private TextBox SupplierAddress;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label3;
        private TextBox DeliveryAddress;
        private TextBox PaymentTerms;
        private TextBox quotationNo;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox DeliveryAddressList;
        private RadioButton JpnPO;
        private RadioButton EngPO;
    }
}