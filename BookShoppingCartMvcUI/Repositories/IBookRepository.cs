namespace BookShoppingCartMvcUI.Repositories
{
    public interface IBookRepository
    {
        Task AddBook(Book book);
        Task DeleteBook(Book book);
        Task<IEnumerable<Book>> GetBooks();
        Task<Book?> GetBookById(int id);
        Task UpdateBook(Book book);


    }
}