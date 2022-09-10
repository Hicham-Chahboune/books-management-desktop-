using System;
using System.Collections.Generic;

#nullable disable

namespace ENSAS_Book.ModelsDB
{
    public partial class Book
    {
        public Guid IdBook { get; set; }
        public Guid IdAuthor { get; set; }
        public Guid IdCateg { get; set; }
        public string Title { get; set; }
        public string DescBook { get; set; }
        public byte[] Cover { get; set; }
        public DateTime? PublishedDate { get; set; }
        public double? Price { get; set; }
        public int? NbPages { get; set; }


        //Navigation Properties
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }
}
