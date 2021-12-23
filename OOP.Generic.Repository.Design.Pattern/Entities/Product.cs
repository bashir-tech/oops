using OOP.Generic.Repository.Design.Pattern.Entities.Abstract;

namespace OOP.Generic.Repository.Design.Pattern.Entities.Concrte

{
    public class Product:İEntity
    {
        public Product()
        {

        }
        public Product(int producId, string productname, decimal price, int unitInStock)
        {
            ProducId = producId;
            this.productname = productname;
            this.price = price;
            UnitInStock = unitInStock;
        }

        public int ProducId { get; set; }
        public string productname { get; set; }
        public decimal price { get; set; }
        public int UnitInStock { get; set; }

    }
}

