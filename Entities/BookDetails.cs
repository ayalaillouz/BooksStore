namespace Entities
{
    public class BookDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int NumberOfPages { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public bool IsComics { get; set; }

        public BookDetails(int id, string name, int price, int numberOfPages, 
            int minAge, int maxAge, bool isComics)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.NumberOfPages = numberOfPages;
            this.MinAge = minAge;
            this.MaxAge = maxAge;
            this.IsComics = isComics;
        }
    }
}