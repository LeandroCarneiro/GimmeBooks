using System;

namespace GimmeBooks.Domain.Entities
{
    public class NewsAnalitics : EntityBase<long>
    {
        public string NewsTitle { get; set; }
        public int RelatedTweetsCount { get; set; }
        public int RelatedBooksCount { get; set; }
        public DateTime Date { get; set; }
    }
}
