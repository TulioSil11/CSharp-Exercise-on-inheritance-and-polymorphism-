using System.Globalization;

namespace programAboutProduct.Entities
{
    internal class Product
    {
        //class atributes----------------
        public string name { get; set; }
        public double price { get; set; }
        //-------------------------------

        //Builders-----------------------------
        public Product()
        {
        }
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        //-------------------------------------

        //class methods------------------
        public virtual string priceTag()
        {
            return $"{name} $ {price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
        //-------------------------------
    }
}
