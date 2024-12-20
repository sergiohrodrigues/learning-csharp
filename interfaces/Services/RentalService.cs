using interfaces.Entities;

namespace interfaces.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public void ProcessInvoice(CarRental carrental)
        {

        }
    }
}
