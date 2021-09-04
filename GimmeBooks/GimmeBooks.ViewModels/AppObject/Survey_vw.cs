using System.Collections.Generic;

namespace GimmeBooks.ViewModels.AppObjects
{
    public class Survey_vw : EntityBase_vw<long>
    {
        public SurveyDetails_vw Details { get; set; }
        public IEnumerable<Question_vw> Questions { get; set; }
    }
}