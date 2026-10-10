using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
namespace KooliProjekt.Application.Data
{
    public class SeedData
    {
        public static void Generate(ApplicationDbContext context)
        {
            if(context.Customers.Any())
            {
                return;
            }

            SeedCustomers(context);
            SeedCarManufacturers(context);
            SeedCarModels(context);
            SeedCars(context);
            SeedReservations(context);
            SeedInvoices(context);
            SeedInvoiceLines(context);
        }

        public static void SeedCustomers(ApplicationDbContext context)
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    CustomerName = "Alexander Miller",
                    Email = "alexander.miller@example.com",
                    LoggedInNo = false,
                    Password = "AlexMiller2026!"
                },
                new Customer
                {
                    CustomerName = "Emma Johnson",
                    Email = "emma.johnson@example.com",
                    LoggedInNo = false,
                    Password = "EmmaJohnson2026!"
                },
                new Customer
                {
                    CustomerName = "Daniel Wilson",
                    Email = "daniel.wilson@example.com",
                    LoggedInNo = false,
                    Password = "DanielWilson2026!"
                },
                new Customer
                {
                    CustomerName = "Olivia Brown",
                    Email = "olivia.brown@example.com",
                    LoggedInNo = false,
                    Password = "OliviaBrown2026!"
                },
                new Customer
                {
                    CustomerName = "Michael Davis",
                    Email = "michael.davis@example.com",
                    LoggedInNo = false,
                    Password = "MichaelDavis2026!"
                },
                new Customer
                {
                    CustomerName = "Sophia Martin",
                    Email = "sophia.martin@example.com",
                    LoggedInNo = false,
                    Password = "SophiaMartin2026!"
                },
                new Customer
                {
                    CustomerName = "James Anderson",
                    Email = "james.anderson@example.com",
                    LoggedInNo = false,
                    Password = "JamesAnderson2026!"
                },
                new Customer
                {
                    CustomerName = "Isabella Taylor",
                    Email = "isabella.taylor@example.com",
                    LoggedInNo = false,
                    Password = "IsabellaTaylor2026!"
                },
                new Customer
                {
                    CustomerName = "William Thomas",
                    Email = "william.thomas@example.com",
                    LoggedInNo = false,
                    Password = "WilliamThomas2026!"
                },
                new Customer
                {
                    CustomerName = "Ava Jackson",
                    Email = "ava.jackson@example.com",
                    LoggedInNo = false,
                    Password = "AvaJackson2026!"
                },
                new Customer
                {
                    CustomerName = "Benjamin White",
                    Email = "benjamin.white@example.com",
                    LoggedInNo = false,
                    Password = "BenjaminWhite2026!"
                },
                new Customer
                {
                    CustomerName = "Mia Harris",
                    Email = "mia.harris@example.com",
                    LoggedInNo = false,
                    Password = "MiaHarris2026!"
                },
                new Customer
                {
                    CustomerName = "Lucas Clark",
                    Email = "lucas.clark@example.com",
                    LoggedInNo = false,
                    Password = "LucasClark2026!"
                },
                new Customer
                {
                    CustomerName = "Charlotte Lewis",
                    Email = "charlotte.lewis@example.com",
                    LoggedInNo = false,
                    Password = "CharlotteLewis2026!"
                },
                new Customer
                {
                    CustomerName = "Henry Walker",
                    Email = "henry.walker@example.com",
                    LoggedInNo = false,
                    Password = "HenryWalker2026!"
                },
                new Customer
                {
                    CustomerName = "Amelia Hall",
                    Email = "amelia.hall@example.com",
                    LoggedInNo = false,
                    Password = "AmeliaHall2026!"
                },
                new Customer
                {
                    CustomerName = "Sebastian Allen",
                    Email = "sebastian.allen@example.com",
                    LoggedInNo = false,
                    Password = "SebastianAllen2026!"
                },
                new Customer
                {
                    CustomerName = "Harper Young",
                    Email = "harper.young@example.com",
                    LoggedInNo = false,
                    Password = "HarperYoung2026!"
                },
                new Customer
                {
                    CustomerName = "Jack Hernandez",
                    Email = "jack.hernandez@example.com",
                    LoggedInNo = false,
                    Password = "JackHernandez2026!"
                },
                new Customer
                {
                    CustomerName = "Evelyn King",
                    Email = "evelyn.king@example.com",
                    LoggedInNo = false,
                    Password = "EvelynKing2026!"
                },
                new Customer
                {
                    CustomerName = "Theodore Wright",
                    Email = "theodore.wright@example.com",
                    LoggedInNo = false,
                    Password = "TheodoreWright2026!"
                },
                new Customer
                {
                    CustomerName = "Abigail Lopez",
                    Email = "abigail.lopez@example.com",
                    LoggedInNo = false,
                    Password = "AbigailLopez2026!"
                },
                new Customer
                {
                    CustomerName = "Samuel Hill",
                    Email = "samuel.hill@example.com",
                    LoggedInNo = false,
                    Password = "SamuelHill2026!"
                },
                new Customer
                {
                    CustomerName = "Ella Scott",
                    Email = "ella.scott@example.com",
                    LoggedInNo = false,
                    Password = "EllaScott2026!"
                },
                new Customer
                {
                    CustomerName = "David Green",
                    Email = "david.green@example.com",
                    LoggedInNo = false,
                    Password = "DavidGreen2026!"
                },
                new Customer
                {
                    CustomerName = "Grace Adams",
                    Email = "grace.adams@example.com",
                    LoggedInNo = false,
                    Password = "GraceAdams2026!"
                },
                new Customer
                {
                    CustomerName = "Joseph Baker",
                    Email = "joseph.baker@example.com",
                    LoggedInNo = false,
                    Password = "JosephBaker2026!"
                },
                new Customer
                {
                    CustomerName = "Chloe Gonzalez",
                    Email = "chloe.gonzalez@example.com",
                    LoggedInNo = false,
                    Password = "ChloeGonzalez2026!"
                },
                new Customer
                {
                    CustomerName = "Matthew Nelson",
                    Email = "matthew.nelson@example.com",
                    LoggedInNo = false,
                    Password = "MatthewNelson2026!"
                },
                new Customer
                {
                    CustomerName = "Lily Carter",
                    Email = "lily.carter@example.com",
                    LoggedInNo = false,
                    Password = "LilyCarter2026!"
                },
                new Customer
                {
                    CustomerName = "Andrew Mitchell",
                    Email = "andrew.mitchell@example.com",
                    LoggedInNo = false,
                    Password = "AndrewMitchell2026!"
                },
                new Customer
                {
                    CustomerName = "Zoe Perez",
                    Email = "zoe.perez@example.com",
                    LoggedInNo = false,
                    Password = "ZoePerez2026!"
                },
                new Customer
                {
                    CustomerName = "Christopher Roberts",
                    Email = "christopher.roberts@example.com",
                    LoggedInNo = false,
                    Password = "ChristopherRoberts2026!"
                },
                new Customer
                {
                    CustomerName = "Natalie Turner",
                    Email = "natalie.turner@example.com",
                    LoggedInNo = false,
                    Password = "NatalieTurner2026!"
                },
                new Customer
                {
                    CustomerName = "Ryan Phillips",
                    Email = "ryan.phillips@example.com",
                    LoggedInNo = false,
                    Password = "RyanPhillips2026!"
                }
            };
            context.Customers.AddRange(customers);
            context.SaveChanges();
        }
        public static void SeedCars(ApplicationDbContext context)
        {
            var cars = new List<Car>
            {
                new Car { ReservationNo = true, CarModelId = 1 },
                new Car { ReservationNo = true, CarModelId = 2 },
                new Car { ReservationNo = true, CarModelId = 3 },
                new Car { ReservationNo = true, CarModelId = 4 },
                new Car { ReservationNo = true, CarModelId = 5 },
                new Car { ReservationNo = true, CarModelId = 6 },
                new Car { ReservationNo = true, CarModelId = 7 },
                new Car { ReservationNo = true, CarModelId = 8 },
                new Car { ReservationNo = true, CarModelId = 9 },
                new Car { ReservationNo = true, CarModelId = 10 },
                new Car { ReservationNo = true, CarModelId = 11 },
                new Car { ReservationNo = true, CarModelId = 12 },
                new Car { ReservationNo = true, CarModelId = 13 },
                new Car { ReservationNo = true, CarModelId = 14 },
                new Car { ReservationNo = true, CarModelId = 15 },
                new Car { ReservationNo = true, CarModelId = 16 },
                new Car { ReservationNo = true, CarModelId = 17 },
                new Car { ReservationNo = true, CarModelId = 18 },
                new Car { ReservationNo = true, CarModelId = 19 },
                new Car { ReservationNo = true, CarModelId = 20 },
                new Car { ReservationNo = true, CarModelId = 21 },
                new Car { ReservationNo = true, CarModelId = 22 },
                new Car { ReservationNo = true, CarModelId = 23 },
                new Car { ReservationNo = true, CarModelId = 24 },
                new Car { ReservationNo = true, CarModelId = 25 },
                new Car { ReservationNo = true, CarModelId = 26 },
                new Car { ReservationNo = true, CarModelId = 27 },
                new Car { ReservationNo = true, CarModelId = 28 },
                new Car { ReservationNo = true, CarModelId = 29 },
                new Car { ReservationNo = true, CarModelId = 30 },
                new Car { ReservationNo = true, CarModelId = 31 },
                new Car { ReservationNo = true, CarModelId = 32 },
                new Car { ReservationNo = true, CarModelId = 33 },
                new Car { ReservationNo = true, CarModelId = 34 },
                new Car { ReservationNo = true, CarModelId = 35 }
            };
            context.Cars.AddRange(cars);
            context.SaveChanges();
        }
        public static void SeedCarModels(ApplicationDbContext context)
        {
            var carModels = new List<CarModel>
            {
                new CarModel
                {
                    Name = "Toyota Yaris",
                    CarManufacturerId = 1,
                    TimePrice = 5.50m,
                    KmPrice = 0.25m
                },
                new CarModel
                {
                    Name = "Volkswagen Golf",
                    CarManufacturerId = 5,
                    TimePrice = 4.75m,
                    KmPrice = 0.30m
                },
                new CarModel
                {
                    Name = "Toyota RAV4",
                    CarManufacturerId = 1,
                    TimePrice = 7.25m,
                    KmPrice = 0.20m
                },
                new CarModel
                {
                    Name = "BMW 5 Series",
                    CarManufacturerId = 2,
                    TimePrice = 12.00m,
                    KmPrice = 0.45m
                },
                new CarModel
                {
                    Name = "Kia Rio",
                    CarManufacturerId = 9,
                    TimePrice = 4.50m,
                    KmPrice = 0.22m
                },
                new CarModel
                {
                    Name = "Skoda Octavia",
                    CarManufacturerId = 13,
                    TimePrice = 5.75m,
                    KmPrice = 0.28m
                },
                new CarModel
                {
                    Name = "Volvo XC60",
                    CarManufacturerId = 12,
                    TimePrice = 10.50m,
                    KmPrice = 0.40m
                },
                new CarModel
                {
                    Name = "Ford Focus",
                    CarManufacturerId = 7,
                    TimePrice = 4.80m,
                    KmPrice = 0.24m
                },
                new CarModel
                {
                    Name = "Tesla Model 3",
                    CarManufacturerId = 18,
                    TimePrice = 9.50m,
                    KmPrice = 0.18m
                },
                new CarModel
                {
                    Name = "Volkswagen Touran",
                    CarManufacturerId = 5,
                    TimePrice = 7.00m,
                    KmPrice = 0.32m
                },
                new CarModel
                {
                    Name = "Hyundai i20",
                    CarManufacturerId = 8,
                    TimePrice = 4.25m,
                    KmPrice = 0.21m
                },
                new CarModel
                {
                    Name = "Audi A4",
                    CarManufacturerId = 3,
                    TimePrice = 9.00m,
                    KmPrice = 0.38m
                },
                new CarModel
                {
                    Name = "Nissan Qashqai",
                    CarManufacturerId = 10,
                    TimePrice = 6.50m,
                    KmPrice = 0.29m
                },
                new CarModel
                {
                    Name = "Skoda Superb",
                    CarManufacturerId = 13,
                    TimePrice = 7.25m,
                    KmPrice = 0.33m
                },
                new CarModel
                {
                    Name = "Renault Clio",
                    CarManufacturerId = 14,
                    TimePrice = 4.00m,
                    KmPrice = 0.20m
                },
                new CarModel
                {
                    Name = "BMW X5",
                    CarManufacturerId = 2,
                    TimePrice = 14.00m,
                    KmPrice = 0.50m
                },
                new CarModel
                {
                    Name = "Toyota Corolla",
                    CarManufacturerId = 1,
                    TimePrice = 5.00m,
                    KmPrice = 0.25m
                },
                new CarModel
                {
                    Name = "Kia Sportage",
                    CarManufacturerId = 9,
                    TimePrice = 7.00m,
                    KmPrice = 0.32m
                },
                new CarModel
                {
                    Name = "Mercedes-Benz E-Class",
                    CarManufacturerId = 4,
                    TimePrice = 13.00m,
                    KmPrice = 0.48m
                },
                new CarModel
                {
                    Name = "Opel Astra",
                    CarManufacturerId = 16,
                    TimePrice = 4.50m,
                    KmPrice = 0.23m
                },
                new CarModel
                {
                    Name = "Nissan Leaf",
                    CarManufacturerId = 10,
                    TimePrice = 5.50m,
                    KmPrice = 0.17m
                },
                new CarModel
                {
                    Name = "BMW 4 Series",
                    CarManufacturerId = 2,
                    TimePrice = 12.50m,
                    KmPrice = 0.46m
                },
                new CarModel
                {
                    Name = "Toyota Aygo",
                    CarManufacturerId = 1,
                    TimePrice = 3.75m,
                    KmPrice = 0.18m
                },
                new CarModel
                {
                    Name = "Hyundai Santa Fe",
                    CarManufacturerId = 8,
                    TimePrice = 8.00m,
                    KmPrice = 0.35m
                },
                new CarModel
                {
                    Name = "Toyota C-HR",
                    CarManufacturerId = 1,
                    TimePrice = 6.00m,
                    KmPrice = 0.24m
                },
                new CarModel
                {
                    Name = "Tesla Model Y",
                    CarManufacturerId = 18,
                    TimePrice = 10.00m,
                    KmPrice = 0.20m
                },
                new CarModel
                {
                    Name = "Seat Leon",
                    CarManufacturerId = 5,
                    TimePrice = 4.75m,
                    KmPrice = 0.24m
                },
                new CarModel
                {
                    Name = "Mercedes-Benz Vito",
                    CarManufacturerId = 4,
                    TimePrice = 9.00m,
                    KmPrice = 0.40m
                },
                new CarModel
                {
                    Name = "Audi Q5",
                    CarManufacturerId = 3,
                    TimePrice = 10.00m,
                    KmPrice = 0.42m
                },
                new CarModel
                {
                    Name = "Dacia Sandero",
                    CarManufacturerId = 25,
                    TimePrice = 3.50m,
                    KmPrice = 0.19m
                },
                new CarModel
                {
                    Name = "Volkswagen Passat Variant",
                    CarManufacturerId = 5,
                    TimePrice = 6.50m,
                    KmPrice = 0.30m
                },
                new CarModel
                {
                    Name = "Porsche 911",
                    CarManufacturerId = 19,
                    TimePrice = 25.00m,
                    KmPrice = 0.75m
                },
                new CarModel
                {
                    Name = "Toyota Camry",
                    CarManufacturerId = 1,
                    TimePrice = 7.00m,
                    KmPrice = 0.28m
                },
                new CarModel
                {
                    Name = "Mercedes-Benz GLE",
                    CarManufacturerId = 4,
                    TimePrice = 14.50m,
                    KmPrice = 0.52m
                },
                new CarModel
                {
                    Name = "Volkswagen ID.3",
                    CarManufacturerId = 5,
                    TimePrice = 6.00m,
                    KmPrice = 0.18m
                }
            };
            context.CarModels.AddRange(carModels);
            context.SaveChanges();
        }
        public static void SeedCarManufacturers(ApplicationDbContext context)
        {
            var carManufacturers = new List<CarManufacturer>
            {
                new CarManufacturer { Name = "Toyota" },
                new CarManufacturer { Name = "BMW" },
                new CarManufacturer { Name = "Audi" },
                new CarManufacturer { Name = "Mercedes-Benz" },
                new CarManufacturer { Name = "Volkswagen" },
                new CarManufacturer { Name = "Honda" },
                new CarManufacturer { Name = "Ford" },
                new CarManufacturer { Name = "Hyundai" },
                new CarManufacturer { Name = "Kia" },
                new CarManufacturer { Name = "Nissan" },
                new CarManufacturer { Name = "Mazda" },
                new CarManufacturer { Name = "Volvo" },
                new CarManufacturer { Name = "Skoda" },
                new CarManufacturer { Name = "Renault" },
                new CarManufacturer { Name = "Peugeot" },
                new CarManufacturer { Name = "Opel" },
                new CarManufacturer { Name = "Subaru" },
                new CarManufacturer { Name = "Tesla" },
                new CarManufacturer { Name = "Porsche" },
                new CarManufacturer { Name = "Lexus" },
                new CarManufacturer { Name = "Fiat" },
                new CarManufacturer { Name = "Jeep" },
                new CarManufacturer { Name = "Land Rover" },
                new CarManufacturer { Name = "Mitsubishi" },
                new CarManufacturer { Name = "Dacia" },
                new CarManufacturer { Name = "Chevrolet" },
                new CarManufacturer { Name = "Jaguar" },
                new CarManufacturer { Name = "Alfa Romeo" },
                new CarManufacturer { Name = "Mini" },
                new CarManufacturer { Name = "Suzuki" },
                new CarManufacturer { Name = "Cupra" },
                new CarManufacturer { Name = "BYD" },
                new CarManufacturer { Name = "Polestar" },
                new CarManufacturer { Name = "Genesis" },
                new CarManufacturer { Name = "Lucid" }
            };
            context.CarManufacturers.AddRange(carManufacturers);
            context.SaveChanges();
        }
        public static void SeedReservations(ApplicationDbContext context)
        {
            var reservations = new List<Reservation>
            {
                new Reservation
                {
                    StartTime = new DateTime(2026, 1, 5, 9, 0, 0),
                    EndTime = new DateTime(2026, 1, 5, 13, 0, 0),
                    StartKm = 12500,
                    EndKm = 12620,
                    TimePrice = 5.50m,
                    KmPrice = 0.25m,
                    CarId = 1,
                    CustomerId = 1
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 1, 8, 10, 30, 0),
                    EndTime = new DateTime(2026, 1, 9, 10, 30, 0),
                    StartKm = 28400,
                    EndKm = 28610,
                    TimePrice = 4.75m,
                    KmPrice = 0.30m,
                    CarId = 2,
                    CustomerId = 2
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 1, 12, 8, 0, 0),
                    EndTime = new DateTime(2026, 1, 14, 8, 0, 0),
                    StartKm = 45120,
                    EndKm = 45680,
                    TimePrice = 7.25m,
                    KmPrice = 0.20m,
                    CarId = 3,
                    CustomerId = 3
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 1, 15, 14, 0, 0),
                    EndTime = new DateTime(2026, 1, 15, 19, 0, 0),
                    StartKm = 18700,
                    EndKm = 18890,
                    TimePrice = 6.00m,
                    KmPrice = 0.28m,
                    CarId = 4,
                    CustomerId = 4
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 1, 20, 9, 15, 0),
                    EndTime = new DateTime(2026, 1, 22, 9, 15, 0),
                    StartKm = 63200,
                    EndKm = 63850,
                    TimePrice = 8.50m,
                    KmPrice = 0.35m,
                    CarId = 5,
                    CustomerId = 5
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 2, 2, 11, 0, 0),
                    EndTime = new DateTime(2026, 2, 2, 17, 0, 0),
                    StartKm = 31200,
                    EndKm = 31340,
                    TimePrice = 5.25m,
                    KmPrice = 0.22m,
                    CarId = 6,
                    CustomerId = 6
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 2, 5, 8, 30, 0),
                    EndTime = new DateTime(2026, 2, 8, 8, 30, 0),
                    StartKm = 74500,
                    EndKm = 75220,
                    TimePrice = 9.00m,
                    KmPrice = 0.40m,
                    CarId = 7,
                    CustomerId = 7
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 2, 9, 12, 0, 0),
                    EndTime = new DateTime(2026, 2, 9, 16, 30, 0),
                    StartKm = 21800,
                    EndKm = 21930,
                    TimePrice = 4.50m,
                    KmPrice = 0.25m,
                    CarId = 8,
                    CustomerId = 8
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 2, 13, 9, 0, 0),
                    EndTime = new DateTime(2026, 2, 14, 18, 0, 0),
                    StartKm = 39600,
                    EndKm = 39980,
                    TimePrice = 6.75m,
                    KmPrice = 0.32m,
                    CarId = 9,
                    CustomerId = 9
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 2, 18, 10, 0, 0),
                    EndTime = new DateTime(2026, 2, 21, 10, 0, 0),
                    StartKm = 85200,
                    EndKm = 86100,
                    TimePrice = 7.80m,
                    KmPrice = 0.27m,
                    CarId = 10,
                    CustomerId = 10
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 3, 1, 8, 0, 0),
                    EndTime = new DateTime(2026, 3, 1, 12, 0, 0),
                    StartKm = 15400,
                    EndKm = 15510,
                    TimePrice = 5.00m,
                    KmPrice = 0.24m,
                    CarId = 11,
                    CustomerId = 11
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 3, 4, 13, 30, 0),
                    EndTime = new DateTime(2026, 3, 6, 13, 30, 0),
                    StartKm = 52700,
                    EndKm = 53280,
                    TimePrice = 8.25m,
                    KmPrice = 0.36m,
                    CarId = 12,
                    CustomerId = 12
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 3, 8, 9, 0, 0),
                    EndTime = new DateTime(2026, 3, 8, 20, 0, 0),
                    StartKm = 26300,
                    EndKm = 26620,
                    TimePrice = 5.80m,
                    KmPrice = 0.29m,
                    CarId = 13,
                    CustomerId = 13
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 3, 12, 10, 0, 0),
                    EndTime = new DateTime(2026, 3, 15, 10, 0, 0),
                    StartKm = 91800,
                    EndKm = 92750,
                    TimePrice = 9.50m,
                    KmPrice = 0.38m,
                    CarId = 14,
                    CustomerId = 14
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 3, 17, 8, 45, 0),
                    EndTime = new DateTime(2026, 3, 17, 15, 45, 0),
                    StartKm = 34100,
                    EndKm = 34310,
                    TimePrice = 4.90m,
                    KmPrice = 0.23m,
                    CarId = 15,
                    CustomerId = 15
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 3, 21, 11, 0, 0),
                    EndTime = new DateTime(2026, 3, 23, 11, 0, 0),
                    StartKm = 67400,
                    EndKm = 68020,
                    TimePrice = 7.60m,
                    KmPrice = 0.31m,
                    CarId = 16,
                    CustomerId = 16
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 4, 2, 9, 30, 0),
                    EndTime = new DateTime(2026, 4, 2, 18, 30, 0),
                    StartKm = 19800,
                    EndKm = 20050,
                    TimePrice = 5.40m,
                    KmPrice = 0.26m,
                    CarId = 17,
                    CustomerId = 17
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 4, 6, 8, 0, 0),
                    EndTime = new DateTime(2026, 4, 10, 8, 0, 0),
                    StartKm = 103200,
                    EndKm = 104450,
                    TimePrice = 8.90m,
                    KmPrice = 0.34m,
                    CarId = 18,
                    CustomerId = 18
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 4, 10, 12, 0, 0),
                    EndTime = new DateTime(2026, 4, 10, 17, 0, 0),
                    StartKm = 47200,
                    EndKm = 47360,
                    TimePrice = 6.20m,
                    KmPrice = 0.21m,
                    CarId = 19,
                    CustomerId = 19
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 4, 14, 9, 0, 0),
                    EndTime = new DateTime(2026, 4, 16, 9, 0, 0),
                    StartKm = 58600,
                    EndKm = 59180,
                    TimePrice = 7.10m,
                    KmPrice = 0.33m,
                    CarId = 20,
                    CustomerId = 20
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 4, 19, 10, 0, 0),
                    EndTime = new DateTime(2026, 4, 19, 14, 0, 0),
                    StartKm = 22600,
                    EndKm = 22720,
                    TimePrice = 4.80m,
                    KmPrice = 0.25m,
                    CarId = 21,
                    CustomerId = 21
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 4, 23, 8, 30, 0),
                    EndTime = new DateTime(2026, 4, 26, 8, 30, 0),
                    StartKm = 79200,
                    EndKm = 80150,
                    TimePrice = 9.20m,
                    KmPrice = 0.37m,
                    CarId = 22,
                    CustomerId = 22
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 5, 3, 9, 0, 0),
                    EndTime = new DateTime(2026, 5, 3, 18, 0, 0),
                    StartKm = 31500,
                    EndKm = 31780,
                    TimePrice = 5.60m,
                    KmPrice = 0.28m,
                    CarId = 23,
                    CustomerId = 23
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 5, 7, 10, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 10, 0, 0),
                    StartKm = 118400,
                    EndKm = 119720,
                    TimePrice = 8.40m,
                    KmPrice = 0.30m,
                    CarId = 24,
                    CustomerId = 24
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 5, 11, 13, 0, 0),
                    EndTime = new DateTime(2026, 5, 11, 19, 0, 0),
                    StartKm = 38200,
                    EndKm = 38410,
                    TimePrice = 5.15m,
                    KmPrice = 0.24m,
                    CarId = 25,
                    CustomerId = 25
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 5, 16, 8, 0, 0),
                    EndTime = new DateTime(2026, 5, 19, 8, 0, 0),
                    StartKm = 64700,
                    EndKm = 65580,
                    TimePrice = 7.90m,
                    KmPrice = 0.35m,
                    CarId = 26,
                    CustomerId = 26
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 6, 1, 9, 0, 0),
                    EndTime = new DateTime(2026, 6, 1, 16, 0, 0),
                    StartKm = 17400,
                    EndKm = 17610,
                    TimePrice = 4.65m,
                    KmPrice = 0.22m,
                    CarId = 27,
                    CustomerId = 27
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 6, 5, 11, 0, 0),
                    EndTime = new DateTime(2026, 6, 8, 11, 0, 0),
                    StartKm = 93400,
                    EndKm = 94280,
                    TimePrice = 8.70m,
                    KmPrice = 0.39m,
                    CarId = 28,
                    CustomerId = 28
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 6, 10, 8, 30, 0),
                    EndTime = new DateTime(2026, 6, 10, 13, 30, 0),
                    StartKm = 42800,
                    EndKm = 42940,
                    TimePrice = 6.10m,
                    KmPrice = 0.27m,
                    CarId = 29,
                    CustomerId = 29
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 7, 2, 10, 0, 0),
                    EndTime = new DateTime(2026, 7, 6, 10, 0, 0),
                    StartKm = 108500,
                    EndKm = 109820,
                    TimePrice = 9.10m,
                    KmPrice = 0.32m,
                    CarId = 30,
                    CustomerId = 30
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 7, 8, 9, 0, 0),
                    EndTime = new DateTime(2026, 7, 8, 18, 0, 0),
                    StartKm = 29100,
                    EndKm = 29370,
                    TimePrice = 5.35m,
                    KmPrice = 0.26m,
                    CarId = 31,
                    CustomerId = 31
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 8, 12, 8, 0, 0),
                    EndTime = new DateTime(2026, 8, 15, 8, 0, 0),
                    StartKm = 71600,
                    EndKm = 72550,
                    TimePrice = 8.60m,
                    KmPrice = 0.36m,
                    CarId = 32,
                    CustomerId = 32
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 8, 18, 12, 0, 0),
                    EndTime = new DateTime(2026, 8, 18, 17, 0, 0),
                    StartKm = 23900,
                    EndKm = 24060,
                    TimePrice = 4.95m,
                    KmPrice = 0.23m,
                    CarId = 33,
                    CustomerId = 33
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 9, 18, 9, 0, 0),
                    EndTime = new DateTime(2026, 9, 21, 9, 0, 0),
                    StartKm = 86400,
                    EndKm = 87280,
                    TimePrice = 9.40m,
                    KmPrice = 0.34m,
                    CarId = 34,
                    CustomerId = 34
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 1, 9, 0, 0),
                    EndTime = new DateTime(2026, 10, 1, 12, 0, 0),
                    StartKm = 12500,
                    EndKm = 12580,
                    TimePrice = 5.75m,
                    KmPrice = 0.25m,
                    CarId = 35,
                    CustomerId = 35
                }
            };
            context.Reservations.AddRange(reservations);
            context.SaveChanges();
        }
        public static void SeedInvoices(ApplicationDbContext context)
        {
            var invoices = new List<Invoice>
            {
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 1, 5, 9, 15, 0),
                    DueTime = new DateTime(2026, 1, 19, 23, 59, 59),
                    Paid = true,
                    CustomerId = 1
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 1, 8, 11, 42, 18),
                    DueTime = new DateTime(2026, 2, 7, 17, 0, 0),
                    Paid = false,
                    CustomerId = 2
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 1, 12, 14, 8, 35),
                    DueTime = new DateTime(2026, 1, 26, 23, 59, 59),
                    Paid = true,
                    CustomerId = 3
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 1, 15, 10, 25, 12),
                    DueTime = new DateTime(2026, 2, 14, 18, 0, 0),
                    Paid = false,
                    CustomerId = 4
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 1, 20, 16, 37, 49),
                    DueTime = new DateTime(2026, 2, 3, 23, 59, 59),
                    Paid = true,
                    CustomerId = 5
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 1, 24, 8, 52, 6),
                    DueTime = new DateTime(2026, 2, 23, 17, 30, 0),
                    Paid = false,
                    CustomerId = 6
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 2, 2, 13, 18, 27),
                    DueTime = new DateTime(2026, 2, 16, 23, 59, 59),
                    Paid = true,
                    CustomerId = 7
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 2, 5, 15, 44, 51),
                    DueTime = new DateTime(2026, 3, 7, 16, 0, 0),
                    Paid = false,
                    CustomerId = 8
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 2, 9, 9, 6, 42),
                    DueTime = new DateTime(2026, 2, 23, 23, 59, 59),
                    Paid = true,
                    CustomerId = 9
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 2, 13, 12, 31, 15),
                    DueTime = new DateTime(2026, 3, 15, 17, 0, 0),
                    Paid = false,
                    CustomerId = 10
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 2, 18, 10, 12, 8),
                    DueTime = new DateTime(2026, 3, 4, 23, 59, 59),
                    Paid = true,
                    CustomerId = 11
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 2, 22, 17, 5, 33),
                    DueTime = new DateTime(2026, 3, 24, 18, 0, 0),
                    Paid = false,
                    CustomerId = 12
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 3, 1, 8, 45, 20),
                    DueTime = new DateTime(2026, 3, 15, 23, 59, 59),
                    Paid = true,
                    CustomerId = 13
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 3, 4, 14, 22, 47),
                    DueTime = new DateTime(2026, 4, 3, 17, 0, 0),
                    Paid = false,
                    CustomerId = 14
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 3, 8, 11, 9, 14),
                    DueTime = new DateTime(2026, 3, 22, 23, 59, 59),
                    Paid = true,
                    CustomerId = 15
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 3, 12, 16, 53, 2),
                    DueTime = new DateTime(2026, 4, 11, 18, 30, 0),
                    Paid = false,
                    CustomerId = 16
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 3, 17, 9, 34, 56),
                    DueTime = new DateTime(2026, 3, 31, 23, 59, 59),
                    Paid = true,
                    CustomerId = 17
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 3, 21, 13, 47, 21),
                    DueTime = new DateTime(2026, 4, 20, 17, 0, 0),
                    Paid = false,
                    CustomerId = 18
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 4, 2, 10, 16, 39),
                    DueTime = new DateTime(2026, 4, 16, 23, 59, 59),
                    Paid = true,
                    CustomerId = 19
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 4, 6, 15, 28, 4),
                    DueTime = new DateTime(2026, 5, 6, 17, 0, 0),
                    Paid = false,
                    CustomerId = 20
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 4, 10, 8, 57, 43),
                    DueTime = new DateTime(2026, 4, 24, 23, 59, 59),
                    Paid = true,
                    CustomerId = 21
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 4, 14, 12, 41, 26),
                    DueTime = new DateTime(2026, 5, 14, 18, 0, 0),
                    Paid = false,
                    CustomerId = 22
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 4, 19, 14, 3, 17),
                    DueTime = new DateTime(2026, 5, 3, 23, 59, 59),
                    Paid = true,
                    CustomerId = 23
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 4, 23, 9, 26, 48),
                    DueTime = new DateTime(2026, 5, 23, 17, 0, 0),
                    Paid = false,
                    CustomerId = 24
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 5, 3, 11, 38, 9),
                    DueTime = new DateTime(2026, 5, 17, 23, 59, 59),
                    Paid = true,
                    CustomerId = 25
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 5, 7, 16, 19, 52),
                    DueTime = new DateTime(2026, 6, 6, 17, 0, 0),
                    Paid = false,
                    CustomerId = 26
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 5, 11, 10, 48, 31),
                    DueTime = new DateTime(2026, 5, 25, 23, 59, 59),
                    Paid = true,
                    CustomerId = 27
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 5, 16, 13, 7, 45),
                    DueTime = new DateTime(2026, 6, 15, 18, 0, 0),
                    Paid = false,
                    CustomerId = 28
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 6, 1, 9, 21, 13),
                    DueTime = new DateTime(2026, 6, 15, 23, 59, 59),
                    Paid = true,
                    CustomerId = 29
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 6, 5, 14, 56, 38),
                    DueTime = new DateTime(2026, 7, 5, 17, 0, 0),
                    Paid = false,
                    CustomerId = 30
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 6, 10, 11, 32, 5),
                    DueTime = new DateTime(2026, 6, 24, 23, 59, 59),
                    Paid = true,
                    CustomerId = 31
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 7, 2, 15, 14, 29),
                    DueTime = new DateTime(2026, 7, 16, 17, 0, 0),
                    Paid = false,
                    CustomerId = 32
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 8, 12, 10, 5, 44),
                    DueTime = new DateTime(2026, 8, 26, 23, 59, 59),
                    Paid = true,
                    CustomerId = 33
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 9, 18, 13, 49, 16),
                    DueTime = new DateTime(2026, 10, 18, 17, 0, 0),
                    Paid = false,
                    CustomerId = 34
                },
                new Invoice
                {
                    InvoiceDate = new DateTime(2026, 10, 2, 14, 30, 0),
                    DueTime = new DateTime(2026, 10, 16, 23, 59, 59),
                    Paid = true,
                    CustomerId = 35
                }
            };
            context.Invoices.AddRange(invoices);
            context.SaveChanges();
        }
        public static void SeedInvoiceLines(ApplicationDbContext context)
        {
            var invoiceLines = new List<InvoiceLine>
            {
                new InvoiceLine
                {
                    Description = "Economy car rental - Toyota Yaris, 3 days",
                    Total = 105.00m,
                    ReservationId = 1
                },
                new InvoiceLine
                {
                    Description = "Compact car rental - Volkswagen Golf, 5 days",
                    Total = 225.00m,
                    ReservationId = 2
                },
                new InvoiceLine
                {
                    Description = "SUV rental - Toyota RAV4, 4 days",
                    Total = 320.00m,
                    ReservationId = 3
                },
                new InvoiceLine
                {
                    Description = "Luxury sedan rental - BMW 5 Series, 2 days",
                    Total = 260.00m,
                    ReservationId = 4
                },
                new InvoiceLine
                {
                    Description = "Economy car rental - Kia Rio, 7 days",
                    Total = 210.00m,
                    ReservationId = 5
                },
                new InvoiceLine
                {
                    Description = "Family car rental - Skoda Octavia, 5 days",
                    Total = 275.00m,
                    ReservationId = 6
                },
                new InvoiceLine
                {
                    Description = "Premium SUV rental - Volvo XC60, 3 days",
                    Total = 345.00m,
                    ReservationId = 7
                },
                new InvoiceLine
                {
                    Description = "Compact car rental - Ford Focus, 4 days",
                    Total = 168.00m,
                    ReservationId = 8
                },
                new InvoiceLine
                {
                    Description = "Electric car rental - Tesla Model 3, 2 days",
                    Total = 190.00m,
                    ReservationId = 9
                },
                new InvoiceLine
                {
                    Description = "Minivan rental - Volkswagen Touran, 6 days",
                    Total = 390.00m,
                    ReservationId = 10
                },
                new InvoiceLine
                {
                    Description = "Economy car rental - Hyundai i20, 2 days",
                    Total = 64.00m,
                    ReservationId = 11
                },
                new InvoiceLine
                {
                    Description = "Business sedan rental - Audi A4, 4 days",
                    Total = 360.00m,
                    ReservationId = 12
                },
                new InvoiceLine
                {
                    Description = "Compact SUV rental - Nissan Qashqai, 3 days",
                    Total = 210.00m,
                    ReservationId = 13
                },
                new InvoiceLine
                {
                    Description = "Station wagon rental - Skoda Superb, 5 days",
                    Total = 325.00m,
                    ReservationId = 14
                },
                new InvoiceLine
                {
                    Description = "Economy car rental - Renault Clio, 6 days",
                    Total = 174.00m,
                    ReservationId = 15
                },
                new InvoiceLine
                {
                    Description = "Luxury SUV rental - BMW X5, 2 days",
                    Total = 310.00m,
                    ReservationId = 16
                },
                new InvoiceLine
                {
                    Description = "Hybrid car rental - Toyota Corolla, 4 days",
                    Total = 196.00m,
                    ReservationId = 17
                },
                new InvoiceLine
                {
                    Description = "Family SUV rental - Kia Sportage, 7 days",
                    Total = 420.00m,
                    ReservationId = 18
                },
                new InvoiceLine
                {
                    Description = "Premium sedan rental - Mercedes-Benz E-Class, 3 days",
                    Total = 390.00m,
                    ReservationId = 19
                },
                new InvoiceLine
                {
                    Description = "Compact car rental - Opel Astra, 5 days",
                    Total = 200.00m,
                    ReservationId = 20
                },
                new InvoiceLine
                {
                    Description = "Electric car rental - Nissan Leaf, 3 days",
                    Total = 165.00m,
                    ReservationId = 21
                },
                new InvoiceLine
                {
                    Description = "Convertible rental - BMW 4 Series, 2 days",
                    Total = 280.00m,
                    ReservationId = 22
                },
                new InvoiceLine
                {
                    Description = "Economy car rental - Toyota Aygo, 4 days",
                    Total = 112.00m,
                    ReservationId = 23
                },
                new InvoiceLine
                {
                    Description = "Large SUV rental - Hyundai Santa Fe, 5 days",
                    Total = 375.00m,
                    ReservationId = 24
                },
                new InvoiceLine
                {
                    Description = "Hybrid SUV rental - Toyota C-HR, 3 days",
                    Total = 195.00m,
                    ReservationId = 25
                },
                new InvoiceLine
                {
                    Description = "Premium electric car rental - Tesla Model Y, 4 days",
                    Total = 340.00m,
                    ReservationId = 26
                },
                new InvoiceLine
                {
                    Description = "Compact car rental - Seat Leon, 2 days",
                    Total = 84.00m,
                    ReservationId = 27
                },
                new InvoiceLine
                {
                    Description = "Passenger van rental - Mercedes-Benz Vito, 3 days",
                    Total = 330.00m,
                    ReservationId = 28
                },
                new InvoiceLine
                {
                    Description = "Business SUV rental - Audi Q5, 4 days",
                    Total = 360.00m,
                    ReservationId = 29
                },
                new InvoiceLine
                {
                    Description = "Economy car rental - Dacia Sandero, 7 days",
                    Total = 175.00m,
                    ReservationId = 30
                },
                new InvoiceLine
                {
                    Description = "Family estate car rental - Volkswagen Passat Variant, 5 days",
                    Total = 300.00m,
                    ReservationId = 31
                },
                new InvoiceLine
                {
                    Description = "Premium sports car rental - Porsche 911, 1 day",
                    Total = 450.00m,
                    ReservationId = 32
                },
                new InvoiceLine
                {
                    Description = "Hybrid sedan rental - Toyota Camry, 6 days",
                    Total = 330.00m,
                    ReservationId = 33
                },
                new InvoiceLine
                {
                    Description = "Luxury SUV rental - Mercedes-Benz GLE, 3 days",
                    Total = 420.00m,
                    ReservationId = 34
                },
                new InvoiceLine
                {
                    Description = "Compact electric car rental - Volkswagen ID.3, 5 days",
                    Total = 250.00m,
                    ReservationId = 35
                }
            };
            context.InvoiceLines.AddRange(invoiceLines);
            context.SaveChanges();
        }
    }
}
