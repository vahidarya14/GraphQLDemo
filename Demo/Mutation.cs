namespace GraphQLServer
{
    public class Mutation
    {
        public async Task<BookAddedPayload> AddBook(Book book)
        {
            return await Task.FromResult(
                    new BookAddedPayload
                    {
                        Author = book.Author.Name + "2222",
                        Title = book.Title + "2222"
                    });
        }
    }

}
