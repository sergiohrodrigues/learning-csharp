using System.Globalization;
using inheritanceAndPolymorphism.EntitiesExercice2;

namespace inheritanceAndPolymorphism.Entities_2
{
    internal class ImportedProduct : Product
    {

        public double CustomFee { get; set; }

        public ImportedProduct(string name, double price, double fee) : base(name, price)
        {
            CustomFee = fee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }
    }
}
