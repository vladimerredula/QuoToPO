namespace QuoToPO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            quoatationLbl = new Label();
            browseBtn = new Button();
            quotationFileDialog = new OpenFileDialog();
            quotationPathTxt = new TextBox();
            quotationPreviewBox = new PictureBox();
            prevBtn = new Button();
            pageLbl = new Label();
            nextBtn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            extractBtn = new Button();
            pdfType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)quotationPreviewBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // quoatationLbl
            // 
            resources.ApplyResources(quoatationLbl, "quoatationLbl");
            quoatationLbl.Name = "quoatationLbl";
            // 
            // browseBtn
            // 
            resources.ApplyResources(browseBtn, "browseBtn");
            browseBtn.Name = "browseBtn";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // quotationFileDialog
            // 
            quotationFileDialog.FileName = "openFileDialog1";
            // 
            // quotationPathTxt
            // 
            resources.ApplyResources(quotationPathTxt, "quotationPathTxt");
            quotationPathTxt.Name = "quotationPathTxt";
            quotationPathTxt.ReadOnly = true;
            // 
            // quotationPreviewBox
            // 
            quotationPreviewBox.BackColor = SystemColors.ControlLight;
            resources.ApplyResources(quotationPreviewBox, "quotationPreviewBox");
            quotationPreviewBox.Name = "quotationPreviewBox";
            quotationPreviewBox.TabStop = false;
            // 
            // prevBtn
            // 
            resources.ApplyResources(prevBtn, "prevBtn");
            prevBtn.Name = "prevBtn";
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click;
            // 
            // pageLbl
            // 
            resources.ApplyResources(pageLbl, "pageLbl");
            pageLbl.Name = "pageLbl";
            // 
            // nextBtn
            // 
            resources.ApplyResources(nextBtn, "nextBtn");
            nextBtn.Name = "nextBtn";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(quotationPreviewBox);
            groupBox1.Controls.Add(nextBtn);
            groupBox1.Controls.Add(prevBtn);
            groupBox1.Controls.Add(pageLbl);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // extractBtn
            // 
            resources.ApplyResources(extractBtn, "extractBtn");
            extractBtn.Name = "extractBtn";
            extractBtn.UseVisualStyleBackColor = true;
            extractBtn.Click += extractBtn_Click;
            // 
            // pdfType
            // 
            pdfType.DropDownStyle = ComboBoxStyle.DropDownList;
            pdfType.FormattingEnabled = true;
            pdfType.Items.AddRange(new object[] { resources.GetString("pdfType.Items"), resources.GetString("pdfType.Items1") });
            resources.ApplyResources(pdfType, "pdfType");
            pdfType.Name = "pdfType";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pdfType);
            Controls.Add(extractBtn);
            Controls.Add(groupBox2);
            Controls.Add(browseBtn);
            Controls.Add(quotationPathTxt);
            Controls.Add(quoatationLbl);
            Controls.Add(groupBox1);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)quotationPreviewBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label quoatationLbl;
        private Button browseBtn;
        private OpenFileDialog quotationFileDialog;
        private TextBox quotationPathTxt;
        private PictureBox quotationPreviewBox;
        private Button prevBtn;
        private Label pageLbl;
        private Button nextBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button extractBtn;
        private ComboBox pdfType;
        private TextBox textBox1;
    }
}
