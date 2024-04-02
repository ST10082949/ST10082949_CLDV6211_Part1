namespace KhumaloCraft.Models
{
    public class Products
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? Description { get; set; }
        
        public decimal Price { get; set; }
        public string? ImgUrl {  get; set; }

        public string? ProductName { get; set;}

        public string? Country { get; set; }

    }
}
