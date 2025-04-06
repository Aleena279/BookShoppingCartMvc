namespace BookShoppingCartMvcUI.Repositories
{
    public interface IGenreRepository
    {
        Task AddGenre(Genre genre);
        Task UpdateGenre(Genre genre);
        Task DeleteGenre(Genre genre);
        Task<Genre?> GetGenreById(int id);
        Task<IEnumerable<Genre>> GetGenres();
    }
}