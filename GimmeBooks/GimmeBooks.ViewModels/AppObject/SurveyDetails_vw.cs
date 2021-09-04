using GimmeBooks.Common;
using System;

namespace GimmeBooks.ViewModels.AppObjects
{
    public class SurveyDetails_vw : EntityBase_vw<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsValid { get; set; }
        public ESurveyType Type { get; set; }
    }
}
