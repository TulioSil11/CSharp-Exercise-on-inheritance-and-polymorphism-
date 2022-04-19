using System;
using System.Globalization;

namespace programAboutProduct.Entities
{
    internal class usedProduct: Product
    {
        //class atributes-----------------------------
        public DateTime manufactureDate  { get; set; }
        //--------------------------------------------

        //Builders ----------------------------------------------------------------------------
        public usedProduct()
        {

        }
        public usedProduct(string name, double price, DateTime manuFactureDate): base(name, price)
        {
            this.manufactureDate = manuFactureDate;
        }
        //--------------------------------------------------------------------------------------

        //class methods---------------------------------------------------------------------
        public override string priceTag()
        {
            return $"{name} (used) $ {price.ToString("F2", CultureInfo.InvariantCulture)}" +
                $" (Manufacture date: {manufactureDate.ToString("dd/MM/yyyy")})";
        }
        //-----------------------------------------------------------------------------------
    }
}
