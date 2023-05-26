using BookAbstraction.Interfaces;
using BookModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDB.Context
{
    public class BookDbContext : DbContext, IBookDbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
    }
}
