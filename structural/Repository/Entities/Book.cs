using System;

namespace Repository.Entities
{
     public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Published { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}