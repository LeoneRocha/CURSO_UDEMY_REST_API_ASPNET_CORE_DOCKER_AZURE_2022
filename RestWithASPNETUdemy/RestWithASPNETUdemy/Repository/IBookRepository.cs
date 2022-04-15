using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    public interface IBookRepository
    {
        Book Create(Book entity);
        Book FindByID(long id);
        List<Book> FindAll();
        Book Update(Book entity);
        void Delete(long id);
        bool Exists(long id);
    }
}
