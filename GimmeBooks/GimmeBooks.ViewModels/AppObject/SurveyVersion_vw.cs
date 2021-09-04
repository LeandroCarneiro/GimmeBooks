
namespace GimmeBooks.ViewModels.AppObjects
{
    public class SurveyVersion_vw : EntityBase_vw<long>
    {
        public int VersionNumber { get; set; }
        public bool Active { get; set; }
        public long UserId { get; set; }

        public virtual Survey_vw Survey { get; set; }
        public virtual UserApp_vw CreatedBy { get; set; }
    }
}
