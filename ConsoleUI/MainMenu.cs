using Business.Concrete;
using System;
using System.Threading;
using DataAccess.Abstract;
using DataAccess.Concrete.ADO.NET.SQL;
using Entities.Concrete;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ConsoleUI
{
    class MainMenu
    {
        VehicleManager vehicleManager;
        public MainMenu(string connectionString)
        {
            //Create instances bussiness manager class for vehicle by databasetype and send to database connectstring.
            vehicleManager = new VehicleManager(new SqlVehicleDal(connectionString));
        }
        private bool welcomeText = false;
        public void Menu()
        {
            if (welcomeText)
            {
                Console.Clear();
                Console.SetCursorPosition(38, 13);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("WELCOME TO THE PRAGUE PARKING PROGRAM");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(800);
                }
                welcomeText = false;
            }
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(38, 10);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t     CHOOSE AN OPTION BELOW");
                Console.WriteLine("\t\t\t\t\t  _______________________________________________");
                Console.WriteLine("\t\t\t\t\t |                                               |");
                Console.WriteLine("\t\t\t\t\t | (1)  -  Search for a vehicle                  |");
                Console.WriteLine("\t\t\t\t\t | (2)  -  Check in a vehicle                    |");
                Console.WriteLine("\t\t\t\t\t | (3)  -  Check out a vehicle                   |");
                Console.WriteLine("\t\t\t\t\t | (4)  -  Move vehicle to another parking spot  |");
                Console.WriteLine("\t\t\t\t\t | (5)  -  Display all parked vehicles           |");
                Console.WriteLine("\t\t\t\t\t | (6)  -  Optimize Parking                      |");
                Console.WriteLine("\t\t\t\t\t | (7)  -  Show revenue per day                  |");
                Console.WriteLine("\t\t\t\t\t | (8)  -  Show parked vehicle more than 48h     |");
                Console.WriteLine("\t\t\t\t\t | (9)  -  Show revenue per day or interval      |");
                Console.WriteLine("\t\t\t\t\t | (10) -  EXIT PROGRAM                          |");
                Console.WriteLine("\t\t\t\t\t |_______________________________________________|");
                Console.Write("\t\t\t\t\t        Write your option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        SearchVehicle();
                        break;
                    case "2":
                        AddVehicle();
                        break;
                    case "3":
                        RemoveVehicle();
                        break;
                    case "4":
                        MoveVehicle();
                        break;
                    case "5":
                        GetList();
                        break;
                    case "6":
                        OptimizeParking();
                        break;
                    case "7":
                        RevenuePerDay();
                        break;
                    case "8":
                        ParkedMoreThan48h();
                        break;
                    case "9":
                        GetRevenue();
                        break;
                    case "10":
                        ExitText();
                        Environment.Exit(1);
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(38, 13);
                        Console.WriteLine("You have entered an invalid answer. You have to enter a number 1 to 7");
                        Console.SetCursorPosition(38, 14);
                        Console.Write("Press ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ENTER ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("to get back to the Menu...");
                        Console.ReadLine();
                        Menu();
                        break;
                }
            }
        }

        public void GetRevenue()
        {
            Console.Clear();

            string startDate = GetDate("start date");
            string endDate = GetDate("end date");
            Console.Clear();
            List<Vehicle> vehicles = null;

            vehicles = vehicleManager.GetRevenue(startDate, endDate);

            foreach (var p in vehicles)
            {
                Console.WriteLine("{0}: {1} Kč", p.ArrivalTime, p.TotalCost);
            }
            
            if (startDate != endDate)
            {
               decimal avarage = vehicleManager.GetAverage(startDate, endDate);
                Console.WriteLine("Avarage per day: {0}",avarage);
            }
            Console.ReadLine();
        }

        public string GetDate(string dateText)
        {
            Console.Clear();
            bool isCorrect = false;
            string dateInput = "";
            while (!isCorrect)
            {
                Console.WriteLine("Write {0} (yyyyDDMM): ", dateText);
                dateInput = Console.ReadLine();
                if (!DateTime.TryParseExact(dateInput, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime temp))
                {
                    Console.WriteLine("'{0}' is not in an acceptable format. Please enter date formet YYYYMMDD", dateInput);
                }
                else
                {
                    isCorrect = true;
                }
            }
            return dateInput;

        }

        //Text to come when the program closes
        public void ExitText()
        {
            Console.Clear();
            Console.SetCursorPosition(38, 13);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("GOOD BYE");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(".");
                Thread.Sleep(800);
            }
        }
        //Searching for a vehicle by license plate
        public void SearchVehicle()
        {
            string licansePlate = GetLicensePlate();
            Vehicle vehicle = new Vehicle(licansePlate);
            //Get back vehicle from database
            vehicle = vehicleManager.GetVehicleByLicensePlate(vehicle);
            Console.Clear();
            Console.SetCursorPosition(38, 13);
            Console.WriteLine("{0} with license plate \"{1}\" is parked at spot {2}", vehicle.VehicleType, vehicle.LicensePlate, vehicle.SpotNumber);
            Console.SetCursorPosition(38, 15);
            Console.WriteLine("Arrival: {0}", vehicle.ArrivalTime);
            Console.SetCursorPosition(38, 17);
            Console.WriteLine("Total parking time: {0} days, {1} hours, {2} minutes", vehicle.ParkedTime.Days, vehicle.ParkedTime.Hours, vehicle.ParkedTime.Minutes);
            Console.SetCursorPosition(38, 19);
            Console.WriteLine("Total parking fee: {0:c}", PriceCalculate(vehicle));
            Console.ReadLine();
        }
        //Add vehicle by license plate and vehicle type
        public void AddVehicle()
        {
            int vehicleTypeId = GetVehicleTyp();
            string licansePlate = GetLicensePlate();
            Vehicle vehicle = new Vehicle(licansePlate) { VehicleTypeId = vehicleTypeId };
            bool isAdded = vehicleManager.Add(vehicle);
            if (isAdded)
            {
                Console.Clear();
                Console.SetCursorPosition(38, 13);
                vehicle = vehicleManager.GetVehicleByLicensePlate(vehicle);
                Console.WriteLine("Car with license plate \"{0}\" is parked at position {1}", vehicle.LicensePlate, vehicle.SpotNumber);
                Console.ReadLine();
            }
        }
        public void RemoveVehicle()
        {
            string licansePlate = GetLicensePlate();
            Vehicle vehicle = new Vehicle(licansePlate);
            bool check = true;
            while (check)
            {
                
                Console.Clear();
                Console.SetCursorPosition(38, 14);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do you want to get paid for this parking time?");
                Console.SetCursorPosition(38, 15);
                Console.WriteLine("1- Yes");
                Console.SetCursorPosition(38, 16);
                Console.WriteLine("2- No");
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    check = false;
                }
                else if (choose == 2)
                {
                    vehicle.TotalCost = -1;
                    check = false;
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(38, 13);
                    Console.WriteLine("Invalid entry! You have to enter a number 1 or 2");
                    Console.SetCursorPosition(38, 14);
                    Console.Write("Press ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\"ENTER\" ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("to try again...");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            }
            bool isAdded = vehicleManager.Delete(vehicle);
            if (isAdded)
            {
                vehicle = vehicleManager.GetDeletedVehicle(vehicle);
                Console.Clear();
                Console.SetCursorPosition(38, 11);
                Console.WriteLine("Vehicle with registration number \"{0}\" was succesfully removed", vehicle.LicensePlate);
                Console.SetCursorPosition(38, 13);
                Console.WriteLine("Arrival: {0}", vehicle.ArrivalTime);
                Console.SetCursorPosition(38, 14);
                Console.WriteLine("Total parking time: {0} days, {1} hours, {2} minutes", vehicle.ParkedTime.Days, vehicle.ParkedTime.Hours, vehicle.ParkedTime.Minutes);
                Console.SetCursorPosition(38, 16);
                Console.WriteLine("Total parking fee: {0:c}", vehicle.TotalCost);
                Console.ReadLine();
            }
        }
        public void MoveVehicle()
        {
            bool checkInt = true;
            int spot = 0;
            string licansePlate = GetLicensePlate();
            while (checkInt)
            {
                try
                {
                    Console.Clear();
                    //ParkingListPrint();
                    Console.ResetColor();
                    Console.SetCursorPosition(45, 2);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Where would you like to park \"{1-100}\": ");
                    spot = int.Parse(Console.ReadLine()); //try cach
                    if (spot < 1 || spot > 100)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    checkInt = false;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.ResetColor();
                    Console.SetCursorPosition(45, 15);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Invalid entry! You have to enter a number between 1 and 100");
                    Console.ReadLine();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.ResetColor();
                    Console.SetCursorPosition(45, 15);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Invalid entry! You have to enter a number between 1 and 100");
                    Console.ReadLine();
                }
            }
            bool isMoved = vehicleManager.MoveVehicle(licansePlate, spot);
            if (isMoved)
            {
                Console.Clear();
                //ParkingListPrint();
                Console.SetCursorPosition(45, 2);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Vehicle has been moved");
                Console.ReadLine();
            }

        }
        public void GetList()
        {
            Console.Clear();
            List<Vehicle> vehicles = vehicleManager.GetList();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("CAR");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("MC");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("EMPTY");
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 1; i < 101; i++)
            {
                for (int j = 1; j < vehicles.Count; j++)
                {
                    if (vehicles[j].SpotNumber == i)
                    {
                        if (vehicles[j].VehicleTypeId == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("{0}: {1} {2}", vehicles[j].SpotNumber, vehicles[j].LicensePlate, vehicles[j].VehicleType);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("{0}: {1} {2}", vehicles[j].SpotNumber, vehicles[j].LicensePlate, vehicles[j].VehicleType);
                        }
                    }
                }
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("{0}: EMPTY EMPTY",i);
            }
            Console.ReadLine();
        }
        public void RevenuePerDay()
        {
            Console.Clear();
            List<Vehicle> vehicles = null;

            vehicles = vehicleManager.RevenuePerDay();

            foreach (var p in vehicles)
            {
                Console.WriteLine("{0}: {1} Kč", p.ArrivalTime,p.TotalCost);
            }
            Console.ReadLine();
        }
        public void ParkedMoreThan48h()
        {
            Console.Clear();
            List<Vehicle> vehicles = vehicleManager.HistoryList();

            foreach (var p in vehicles)
            {
                if (p.ParkedTime.TotalMinutes > 2880)
                {
                    Console.WriteLine(p.LicensePlate);
                }
            }
            Console.ReadLine();
        }
        public void OptimizeParking()
        {
            Console.Clear();
            Vehicle vehicle = null;
            while (true)
            {
                vehicle = vehicleManager.OptimizeMc();
                if (vehicle == null)
                {
                    break;
                }
                Console.WriteLine("MoveVehicle Mc: {0} from > {1} to the new place > {2}",vehicle.LicensePlate,vehicle.OldSpotNumber,vehicle.SpotNumber);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public int GetVehicleTyp()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(38, 13);
                Console.WriteLine("Choose your vehicle type");
                Console.SetCursorPosition(38, 14);
                Console.WriteLine("(1) for CAR");
                Console.SetCursorPosition(38, 15);
                Console.WriteLine("(2) for MC");
                Console.SetCursorPosition(38, 16);
                Console.Write("Your choose: ");
                string tempType = Console.ReadLine();
                if (tempType == "1")
                {
                    return 1;
                }
                else if (tempType == "2")
                {
                    return 2;
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(38, 13);
                    Console.WriteLine("Invalid entry! You have to enter a number 1 or 2");
                    Console.SetCursorPosition(38, 14);
                    Console.Write("Press ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\"ENTER\" ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("to try again...");
                    Console.ResetColor();
                    Console.ReadLine();
                }
            }
        }
        //Return license plate after cleaning with CleandString() metod
        public static string GetLicensePlate()
        {
            string licansePlate = "licansePlate";
            bool check = true;
            while (check)
            {
                Console.Clear();
                Console.SetCursorPosition(38, 14);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Write licanse palte: ");
                licansePlate = Console.ReadLine();
                if (licansePlate.Length > 10 || licansePlate.Length < 3)
                {
                    Console.Clear();
                    Console.SetCursorPosition(38, 14);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Licanse plate must be more than 3 characters and less than 10!");
                    Console.SetCursorPosition(38, 15);
                    Console.Write("Press ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\"ENTER\" ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("to try again...");
                    Console.ResetColor();
                    Console.ReadLine();
                }
                else
                {
                    licansePlate = CleanString(licansePlate);
                    check = false;
                }
            }
            return licansePlate;
        }
        //Calculate price
        public static decimal PriceCalculate(Vehicle vehicle)
        {
            decimal price = 0;
            int hour;
            //vehicle.ParkedTime is total parking time
            if (vehicle.ParkedTime.TotalMinutes < 5)
            {
                price = 0;
            }
            else if (vehicle.ParkedTime.TotalMinutes < 125)
            {
                price = vehicle.CostByHour * 2;
            }
            else
            {
                if ((vehicle.ParkedTime.TotalMinutes - 5) % 60 == 0)
                {
                    hour = (int)(vehicle.ParkedTime.TotalMinutes - 5) / 60;
                }
                else
                {
                    hour = (int)(vehicle.ParkedTime.TotalMinutes - 5) / 60;
                    hour++;
                }
                price = hour * vehicle.CostByHour;
            }
            return price;
        }
        //Cleaning license plate ex. ¤%"!-. and space.
        public static string CleanString(string cleanString)
        {
            string licanseplateUpper = cleanString.ToUpper();
            return Regex.Replace(licanseplateUpper, @"[^\w]", "");
        }
    }
}
