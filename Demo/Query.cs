namespace GraphQLServer
{
    public class Query
    {
        public Book GetBook() => new Book { Title = "C# in depth.", Author = new Author { Name = "Jon Skeet" } };
        public Book GepBook(long id) => new Book { Title = "C# in depth", Author = new Author { Name = "Jon Skeet" } };
        public Book Test(long id) => new Book { Title = "C# in depth", Author = new Author { Name = "Jon Skeet" } };
    }

}
