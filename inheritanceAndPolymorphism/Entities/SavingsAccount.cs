namespace inheritanceAndPolymorphism.Entities
{
    //sealed 
        internal class SavingsAccount : Account
    {
        public double InteresRate { get; set; }
        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            InteresRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InteresRate;
        }

        public 
            //sealed 
            override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}
