using GimmeBooks.Application.Interfaces.Business;
using GimmeBooks.Domain.Entities;

namespace GimmeBooks.Business.Domain
{
    public class BookBusiness : AppBusiness<Book>, IBookBusiness
    {
    }
}
