namespace BookShoppingCartMvcUI.Repositories
{
    public interface IStockRepository
    {
        Task<Stock?> GetStockByBookId(int bookId);
        Task ManageStock(StockDTO stockToManage);
        Task<IEnumerable<StockDisplayModel>> GetStocks(string sTerm = "");
    }
}