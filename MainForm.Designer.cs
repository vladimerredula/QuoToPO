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
            browseBtn = new Button();
            quotationPathTxt = new TextBox();
            quoatationLbl = new Label();
            groupBox1 = new GroupBox();
            pageLbl = new Label();
            quotationPreviewBox = new PictureBox();
            nextBtn = new Button();
            prevBtn = new Button();
            pdfType = new ComboBox();
            extractBtn = new Button();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quotationPreviewBox).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // browseBtn
            // 
            browseBtn.ImeMode = ImeMode.NoControl;
            browseBtn.Location = new Point(766, 27);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(75, 23);
            browseBtn.TabIndex = 3;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // quotationPathTxt
            // 
            quotationPathTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            quotationPathTxt.Location = new Point(12, 27);
            quotationPathTxt.MaximumSize = new Size(750, 23);
            quotationPathTxt.Name = "quotationPathTxt";
            quotationPathTxt.ReadOnly = true;
            quotationPathTxt.Size = new Size(748, 23);
            quotationPathTxt.TabIndex = 2;
            // 
            // quoatationLbl
            // 
            quoatationLbl.AutoSize = true;
            quoatationLbl.ImeMode = ImeMode.NoControl;
            quoatationLbl.Location = new Point(12, 9);
            quoatationLbl.Name = "quoatationLbl";
            quoatationLbl.Size = new Size(61, 15);
            quoatationLbl.TabIndex = 1;
            quoatationLbl.Text = "Quotation";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pageLbl);
            groupBox1.Controls.Add(quotationPreviewBox);
            groupBox1.Controls.Add(nextBtn);
            groupBox1.Controls.Add(prevBtn);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 480);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Preview";
            // 
            // pageLbl
            // 
            pageLbl.AutoSize = true;
            pageLbl.ImeMode = ImeMode.NoControl;
            pageLbl.Location = new Point(120, 454);
            pageLbl.Name = "pageLbl";
            pageLbl.Size = new Size(65, 15);
            pageLbl.TabIndex = 6;
            pageLbl.Text = "Page 0 of 0";
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
            // nextBtn
            // 
            nextBtn.ImeMode = ImeMode.NoControl;
            nextBtn.Location = new Point(246, 450);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(60, 23);
            nextBtn.TabIndex = 7;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.ImeMode = ImeMode.NoControl;
            prevBtn.Location = new Point(6, 450);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(60, 23);
            prevBtn.TabIndex = 5;
            prevBtn.Text = "Previous";
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click;
            // 
            // pdfType
            // 
            pdfType.DropDownStyle = ComboBoxStyle.DropDownList;
            pdfType.FormattingEnabled = true;
            pdfType.Items.AddRange(new object[] { "Native PDF", "Scanned PDF" });
            pdfType.Location = new Point(371, 257);
            pdfType.Name = "pdfType";
            pdfType.Size = new Size(121, 23);
            pdfType.TabIndex = 8;
            // 
            // extractBtn
            // 
            extractBtn.ImeMode = ImeMode.NoControl;
            extractBtn.Location = new Point(396, 286);
            extractBtn.Name = "extractBtn";
            extractBtn.Size = new Size(75, 23);
            extractBtn.TabIndex = 9;
            extractBtn.Text = "Extract";
            extractBtn.UseVisualStyleBackColor = true;
            extractBtn.Click += extractBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(525, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(493, 480);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Extracted Data";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(481, 451);
            textBox1.TabIndex = 11;
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
            Controls.Add(groupBox2);
            Controls.Add(browseBtn);
            Controls.Add(quotationPathTxt);
            Controls.Add(quoatationLbl);
            Controls.Add(groupBox1);
            Controls.Add(pdfType);
            Controls.Add(extractBtn);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuoToPO";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quotationPreviewBox).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button browseBtn;
        private TextBox quotationPathTxt;
        private Label quoatationLbl;
        private GroupBox groupBox1;
        private Label pageLbl;
        private PictureBox quotationPreviewBox;
        private Button nextBtn;
        private Button prevBtn;
        private ComboBox pdfType;
        private Button extractBtn;
        private GroupBox groupBox2;
        private TextBox textBox1;
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