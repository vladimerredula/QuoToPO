using PdfiumViewer;
using Tesseract;

namespace QuoToPO
{
    public partial class MainForm : Form
    {
        private PdfDocument pdfDocument;
        private int currentPage = 0;
        private int totalPages = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog quotationFileDialog = new OpenFileDialog())
            {
                quotationFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                quotationFileDialog.Title = "Select a Quotation PDF";

                if (quotationFileDialog.ShowDialog() == DialogResult.OK)
                {
                    quotationPathTxt.Text = quotationFileDialog.FileName;

                    pdfDocument = PdfDocument.Load(quotationFileDialog.FileName);

                    // Get the total number of pages in the PDF
                    totalPages = pdfDocument.PageCount;

                    // Display the first page
                    currentPage = 0;
                    LoadPdfPage(currentPage);

                    // Update the page number label
                    pageLbl.Text = $"Page {currentPage + 1} of {totalPages}";

                    // Enable navigation buttons
                    nextBtn.Enabled = true;
                    prevBtn.Enabled = true;
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages - 1)
            {
                currentPage++;
                LoadPdfPage(currentPage);
                pageLbl.Text = $"Page {currentPage + 1} of {totalPages}";
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                LoadPdfPage(currentPage);
                pageLbl.Text = $"Page {currentPage + 1} of {totalPages}";
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

                    // rescale image 4x biffer for better recognition
                    var reziedImage = RescaleImage((Bitmap)image, 4.0f);

                    // Perform OCR on the rendered page
                    string pageText = PerformOcr(reziedImage);

                    extractedText += pageText;
                }
            }

            textBox1.Text = extractedText;
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

        private static string PerformOcr(Bitmap image)
        {
            try
            {
                // Set up the Tesseract OCR engine
                string tessDataPath = @"./tessdata"; // Path to the tessdata folder containing .traineddata
                using (var engine = new TesseractEngine(tessDataPath, "eng+jpn", EngineMode.Default))
                {
                    var processedImg = PreprocessImage(image);

                    engine.SetVariable("textord_min_linesize", "1.5");  // Handle small text better
                    //engine.SetVariable("tessedit_char_whitelist", "0123456789abcdefghijklmnopqrstuvwxyz");

                    using (var pixImage = BitmapToPix(processedImg))
                    {
                        using (var page = engine.Process(pixImage, PageSegMode.Auto))
                        {
                            return page.GetText();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error performing OCR: {ex.Message}");
                return "";
            }
        }

        // Helper method to convert Bitmap to Pix for Tesseract
        private static Pix BitmapToPix(Bitmap image)
        {
            // Create a MemoryStream to save the bitmap image as a byte array
            using (var stream = new System.IO.MemoryStream())
            {
                // Save the bitmap as PNG format (Tesseract works well with PNG format)
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                // Reset the stream position to the beginning
                stream.Position = 0;

                // Use Tesseract's Pix.LoadFromMemory to convert the image
                return Pix.LoadFromMemory(stream.ToArray());
            }
        }

        // Helper method to grayscale and binarize image
        public static Bitmap PreprocessImage(Bitmap originalImage, int threshold = 128)
        {
            Bitmap grayscaleImage = new Bitmap(originalImage.Width, originalImage.Height);
            Bitmap binarizedImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Convert the image to Grayscale
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    // Get the pixel color
                    Color pixelColor = originalImage.GetPixel(x, y);

                    // Convert to Grayscale (average of RGB values)
                    int grayValue = (int)((pixelColor.R * 0.3) + (pixelColor.G * 0.59) + (pixelColor.B * 0.11));
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);

                    grayscaleImage.SetPixel(x, y, grayColor);

                    // Apply Threshold (Binarization)
                    if (grayValue > threshold)
                    {
                        binarizedImage.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        binarizedImage.SetPixel(x, y, Color.Black);
                    }
                }
            }

            // Return the binarized image
            return binarizedImage;
        }

        // Helper method to rescale image
        public Bitmap RescaleImage(Bitmap image, float scaleFactor)
        {
            int newWidth = (int)(image.Width * scaleFactor);
            int newHeight = (int)(image.Height * scaleFactor);
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }
    }
}
