namespace Bodone_Iulia_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public required string AuthorFirstName { get; set; }
        public required string AuthorLastName { get; set; }
        public string FullName => $"{AuthorFirstName} {AuthorLastName}";

        public ICollection<Book>? Books { get; set; }
    }
}
