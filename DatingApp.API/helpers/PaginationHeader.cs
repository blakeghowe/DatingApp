namespace DatingApp.API.helpers
{
    public class PaginationHeader
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }

        public PaginationHeader(int currentPage, int itemsPerPage, int totalItems,
            int TotalPages)
        {
            this.CurrentPage = currentPage;
            this.ItemsPerPage = itemsPerPage;
            this.TotalItems = totalItems;
            this.TotalPages = TotalPages;
        }
    }
}