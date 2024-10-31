using PdfiumViewer;
using System.Globalization;
using System.Text.RegularExpressions;

namespace QuoToPO
{
    public partial class MainForm : Form
    {
        private Company _company;
        private DatabaseHelper _db;
        private PdfDocument pdfDocument;
        private int currentPage = 0;
        private int totalPages = 0;

        public MainForm()
        {
            InitializeComponent();

            // Initialize DatabaseHelper
            _db = new DatabaseHelper();
            _company = new Company();

            DeliveryAddressList.DataSource = _db.GetFFJCompanyList();
            DeliveryAddressList.DisplayMember = "Key_words";
            DeliveryAddressList.ValueMember = "Company_ID";
            pdfType.DataSource = new PdfType().GetList();
            pdfType.DisplayMember = "Pdf_type_name";
            pdfType.ValueMember = "Pdf_type_ID";
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog quotationFileDialog = new OpenFileDialog())
            {
                quotationFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                quotationFileDialog.Title = "Select a Quotation PDF";

                if (quotationFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtQuotationPath.Text = quotationFileDialog.FileName;

                    pdfDocument = PdfDocument.Load(quotationFileDialog.FileName);

                    // Get the total number of pages in the PDF
                    totalPages = pdfDocument.PageCount;

                    // Display the first page
                    currentPage = 0;
                    LoadPdfPage(currentPage);

                    // Update the page number label
                    lblPage.Text = $"Page {currentPage + 1} of {totalPages}";

                    // Enable navigation buttons
                    btnNext.Enabled = true;
                    btnPrev.Enabled = true;

                    // Reset company instance
                    _company = new Company();

                    // Reset text boxes
                    DatePicker.Value = DateTime.Now;
                    SupplierName.Text = string.Empty;
                    SupplierAddress.Text = string.Empty;
                    quotationNo.Text = string.Empty;
                }
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages - 1)
            {
                currentPage++;
                LoadPdfPage(currentPage);
                lblPage.Text = $"Page {currentPage + 1} of {totalPages}";
            }
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadPdfPage(currentPage);
                lblPage.Text = $"Page {currentPage + 1} of {totalPages}";
            }
        }

        private void ExtractBtn_Click(object sender, EventArgs e)
        {
            // Get the selected value
            var dropdown = pdfType.SelectedItem as PdfType;
            var extractedText = "";

            if (dropdown.Pdf_type_ID == 1)
            {
                for (int i = 0; i < totalPages; i++)
                {
                    // Extract text from each page
                    string pageText = pdfDocument.GetPdfText(i);

                    extractedText += pageText;
                }
            }
            else
            {
                for (int i = 0; i < totalPages; i++)
                {
                    // Render the current page as a bitmap
                    var image = pdfDocument.Render(i, 1200, 1200, true);

                    // Perform OCR on the rendered page
                    var ocr = new Ocr();
                    string pageText = ocr.PerformOcr((Bitmap)image);

                    extractedText += pageText;
                }
            }

            txtExtractedData.Text = extractedText;
            AnalyzeText(extractedText);
        }

        private void LoadPdfPage(int pageNumber)
        {
            try
            {
                var image = pdfDocument.Render(pageNumber, quotationPreviewBox.Width, quotationPreviewBox.Height, 96, 96, true);
                quotationPreviewBox.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading PDF page: {ex.Message}");
            }
        }

        private void AnalyzeText(string extractedText)
        {
            if (IdentifySupplier(extractedText))
            {
                // check if English radio botton is checked
                _company.Lang = EngPO.Checked ? "en" : "jp";

                // set the supplier name and addressaw 
                SupplierName.Text = _company.GetCompanyName();
                SupplierAddress.Text = _company.GetCompanyAddress();

                DatePicker.CustomFormat = EngPO.Checked ? "MMMM dd, yyyy" : "yyyy年 MM月 dd日";
                DatePicker.Format = DateTimePickerFormat.Custom;

                var extractedDate = ExtractDate(extractedText);
                if (TryParseMultipleFormats(extractedDate, out DateOnly date))
                {
                    DatePicker.Value = date.ToDateTime(TimeOnly.MinValue);
                }
            }
        }

        private bool IdentifySupplier(string extractedText)
        {
            var companies = _db.GetSupplierCompanyList();

            foreach (var company in companies)
            {
                var keywords = company.Key_words.Split(",");

                foreach (var keyword in keywords)
                {
                    if (extractedText.Contains(keyword))
                    {
                        _company = company;
                    }
                }
            }

            return _company != null;
        }

        private string ExtractDate(string extractedText)
        {
            // Regex pattern to find dates in yyyy.MM.dd format
            string pattern = @"(?<jpnFormat1>\b\d{4}年\d{1,2}月\d{1,2}日\b)"
                    + @"|(?<jpnFormat2>(\d{4})年\s*(\d{1,2})月\s*(\d{1,2})日)"
                    + @"|(?<jpnFormat2>(\d{4})\s*年\s*(\d{1,2})\s*月\s*(\d{1,2})\s*日)"
                    + @"|(?<jpnFormat3>令和(?<year>\d{2})年(?<month>\d{2})月(?<day>\d{2})日)"
                    + @"|(?<jpnFormat4>令\s*和\s*(?<year>\d{1,2})\s*年\s*(?<month>\d{1,2})\s*月\s*(?<day>\d{1,2}))"
                    + @"|(?<dotSeparated>\b\d{4}\.\d{1,2}\.\d{1,2}\b)"
                    + @"|(?<slashSeparated>\b\d{1,2}/\d{1,2}/\d{2,4}\b)"
                    + @"|(?<dashSeparated>\b\d{4}-\d{1,2}-\d{1,2}\b)"
                    + @"|(?<engFormat1>\b(January|February|March|April|May|June|July|August|September|October|November|December) \d{1,2}, \d{4}\b)"
                    + @"|(?<engFormat2>\b\d{1,2} (January|February|March|April|May|June|July|August|September|October|November|December) \d{4}\b)"
                    + @"|(?<engFormat3>\b\d{1,2}(Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec) \d{4}\b)";

            // Match the pattern in the extracted text
            MatchCollection matches = Regex.Matches(extractedText, pattern);

            // Add each matched date to the list
            foreach (Match match in matches)
            {
                if (match.Groups["jpnFormat3"].Success || match.Groups["jpnFormat4"].Success)
                {
                    // Extract Reiwa year, month, and day
                    int reiwaYear = int.Parse(match.Groups["year"].Value);
                    int month = int.Parse(match.Groups["month"].Value);
                    int day = int.Parse(match.Groups["day"].Value);

                    // Convert Reiwa year to Gregorian year
                    int gregorianYear = 2018 + reiwaYear; // Reiwa era started in 2019

                    return $"{gregorianYear}-{month:D2}-{day:D2}";
                }

                if (match.Groups["jpnFormat1"].Success || match.Groups["jpnFormat2"].Success)
                {
                    return match.Value;
                }
            }

            if (matches.Count() > 0)
            {
                return matches[0].Value;
            }

            return "";
        }

        private bool TryParseMultipleFormats(string dateString, out DateOnly date)
        {
            date = default;

            // First, try parsing common formats automatically
            if (DateTime.TryParse(dateString, out DateTime autoParsedDate))
            {
                date = DateOnly.FromDateTime(autoParsedDate);
                return true;
            }

            // List of possible date formats
            string[] formats = new[]
            {
                "yyyy年M月d日",     // 2024年7月10日
                "yyyy年 MM月 dd日", // 2024年 07月 10日
                "yyyy-MM-dd",      // 2024-07-10
                "yyyy-M-dd",       // 2024-7-10
                "yyyy/MM/dd",      // 2024/07/10
                "yyyy/M/dd",       // 2024/7/10
                "MM/dd/yyyy",      // 07/10/2024
                "M/dd/yyyy",       // 7/10/2024
                "dd/MM/yyyy",      // 10/07/2024
                "dd/M/yyyy",       // 10/7/2024
                "yyyy.MM.dd",      // 2024/07/10
                "yyyy.M.dd",       // 2024/7/10
                "MMMM dd, yyyy",   // July 10, 2024
                "MMMM d, yyyy",    // July 1, 2024
                "dd MMMM yyyy",    // 10 July 2024
                "d MMMM yyyy"      // 1 July 2024
            };

            // Try to parse the date string using each format
            foreach (string format in formats)
            {
                if (DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
                {
                    date = DateOnly.FromDateTime(dateTime);
                    return true;
                }
            }

            return false; // Return false if no format matches
        }

        private void DeliveryAddressList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (DeliveryAddressList.SelectedIndex != -1)
            {
                // Get the selected company
                Company selectedCompany = DeliveryAddressList?.SelectedItem as Company;

                if (EngPO.Checked)
                {
                    DeliveryAddress.Text = selectedCompany?.Company_address.Replace("\\n", Environment.NewLine);
                } else
                {
                    DeliveryAddress.Text = $"〒{selectedCompany?.Postal_code}\r\n{selectedCompany?.Company_address_jpn}";
                }
            }
        }

        private void EngPO_CheckedChanged(object sender, EventArgs e)
        {
            if (EngPO.Checked)
            {
                _company.Lang = "en";
                SupplierName.Text = _company.GetCompanyName();
                SupplierAddress.Text = _company.GetCompanyAddress();
                DatePicker.CustomFormat = "MMMMdd, yyyy";

                // Get the selected company
                Company selectedCompany = DeliveryAddressList?.SelectedItem as Company;
                DeliveryAddress.Text = selectedCompany?.Company_address.Replace("\\n", Environment.NewLine);
            }
        }

        private void JpnPO_CheckedChanged(object sender, EventArgs e)
        {
            if (JpnPO.Checked)
            {
                _company.Lang = "jp";
                SupplierName.Text = _company.GetCompanyName();
                SupplierAddress.Text = _company.GetCompanyAddress();
                DatePicker.CustomFormat = "yyyy年 MM月 dd日";

                // Get the selected company
                Company selectedCompany = DeliveryAddressList?.SelectedItem as Company;
                DeliveryAddress.Text = $"〒{selectedCompany.Postal_code}\r\n{selectedCompany?.Company_address_jpn}";
            }
        }
    }
}
