using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess.Concrete.ADO.NET.SQL
{
    //Doing CRUD for vehicle entity. 
    public class SqlVehicleDal : IVehicleDal
    {
        //Create instances swldatabase class for get back ready connection object.
        public SqlDatabase sqld = new SqlDatabase();
        //Connection text
        private string connectionString;
        public SqlVehicleDal(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //Add vehicle by license plate and vehicle type returns affected rows
        public int Add(Vehicle vehicle)
        {
            int rowsAffected = 0;
            string sql = "EXECUTE spAddVehicle @LicensePlate,@VehicleTypeId";
            using (SqlConnection conn = sqld.ConnectToDb(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@LicensePlate", vehicle.LicensePlate);
                cmd.Parameters.AddWithValue("@VehicleTypeId", vehicle.VehicleTypeId);
                try
                {
                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return rowsAffected;
        }

        public int Delete(Vehicle vehicle)
        {
            int rowsAffected = 0;
            string sql = "EXECUTE spDeleteVehicle @VehiclePlate, @Cost";
            using (SqlConnection conn = sqld.ConnectToDb(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@VehiclePlate", vehicle.LicensePlate);
                cmd.Parameters.AddWithValue("@Cost", vehicle.TotalCost);
                try
                {
                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }

                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return rowsAffected;
        }

        public List<Vehicle> OptimizeMc()
        {
            Vehicle vehicles = null;
            string sql = "EXECUTE spOptimizeMc";
            List<Vehicle> optimizeParking = new List<Vehicle>();
            using (SqlConnection conn = sqld.ConnectToDb(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        vehicles = new Vehicle((string)dr["LicensePlate"]) { SpotNumber = (int)dr["ParkingSpotId"],OldSpotNumber = (int)dr["OldPlace"] };
                        if (vehicles.SpotNumber == vehicles.OldSpotNumber)
                        {
                            
                            break;
                        }
                        optimizeParking.Add(vehicles);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
            return optimizeParking;

        }

        public Vehicle GetDeletedVehicle(Vehicle vehicle)
        {
            string sql = "EXECUTE spGetDeletedVehicle @LicensePlate";
            using (SqlConnection conn = sqld.ConnectToDb(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@LicensePlate", vehicle.LicensePlate);
                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        vehicle.ArrivalTime = (DateTime)dr["ArrivalDate"];
                        vehicle.VehicleTypeId = (int)dr["VehicleType"];
                        vehicle.TotalCost = (decimal)dr["Cost"];
                        TimeSpan diff = (DateTime)dr["DepartureDate"] - (DateTime)dr["ArrivalDate"];
                        vehicle.ParkedTime = diff;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
            return vehicle;
        }

        public List<Vehicle> GetList()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string sql = "EXECUTE spGetList";
            using (SqlConnection conn = sqld.ConnectToDb(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        vehicles.Add(new Vehicle((string)dr["LicensePlate"]) { SpotNumber = (int)dr["ParkingSpotId"],
                            VehicleTypeId = (int)dr["VehicleTypeId"], ArrivalTime = (DateTime)dr["ArrivalDate"],
                            ParkedTime = (TimeSpan)(DateTime.Now - (DateTime)dr["ArrivalDate"])
                        });
                        
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
            return vehicles;

        }
        private TimeSpan GetTimeSpan(DateTime serverTime, DateTime arrival)
        {
            TimeSpan diff = serverTime - arrival;
            return diff;
        }
        //Return singel vehicle object by licanse plate
        public Vehicle GetVehicleByLicensePlate(Vehicle vehicle)
        {
            string sql = "EXECUTE spGetVehicleByLicensePlate @LicensePlate";
            using (SqlConnection conn = sqld.ConnectToDb(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@LicensePlate", vehicle.LicensePlate);
                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        vehicle.SpotNumber = (int)dr["ParkingSpotId"];
                        vehicle.ArrivalTime = (DateTime)dr["ArrivalDate"];
                        vehicle.VehicleTypeId = (int)dr["VehicleTypeId"];
                        vehicle.CostByHour = (decimal)dr["CostByHour"];
                        TimeSpan diff = (DateTime)dr["ServerTime"] - (DateTime)dr["ArrivalDate"];
                        vehicle.ParkedTime = diff;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
            return vehicle;
        }

        public int MoveVehicle(string licansePlate, int spot)
        {
            int rowsAffected = 0;
            string sql = "EXECUTE spMoveVehicle @LicensePlate, @NewSpotId";
            using (SqlConnection conn = sqld.ConnectToDb(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@LicensePlate", licansePlate);
                cmd.Parameters.AddWithValue("@NewSpotId", spot);
                try
                {
                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return rowsAffected;
        }

        public List<Vehicle> RevenuePerDay()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string sql = "EXECUTE spRevenuePerDay";
            using (SqlConnection conn = sqld.ConnectToDb(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        vehicles.Add(new Vehicle() { ArrivalTime = (DateTime)dr["TotalDate"], TotalCost = (decimal)dr["TotalCost"] });
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
            return vehicles;
        }

        public List<Vehicle> GetRevenue(string startDate, string endDate)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string sql = "EXECUTE spRevenueInterval @StartDate, @EndDate";
            using (SqlConnection conn = sqld.ConnectToDb(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        vehicles.Add(new Vehicle() { ArrivalTime = (DateTime)dr["TotalDate"], TotalCost = (decimal)dr["TotalCost"] });
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return vehicles;
        }
        public decimal GetAverage(string startDate, string endDate)
        {
            decimal average = 0;
            string sql = "spAverage";
            using (SqlConnection conn = sqld.ConnectToDb(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter returnAverage = cmd.Parameters.Add("@Average", SqlDbType.Money);
                returnAverage.Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                try
                {
                    conn.Open();
                    cmd.ExecuteReader();
                    average = (decimal)returnAverage.Value;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return average;
        }
        public List<Vehicle> HistoryList()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string sql = "SELECT * FROM vwHistory";
            using (SqlConnection conn = sqld.ConnectToDb(connectionString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        TimeSpan diff = (DateTime)dr["DepartureDate"] - (DateTime)dr["ArrivalDate"];
                        vehicles.Add(new Vehicle((string)dr["LicensePlate"]) { VehicleTypeId = (int)dr["VehicleType"], ArrivalTime = (DateTime)dr["ArrivalDate"],ParkedTime =diff,TotalCost = (decimal)dr["Cost"] });
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
            return vehicles;
        }
    }
}
