using Microsoft.EntityFrameworkCore.Internal;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {

        private readonly IBookRepository _repository;

        public BookBusinessImplementation(IBookRepository repository)
        {
            _repository = repository;
        }
        
        // Method responsible for returning all people,
        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        // Method responsible for returning one person by ID
        public Book FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        // Method responsible to crete one new person
        public Book Create(Book entity)
        {
            return _repository.Create(entity);
        }

        // Method responsible for updating one person
        public Book Update(Book entity)
        {
            return _repository.Update(entity);
        }

        // Method responsible for deleting a person from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
