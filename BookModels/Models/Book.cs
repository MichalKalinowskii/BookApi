using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookModels.Models
{
    public class Book : BaseModel
    {
        public Guid ISBN { get; set; }
        public string Desc { get; set; }
        public Author Author { get; set; }
        public string BookGenre { get; set; }
        public string Title { get; set; }
    }
}
