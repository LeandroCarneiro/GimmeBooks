using GimmeBooks.ViewModels.AppObjects;

namespace GimmeBooks.NYNews.Objs
{
    public class NYResult
    {
        public string Status { get; set; }
        public News_vw[] Results { get; set; }
    }
}
