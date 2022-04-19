using System.Globalization;
namespace programAboutProduct.Entities
{
    internal class importedProduct: Product
    {
        //class atributes----------------------
        public double customsFee { get; set; }

        //-------------------------------------

        //Builders--------------------------------------------------------------------------
        public importedProduct()
        {
        }

        public importedProduct(string name, double price, double customsFee): base(name, price)
        {
            this.customsFee = customsFee;
        }
        //-----------------------------------------------------------------------------------

        //class methods---------------------------
        public override string priceTag()
        {
            return $"{name} $ {totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {customsFee.ToString("F2", CultureInfo.InvariantCulture)})";

        }
        public double totalPrice()
        {
            return price + customsFee;
        }
        //---------------------------------------
    }
}
