using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class RentalAgency
    {
        private Vehicle[] Fleet { get; set; }
        public double TotalRevenue { get; private set; }

        public RentalAgency(int fleetSize)
        {
            Fleet = new Vehicle[fleetSize];
            TotalRevenue = 0;
        }

        public void AddVehicle(Vehicle vehicle, int index)
        {
            Fleet[index] = vehicle;
        }

        public void RemoveVehicle(int index)
        {
            if (Fleet[index] != null)
            {
                TotalRevenue += Fleet[index].RentalPrice;
                Fleet[index] = null;
            }
            else
            {
                Console.WriteLine("No vehicle found at the specified index.");
            }
        }

        public void RentVehicle(int index, int days)
        {
            if (Fleet[index] != null)
            {
                double rentalCost = Fleet[index].RentalPrice * days;
                TotalRevenue += rentalCost;
                Console.WriteLine($"Vehicle rented for {days} days. Total cost: ${rentalCost}");
            }
            else
            {
                Console.WriteLine("No vehicle found at the specified index.");
            }
        }
    }
}