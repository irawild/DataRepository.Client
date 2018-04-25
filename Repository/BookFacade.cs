using DataRepository.Client.Models;
using DataRepository.Data;
using AutoMapper;

namespace DataRepository.Client.Repository
{
    public class BookFacade : Facade<Book, BookViewModel>
    {
        public BookFacade(IRepository<Book> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
