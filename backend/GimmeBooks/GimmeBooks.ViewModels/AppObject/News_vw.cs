using System;

namespace GimmeBooks.ViewModels.AppObjects
{
    public class News_vw : EntityBase_vw<long>
    {
        public string Section { get; set; }
        public string Subsection { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Item_type { get; set; }
        public DateTime Published_date { get; set; }
    }
}