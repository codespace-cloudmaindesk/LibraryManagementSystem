namespace aspnet_core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool isAvailable { get; set; }
        public Book()
        {
                
        }
    }
}
