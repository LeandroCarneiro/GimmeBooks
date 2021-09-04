using System.ComponentModel.DataAnnotations.Schema;

namespace GimmeBooks.Domain.Entities
{
    [Table("tbl_survey_version")]
    public class SurveyVersion : EntityBase<long>
    {
        public int VersionNumber { get; set; }
        public bool Active { get; set; }
        public long SurveyId { get; set; }
        public long UserId { get; set; }

        [ForeignKey(nameof(SurveyId))]
        public virtual Survey Survey { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual UserApp CreatedBy { get; set; }
    }
}
