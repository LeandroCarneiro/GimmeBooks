using GimmeBooks.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimmeBooks.Domain.Entities
{
    [Table("tbl_surveys")]
    public class Survey : EntityBase<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsValid { get; set; }
        public ESurveyType Type { get; set; }

        public virtual IEnumerable<Question> Questions { get; set; }
    }
}
