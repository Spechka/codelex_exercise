using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental.Interfaces
{
    public interface IScooterService
    {
        // Add scooter.

        // <param name="id">Unique ID of the scooter</param>
        // <param name="pricePerMinute">Rental price of the scooter per one minute</param>
        void AddScooter(string id, decimal pricePerMinute);

        // Remove scooter. This action is not allowed for scooters if the rental is in progress.

        // <param name="id">Unique ID of the scooter</param>
        void RemoveScooter(string id);

        // List of scooters that belong to the company.

        // <returns>Return a list of available scooters.</returns>
        IList<Scooter> GetScooters();

        // Get particular scooter by ID.

        // <param name="scooterId">Unique ID of the scooter.</param>
        // <returns>Return a particular scooter.</returns>
        Scooter GetScooterById(string scooterId);
    }
}
