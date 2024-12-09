namespace inheritanceAndPolymorphism.Entities_5
{
    internal class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }
        
        public Individual(string name, double anualIncome, double health) : base(name, anualIncome)
        {
            HealthExpenditures = health;
        }

        public override double Tax()
        {
            if(AnualIncome < 20000)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.50); 
            } else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
        }
    }
}
