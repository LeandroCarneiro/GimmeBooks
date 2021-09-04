using GimmeBooks.Domain.Entities;

namespace GimmeBooks.Application.Interfaces
{
    public interface ISurveyBusiness : IBusiness<SurveyVersion>
    {
        void DisableVersion(long surveyId, int version);
    }
}
