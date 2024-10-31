namespace QuoToPO
{
    internal class PdfType
    {
        // Properties for user
        public int Pdf_type_ID { get; set; }
        public string Pdf_type_name { get; set; }

        public List<PdfType> GetList()
        {
            return new List<PdfType>()
        {
            new PdfType { Pdf_type_ID = 1, Pdf_type_name = "Native PDF" },
            new PdfType { Pdf_type_ID = 2, Pdf_type_name = "Scanned PDF" }
        };
        }
    }
}
