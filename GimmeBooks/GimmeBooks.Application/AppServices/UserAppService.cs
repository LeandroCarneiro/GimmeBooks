using GimmeBooks.Application.Interfaces;
using GimmeBooks.Domain.Entities;
using GimmeBooks.ViewModels.AppObjects;

namespace GimmeBooks.Application.AppServices
{
    public class UserAppService : BaseAppService<UserApp_vw, UserApp>
    {
        public UserAppService(IUserBusiness business) : base(business) { }
    }
}
