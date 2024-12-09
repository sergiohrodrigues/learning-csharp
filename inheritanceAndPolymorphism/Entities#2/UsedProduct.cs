using System.Globalization;
using inheritanceAndPolymorphism.EntitiesExercice2;

namespace inheritanceAndPolymorphism.Entities_2
{
    internal class UsedProduct : Product
    {

        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            ManufactureDate = date;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
