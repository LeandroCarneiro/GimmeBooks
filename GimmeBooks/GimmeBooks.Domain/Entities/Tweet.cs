using System.ComponentModel.DataAnnotations.Schema;

namespace GimmeBooks.Domain.Entities
{
    [Table("tbl_Tweet")]
    public class Tweet : EntityBase<long>
    {
        public string User { get; set; }
        public string Text { get; set; }
        public string Header { get; set; }
    }
}