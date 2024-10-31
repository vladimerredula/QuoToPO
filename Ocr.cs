using Tesseract;

namespace QuoToPO
{
    public class Ocr
    {
        public Ocr() { }

        public string PerformOcr(Bitmap image)
        {
            try
            {
                // Set up the Tesseract OCR engine
                string tessDataPath = @"./tessdata"; // Path to the tessdata folder containing .traineddata
                using (var engine = new TesseractEngine(tessDataPath, "eng+jpn", EngineMode.Default))
                {
                    // rescale image 4x biffer for better recognition
                    var processedImg = RescaleImage(image, 7.0f);

                    // process to grayscale and binarize image
                    //processedImg = PreprocessImage(processedImg);

                    engine.SetVariable("textord_min_linesize", "0.8");  // Handle small text better
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
        private Pix BitmapToPix(Bitmap image)
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
        public Bitmap PreprocessImage(Bitmap originalImage, int threshold = 128)
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
        private Bitmap RescaleImage(Bitmap image, float scaleFactor)
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
