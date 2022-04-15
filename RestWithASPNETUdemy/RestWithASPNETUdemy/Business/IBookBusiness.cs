using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
        Book Create(Book entity);
        Book FindByID(long id);
        List<Book> FindAll();
        Book Update(Book entity);
        void Delete(long id);
    }
}
