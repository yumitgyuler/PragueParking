using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Determines the methods to be done for all databases
    public interface IVehicleDal
    {
        Vehicle GetVehicleByLicensePlate(Vehicle vehicle);
        Vehicle GetDeletedVehicle(Vehicle vehicle);
        int Add(Vehicle vehicle);
        int Delete(Vehicle vehicle);
        List<Vehicle> GetList();
        int MoveVehicle(string licansePlate, int spot);
        List<Vehicle> OptimizeMc();
        List<Vehicle> RevenuePerDay();
        List<Vehicle> GetRevenue(string startDate, string endDate);
        List<Vehicle> HistoryList();
        decimal GetAverage(string startDate, string endDate);
    }
}
