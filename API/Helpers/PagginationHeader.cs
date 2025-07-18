namespace API.Helpers;

public class PagginationHeader(int CurrentPage, int itemsPerPage, int totalItems, int TotalPages)
{
    public int CurrentPage { get; set; } = CurrentPage;
    public int ItemPerPages { get; set; } = itemsPerPage;
    public int TotalItems { get; set; } = totalItems;
    public int TotalPages { get; set; } = TotalPages;
}
