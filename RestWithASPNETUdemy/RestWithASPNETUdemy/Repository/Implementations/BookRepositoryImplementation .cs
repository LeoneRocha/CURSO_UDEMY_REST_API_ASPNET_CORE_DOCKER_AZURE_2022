using Microsoft.EntityFrameworkCore.Internal;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Repository.Implementations
{
    public class BookRepositoryImplementation : IBookRepository
    {

        private MySQLContext _context;

        public BookRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }
        
        // Method responsible for returning all people,
        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }

        // Method responsible for returning one person by ID
        public Book FindByID(long id)
        {
            return _context.Books.SingleOrDefault(p => p.Id.Equals(id));
        }

        // Method responsible to crete one new person
        public Book Create(Book entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }

        // Method responsible for updating one person
        public Book Update(Book entity)
        {
            // We check if the person exists in the database
            // If it doesn't exist we return an empty person instance
            if (!Exists(entity.Id)) return null;

            // Get the current status of the record in the database
            var result = _context.Books.SingleOrDefault(p => p.Id.Equals(entity.Id));
            if (result != null)
            {
                try
                {
                    // set changes and save
                    _context.Entry(result).CurrentValues.SetValues(entity);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return entity;
        }

        // Method responsible for deleting a person from an ID
        public void Delete(long id)
        {
            var result = _context.Books.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Books.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public bool Exists(long id)
        {
            return _context.Books.Any(p => p.Id.Equals(id));
        }
    }
}
