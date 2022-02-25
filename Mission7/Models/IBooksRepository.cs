using System;
using System.Linq;

namespace Mission7.Models
{
    public interface IBooksRepository
    {
        IQueryable<Books> Books { get; }
    }
}
