namespace ScooterRental.Interfaces
{
    public interface IRentalCompany
    {
        // Name of the company.
        string Name { get; }

        // Start the rent of the scooter.
        /// <param name="id">ID of the scooter</param>

        void StartRent(string id);
        // End the rent of the scooter.

        // <param name="id">ID of the scooter
        // returns the total price of rental. It has to calculated taking into account for how long time scooter was rented.
        // If total amount per day reaches 20 EUR than timer must be stopped and restarted at beginning of next day at 0:00 am

        decimal EndRent(string id);
        // Income report.
        // <param name="year">Year of the report. Sum all years if value is not set.
        // <param name="includeNotCompletedRentals">Include income from the scooters that are rented out (rental has not ended yet) and
        // to-do : calculate rental
        // price as if the rental would end at the time when this report was requested.
        // return the total price of all rentals filtered by year if given.
        decimal CalculateIncome(int? year, bool includeNotCompletedRentals);
    }
}