namespace OOP.Generic_.ArrayApp
{
    public class Book
    {
        public Book()
        {

        }

        public Book(int id, string title, decimal price)
        {
            İD = id;
            Title = title;
            this.price = price;
        }

        public int İD{ get; set; }
        public string Title { get; set; }
        public decimal price { get; set; }

        public override string ToString()
        {
            return $"{İD,-5}" +
                $" {Title,-25}" +
                $"{price,-10}";
        }

    }
}
