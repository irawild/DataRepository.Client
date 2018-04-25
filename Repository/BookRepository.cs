using DataRepository.Client.Models;
using DataRepository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataRepository.Client.Repository
{
    public class BookRepository : Repository<Book>
    {
        public BookRepository(IDataRepositoryContext contexto) : base(contexto)
        {
        }
    }
}
