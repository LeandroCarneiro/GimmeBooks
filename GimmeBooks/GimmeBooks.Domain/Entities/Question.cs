using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimmeBooks.Domain.Entities
{
    [Table("tbl_questions")]
    public class Question : EntityBase<long>
    {
        public string Title { get; set; }
        public string Help { get; set; }
        public virtual IEnumerable<Answer> Answers { get; set; }
    }
}