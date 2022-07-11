namespace GraphQLServer
{
    public class Book
    {
        public string Title { get; set; }

        public Author Author { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
    }

    public class BookAddedPayload
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

}
