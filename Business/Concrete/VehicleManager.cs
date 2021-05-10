using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //This class inheriting from interface and applying all methods from IVehicleService
    public class VehicleManager : IVehicleService

    {
        IVehicleDal vehicleDal;
        public VehicleManager(IVehicleDal vehicleDal)
        {
            this.vehicleDal = vehicleDal;
        }
        //Add vehicle by license plate and vehicle type and return true if car can be added on database
        public bool Add(Vehicle vehicle)
        {
            int rowAffected = vehicleDal.Add(vehicle);
            return rowAffected==0?false:true;
        }
        public bool Delete(Vehicle vehicle)
        {
            int rowAffected = vehicleDal.Delete(vehicle);
            return rowAffected == 0 ? false : true;
        }
        public Vehicle OptimizeMc()
        {
           Vehicle vehicle = vehicleDal.OptimizeMc();
           return vehicle;
        }
        public Vehicle GetDeletedVehicle(Vehicle vehicle)
        {
            vehicle = vehicleDal.GetDeletedVehicle(vehicle);
            return vehicle;
        }

        public List<Vehicle> GetList()
        {
            return vehicleDal.GetList();
        }

        //Return singel vehicle object by licanse plate
        public Vehicle GetVehicleByLicensePlate(Vehicle vehicle)
        {
            vehicle = vehicleDal.GetVehicleByLicensePlate(vehicle);
            return vehicle;
        }

        public bool MoveVehicle(string licansePlate, int spot)
        {
            int rowAffected = vehicleDal.MoveVehicle(licansePlate, spot);
            return rowAffected == 0 ? false : true;
        }

        public List<Vehicle> RevenuePerDay()
        {
            return vehicleDal.RevenuePerDay();
        }
        public List<Vehicle> GetRevenue(string startDate, string endDate)
        {
            return vehicleDal.GetRevenue(startDate, endDate);
        }
        public decimal GetAverage(string startDate, string endDate)
        {
            return vehicleDal.GetAverage(startDate, endDate);
        }
        public List<Vehicle> HistoryList()
        {
            return vehicleDal.HistoryList();
        }
    }
}
