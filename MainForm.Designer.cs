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
            txtExtractedData = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            supplierName = new TextBox();
            label7 = new Label();
            supplierAddress = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            deliveryAddress = new TextBox();
            deliveryTerms = new TextBox();
            paymentTerms = new TextBox();
            quotationNo = new TextBox();
            label2 = new Label();
            label1 = new Label();
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
            btnBrowse.Click += browseBtn_Click;
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
            btnNext.Click += nextBtn_Click;
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
            btnPrev.Click += prevBtn_Click;
            // 
            // pdfType
            // 
            pdfType.DisplayMember = "(none)";
            pdfType.DropDownStyle = ComboBoxStyle.DropDownList;
            pdfType.FormattingEnabled = true;
            pdfType.Items.AddRange(new object[] { "Native PDF", "Scanned PDF" });
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
            btnExtract.Click += extractBtn_Click;
            // 
            // grpExtractedData
            // 
            grpExtractedData.Controls.Add(txtExtractedData);
            grpExtractedData.Location = new Point(525, 71);
            grpExtractedData.Name = "grpExtractedData";
            grpExtractedData.Size = new Size(493, 480);
            grpExtractedData.TabIndex = 10;
            grpExtractedData.TabStop = false;
            grpExtractedData.Text = "Extracted Data";
            // 
            // txtExtractedData
            // 
            txtExtractedData.Location = new Point(6, 22);
            txtExtractedData.Multiline = true;
            txtExtractedData.Name = "txtExtractedData";
            txtExtractedData.Size = new Size(481, 451);
            txtExtractedData.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 699);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 46;
            // 
            // supplierName
            // 
            supplierName.Location = new Point(116, 641);
            supplierName.Name = "supplierName";
            supplierName.Size = new Size(299, 23);
            supplierName.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(18, 644);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 44;
            label7.Text = "Supplier";
            // 
            // supplierAddress
            // 
            supplierAddress.Location = new Point(116, 670);
            supplierAddress.Name = "supplierAddress";
            supplierAddress.Size = new Size(299, 23);
            supplierAddress.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(18, 673);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 42;
            label6.Text = "Supplier address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(18, 818);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 41;
            label4.Text = "Delivery address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(18, 789);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 40;
            label5.Text = "Delivery terms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(18, 760);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 39;
            label3.Text = "Payment terms";
            // 
            // deliveryAddress
            // 
            deliveryAddress.Location = new Point(116, 815);
            deliveryAddress.Name = "deliveryAddress";
            deliveryAddress.Size = new Size(299, 23);
            deliveryAddress.TabIndex = 38;
            // 
            // deliveryTerms
            // 
            deliveryTerms.Location = new Point(116, 786);
            deliveryTerms.Name = "deliveryTerms";
            deliveryTerms.Size = new Size(299, 23);
            deliveryTerms.TabIndex = 37;
            // 
            // paymentTerms
            // 
            paymentTerms.Location = new Point(116, 757);
            paymentTerms.Name = "paymentTerms";
            paymentTerms.Size = new Size(299, 23);
            paymentTerms.TabIndex = 36;
            // 
            // quotationNo
            // 
            quotationNo.Location = new Point(116, 728);
            quotationNo.Name = "quotationNo";
            quotationNo.Size = new Size(299, 23);
            quotationNo.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(18, 731);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 34;
            label2.Text = "Quotation no.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(18, 702);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 33;
            label1.Text = "Create date";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 1023);
            Controls.Add(dateTimePicker1);
            Controls.Add(supplierName);
            Controls.Add(label7);
            Controls.Add(supplierAddress);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(deliveryAddress);
            Controls.Add(deliveryTerms);
            Controls.Add(paymentTerms);
            Controls.Add(quotationNo);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private DateTimePicker dateTimePicker1;
        private TextBox supplierName;
        private Label label7;
        private TextBox supplierAddress;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label3;
        private TextBox deliveryAddress;
        private TextBox deliveryTerms;
        private TextBox paymentTerms;
        private TextBox quotationNo;
        private Label label2;
        private Label label1;
    }
}