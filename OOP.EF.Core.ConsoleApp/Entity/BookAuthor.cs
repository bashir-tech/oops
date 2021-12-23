namespace OOP.EF.Core.ConsoleApp.Entity
{
    public class BookAuthor
    {
        public int BookauthorId { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
