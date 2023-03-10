namespace Model.Database
{
    public class BookBookFormat
    {
        public int BookId { get; set; }
        public int BookFormatId { get; set; }
        public decimal Price { get; set; }
        public int Pages { get; set; }
        public int Minutes { get; set; }
    }
}
