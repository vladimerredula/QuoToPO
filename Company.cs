namespace QuoToPO
{
    public class Company
    {
        // Private constructor to prevent instantiation from outside
        public Company() { }

        // Singleton instance
        private static Company _instance;

        // Public property to access the singleton instance
        public static Company Data => _instance ??= new Company();

        // Properties for company
        public int Company_ID { get; set; }
        public string Company_name { get; set; } = string.Empty;
        public string Company_name_jpn { get; set; } = string.Empty;
        public string Company_address { get; set; } = string.Empty;
        public string Company_address_jpn { get; set; } = string.Empty;
        public string Postal_code { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;
        public string Key_words { get; set; } = string.Empty;
        public string Lang { get; set; } = "en";

        public string GetCompanyName()
        {
            return this.Lang == "en"
                ? this.Company_name : this.Company_name_jpn;
        }

        public string GetCompanyAddress()
        {
            return this.Lang == "en" 
                ? this.Company_address.Replace("\\n", Environment.NewLine) 
                : $"〒{this.Postal_code}\r\n{this.Company_address_jpn}";
        }

        public void Reset()
        {
            this.Company_name = string.Empty;
            this.Company_address = string.Empty;
            this.Company_name_jpn = string.Empty;
            this.Company_address_jpn = string.Empty;
            this.Postal_code = string.Empty;
            this.Telephone = string.Empty;
            this.Fax = string.Empty;
            this.Key_words = string.Empty;
            this.Lang = "en";
        }
    }
}
