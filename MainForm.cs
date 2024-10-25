using PdfiumViewer;
using System.Data;

namespace QuoToPO
{
    public partial class MainForm : Form
    {
        private DatabaseHelper _db;
        private PdfDocument pdfDocument;
        private int currentPage = 0;
        private int totalPages = 0;

        public MainForm()
        {
            InitializeComponent();

            // Initialize DatabaseHelper
            _db = new DatabaseHelper();
        }

        private void browseBtn_Click(object sender, EventArgs e)
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
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages - 1)
            {
                currentPage++;
                LoadPdfPage(currentPage);
                lblPage.Text = $"Page {currentPage + 1} of {totalPages}";
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadPdfPage(currentPage);
                lblPage.Text = $"Page {currentPage + 1} of {totalPages}";
            }
        }

        private void extractBtn_Click(object sender, EventArgs e)
        {
            // Get the selected value
            var selectedValue = pdfType?.SelectedItem?.ToString() ?? "Native PDF";
            var extractedText = "";

            if (selectedValue == "Native PDF")
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
                    var image = pdfDocument.Render(i, 600, 600, true);

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
            var query = "SELECT * FROM suppliers";

            var results = _db.ExecuteQuery(query);

            // Displaying results
            foreach (DataRow row in results.Rows)
            {
                var supplier = row["Supplier_contact_person"];
            }
            MessageBox.Show(results.Rows.Count.ToString());
        }
    }
}
