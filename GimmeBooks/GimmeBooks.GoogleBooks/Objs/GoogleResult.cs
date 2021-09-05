using GimmeBooks.ViewModels.AppObject;

namespace GimmeBooks.GoogleBooks
{
    public class GoogleResult
    {
        public string Kind { get; set; }
        public int TotalItems { get; set; }
        public Book_vw[] Items { get; set; }
    }
}