using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //This class determines which services the vehicle object will receive
    public interface IVehicleService
    {
        Vehicle GetVehicleByLicensePlate(Vehicle vehicle);
        Vehicle GetDeletedVehicle(Vehicle vehicle);
        bool Add(Vehicle vehicle);
        bool Delete(Vehicle vehicle);
        bool MoveVehicle(string licansePlate, int spot);
        List<Vehicle> GetList();
        Vehicle OptimizeMc();
        List<Vehicle> RevenuePerDay();
        List<Vehicle> HistoryList();
        public List<Vehicle> GetRevenue(string startDate, string endDate);
        decimal GetAverage(string startDate, string endDate);

    }
}
