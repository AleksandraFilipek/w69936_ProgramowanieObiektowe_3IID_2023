using Lab_6;
using System;

namespace Lab_6
{
    public interface IBookRepository : IBaseRepository<Book, long>
    {

    }

    public interface IPersonRepository : IBaseRepository<Person, int>
    {

    }
}