using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
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
            SeedCars(context);
            SeedCarModels(context);
            SeedCarManufacturers(context);
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
        }
        public static void SeedCarModels(ApplicationDbContext context)
        {
            var carModels = new List<CarModel>
            {   
                new CarModel
                {
                    Name = "Toyota Corolla",
                    CarManufacturerId = 1,
                    TimePrice = 5,
                    KmPrice = 20
                },
                new CarModel
                {
                    Name = "BMW 320i",
                    CarManufacturerId = 2,
                    TimePrice = 12,
                    KmPrice = 35
                },
                new CarModel
                {
                    Name = "Audi A4",
                    CarManufacturerId = 3,
                    TimePrice = 11,
                    KmPrice = 32
                },
                new CarModel
                {
                    Name = "Mercedes C-Class",
                    CarManufacturerId = 4,
                    TimePrice = 14,
                    KmPrice = 40
                },
                new CarModel
                {
                    Name = "Volkswagen Golf",
                    CarManufacturerId = 5,
                    TimePrice = 6,
                    KmPrice = 22
                },
                new CarModel
                {
                    Name = "Honda Civic",
                    CarManufacturerId = 6,
                    TimePrice = 6,
                    KmPrice = 22
                },
                new CarModel
                {
                    Name = "Ford Focus",
                    CarManufacturerId = 7,
                    TimePrice = 5,
                    KmPrice = 20
                },
                new CarModel
                {
                    Name = "Hyundai Tucson",
                    CarManufacturerId = 8,
                    TimePrice = 9,
                    KmPrice = 28
                },
                new CarModel
                {
                    Name = "Kia Sportage",
                    CarManufacturerId = 9,
                    TimePrice = 9,
                    KmPrice = 28
                },
                new CarModel
                {
                    Name = "Nissan Qashqai",
                    CarManufacturerId = 10,
                    TimePrice = 8,
                    KmPrice = 26
                },
                new CarModel
                {
                    Name = "Mazda CX-5",
                    CarManufacturerId = 11,
                    TimePrice = 9,
                    KmPrice = 29
                },
                new CarModel
                {
                    Name = "Volvo XC60",
                    CarManufacturerId = 12,
                    TimePrice = 15,
                    KmPrice = 42
                },
                new CarModel
                {
                    Name = "Skoda Octavia",
                    CarManufacturerId = 13,
                    TimePrice = 6,
                    KmPrice = 22
                },
                new CarModel
                {
                    Name = "Renault Clio",
                    CarManufacturerId = 14,
                    TimePrice = 4,
                    KmPrice = 17
                },
                new CarModel
                {
                    Name = "Peugeot 3008",
                    CarManufacturerId = 15,
                    TimePrice = 8,
                    KmPrice = 27
                },
                new CarModel
                {
                    Name = "Opel Astra",
                    CarManufacturerId = 16,
                    TimePrice = 5,
                    KmPrice = 20
                },
                new CarModel
                {
                    Name = "Subaru Forester",
                    CarManufacturerId = 17,
                    TimePrice = 10,
                    KmPrice = 32
                },
                new CarModel
                {
                    Name = "Tesla Model 3",
                    CarManufacturerId = 18,
                    TimePrice = 13,
                    KmPrice = 35
                },
                new CarModel
                {
                    Name = "Porsche Cayenne",
                    CarManufacturerId = 19,
                    TimePrice = 25,
                    KmPrice = 70
                },
                new CarModel
                {
                    Name = "Lexus IS",
                    CarManufacturerId = 20,
                    TimePrice = 14,
                    KmPrice = 40
                },
                new CarModel
                {
                    Name = "Fiat 500",
                    CarManufacturerId = 21,
                    TimePrice = 4,
                    KmPrice = 16
                },
                new CarModel
                {
                    Name = "Jeep Wrangler",
                    CarManufacturerId = 22,
                    TimePrice = 18,
                    KmPrice = 50
                },
                new CarModel
                {
                    Name = "Land Rover Defender",
                    CarManufacturerId = 23,
                    TimePrice = 22,
                    KmPrice = 65
                },
                new CarModel
                {
                    Name = "Mitsubishi Outlander",
                    CarManufacturerId = 24,
                    TimePrice = 9,
                    KmPrice = 30
                },
                new CarModel
                {
                    Name = "Dacia Duster",
                    CarManufacturerId = 25,
                    TimePrice = 5,
                    KmPrice = 20
                },
                new CarModel
                {
                    Name = "Chevrolet Camaro",
                    CarManufacturerId = 26,
                    TimePrice = 20,
                    KmPrice = 60
                },
                new CarModel
                {
                    Name = "Jaguar XE",
                    CarManufacturerId = 27,
                    TimePrice = 16,
                    KmPrice = 45
                },
                new CarModel
                {
                    Name = "Alfa Romeo Giulia",
                    CarManufacturerId = 28,
                    TimePrice = 15,
                    KmPrice = 42
                },
                new CarModel
                {
                    Name = "Mini Cooper",
                    CarManufacturerId = 29,
                    TimePrice = 7,
                    KmPrice = 24
                },
                new CarModel
                {
                    Name = "Suzuki Vitara",
                    CarManufacturerId = 30,
                    TimePrice = 6,
                    KmPrice = 23
                },
                new CarModel
                {
                    Name = "Cupra Formentor",
                    CarManufacturerId = 31,
                    TimePrice = 12,
                    KmPrice = 36
                },
                new CarModel
                {
                    Name = "BYD Seal",
                    CarManufacturerId = 32,
                    TimePrice = 12,
                    KmPrice = 34
                },
                new CarModel
                {
                    Name = "Polestar 2",
                    CarManufacturerId = 33,
                    TimePrice = 14,
                    KmPrice = 38
                },
                new CarModel
                {
                    Name = "Genesis G70",
                    CarManufacturerId = 34,
                    TimePrice = 17,
                    KmPrice = 48
                },
                new CarModel
                {
                    Name = "Lucid Air",
                    CarManufacturerId = 35,
                    TimePrice = 25,
                    KmPrice = 65
                }
            };
        }
        public static void SeedCarManufacturers(ApplicationDbContext context)
        {
            var carManufacturer = new List<CarManufacturer>
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
        }
        public static void SeedReservations(ApplicationDbContext context)
        {
            var reservation = new List<Reservation>
            {
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 1, 9, 0, 0),
                    EndTime = new DateTime(2026, 10, 1, 12, 0, 0),
                    StartKm = 12500,
                    EndKm = 12580,
                    TimePrice = 5,
                    KmPrice = 20,
                    CarId = 1,
                    CustomerId = 1
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 2, 10, 0, 0),
                    EndTime = new DateTime(2026, 10, 2, 14, 0, 0),
                    StartKm = 18200,
                    EndKm = 18350,
                    TimePrice = 12,
                    KmPrice = 35,
                    CarId = 2,
                    CustomerId = 2
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 3, 8, 0, 0),
                    EndTime = new DateTime(2026, 10, 3, 11, 0, 0),
                    StartKm = 24500,
                    EndKm = 24620,
                    TimePrice = 11,
                    KmPrice = 32,
                    CarId = 3,
                    CustomerId = 3
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 4, 12, 0, 0),
                    EndTime = new DateTime(2026, 10, 4, 16, 0, 0),
                    StartKm = 31000,
                    EndKm = 31180,
                    TimePrice = 14,
                    KmPrice = 40,
                    CarId = 4,
                    CustomerId = 4
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 5, 9, 0, 0),
                    EndTime = new DateTime(2026, 10, 5, 13, 0, 0),
                    StartKm = 15600,
                    EndKm = 15700,
                    TimePrice = 6,
                    KmPrice = 22,
                    CarId = 5,
                    CustomerId = 5
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 6, 11, 0, 0),
                    EndTime = new DateTime(2026, 10, 6, 15, 0, 0),
                    StartKm = 22100,
                    EndKm = 22240,
                    TimePrice = 6,
                    KmPrice = 22,
                    CarId = 6,
                    CustomerId = 6
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 7, 8, 30, 0),
                    EndTime = new DateTime(2026, 10, 7, 10, 30, 0),
                    StartKm = 19800,
                    EndKm = 19890,
                    TimePrice = 5,
                    KmPrice = 20,
                    CarId = 7,
                    CustomerId = 7
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 8, 10, 0, 0),
                    EndTime = new DateTime(2026, 10, 8, 17, 0, 0),
                    StartKm = 28500,
                    EndKm = 28700,
                    TimePrice = 9,
                    KmPrice = 28,
                    CarId = 8,
                    CustomerId = 8
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 9, 9, 0, 0),
                    EndTime = new DateTime(2026, 10, 9, 12, 0, 0),
                    StartKm = 33200,
                    EndKm = 33320,
                    TimePrice = 9,
                    KmPrice = 28,
                    CarId = 9,
                    CustomerId = 9
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 10, 13, 0, 0),
                    EndTime = new DateTime(2026, 10, 10, 18, 0, 0),
                    StartKm = 17400,
                    EndKm = 17600,
                    TimePrice = 8,
                    KmPrice = 26,
                    CarId = 10,
                    CustomerId = 10
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 11, 8, 0, 0),
                    EndTime = new DateTime(2026, 10, 11, 12, 0, 0),
                    StartKm = 26700,
                    EndKm = 26850,
                    TimePrice = 9,
                    KmPrice = 29,
                    CarId = 11,
                    CustomerId = 11
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 12, 10, 0, 0),
                    EndTime = new DateTime(2026, 10, 12, 16, 0, 0),
                    StartKm = 41200,
                    EndKm = 41400,
                    TimePrice = 15,
                    KmPrice = 42,
                    CarId = 12,
                    CustomerId = 12
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 13, 9, 0, 0),
                    EndTime = new DateTime(2026, 10, 13, 13, 0, 0),
                    StartKm = 14300,
                    EndKm = 14450,
                    TimePrice = 6,
                    KmPrice = 22,
                    CarId = 13,
                    CustomerId = 13
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 14, 11, 0, 0),
                    EndTime = new DateTime(2026, 10, 14, 14, 0, 0),
                    StartKm = 9600,
                    EndKm = 9690,
                    TimePrice = 4,
                    KmPrice = 17,
                    CarId = 14,
                    CustomerId = 14
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 15, 8, 0, 0),
                    EndTime = new DateTime(2026, 10, 15, 12, 0, 0),
                    StartKm = 23800,
                    EndKm = 23950,
                    TimePrice = 8,
                    KmPrice = 27,
                    CarId = 15,
                    CustomerId = 15
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 16, 14, 0, 0),
                    EndTime = new DateTime(2026, 10, 16, 17, 0, 0),
                    StartKm = 16700,
                    EndKm = 16810,
                    TimePrice = 5,
                    KmPrice = 20,
                    CarId = 16,
                    CustomerId = 16
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 17, 9, 0, 0),
                    EndTime = new DateTime(2026, 10, 17, 15, 0, 0),
                    StartKm = 35400,
                    EndKm = 35650,
                    TimePrice = 10,
                    KmPrice = 32,
                    CarId = 17,
                    CustomerId = 17
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 18, 10, 0, 0),
                    EndTime = new DateTime(2026, 10, 18, 14, 0, 0),
                    StartKm = 12500,
                    EndKm = 12700,
                    TimePrice = 13,
                    KmPrice = 35,
                    CarId = 18,
                    CustomerId = 18
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 19, 8, 0, 0),
                    EndTime = new DateTime(2026, 10, 19, 12, 0, 0),
                    StartKm = 48200,
                    EndKm = 48400,
                    TimePrice = 25,
                    KmPrice = 70,
                    CarId = 19,
                    CustomerId = 19
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 20, 12, 0, 0),
                    EndTime = new DateTime(2026, 10, 20, 17, 0, 0),
                    StartKm = 29800,
                    EndKm = 30000,
                    TimePrice = 14,
                    KmPrice = 40,
                    CarId = 20,
                    CustomerId = 20
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 21, 9, 0, 0),
                    EndTime = new DateTime(2026, 10, 21, 11, 0, 0),
                    StartKm = 7800,
                    EndKm = 7870,
                    TimePrice = 4,
                    KmPrice = 16,
                    CarId = 21,
                    CustomerId = 21
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 22, 10, 0, 0),
                    EndTime = new DateTime(2026, 10, 22, 16, 0, 0),
                    StartKm = 36500,
                    EndKm = 36800,
                    TimePrice = 18,
                    KmPrice = 50,
                    CarId = 22,
                    CustomerId = 22
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 23, 8, 0, 0),
                    EndTime = new DateTime(2026, 10, 23, 13, 0, 0),
                    StartKm = 52800,
                    EndKm = 53050,
                    TimePrice = 22,
                    KmPrice = 65,
                    CarId = 23,
                    CustomerId = 23
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 24, 9, 0, 0),
                    EndTime = new DateTime(2026, 10, 24, 14, 0, 0),
                    StartKm = 24700,
                    EndKm = 24900,
                    TimePrice = 9,
                    KmPrice = 30,
                    CarId = 24,
                    CustomerId = 24
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 25, 11, 0, 0),
                    EndTime = new DateTime(2026, 10, 25, 14, 0, 0),
                    StartKm = 11200,
                    EndKm = 11300,
                    TimePrice = 5,
                    KmPrice = 20,
                    CarId = 25,
                    CustomerId = 25
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 26, 10, 0, 0),
                    EndTime = new DateTime(2026, 10, 26, 15, 0, 0),
                    StartKm = 21800,
                    EndKm = 22100,
                    TimePrice = 20,
                    KmPrice = 60,
                    CarId = 26,
                    CustomerId = 26
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 27, 9, 0, 0),
                    EndTime = new DateTime(2026, 10, 27, 13, 0, 0),
                    StartKm = 38600,
                    EndKm = 38800,
                    TimePrice = 16,
                    KmPrice = 45,
                    CarId = 27,
                    CustomerId = 27
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 28, 8, 0, 0),
                    EndTime = new DateTime(2026, 10, 28, 12, 0, 0),
                    StartKm = 27500,
                    EndKm = 27700,
                    TimePrice = 15,
                    KmPrice = 42,
                    CarId = 28,
                    CustomerId = 28
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 29, 12, 0, 0),
                    EndTime = new DateTime(2026, 10, 29, 15, 0, 0),
                    StartKm = 9200,
                    EndKm = 9310,
                    TimePrice = 7,
                    KmPrice = 24,
                    CarId = 29,
                    CustomerId = 29
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 30, 10, 0, 0),
                    EndTime = new DateTime(2026, 10, 30, 13, 0, 0),
                    StartKm = 18600,
                    EndKm = 18750,
                    TimePrice = 6,
                    KmPrice = 23,
                    CarId = 30,
                    CustomerId = 30
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 10, 31, 9, 0, 0),
                    EndTime = new DateTime(2026, 10, 31, 14, 0, 0),
                    StartKm = 32100,
                    EndKm = 32350,
                    TimePrice = 12,
                    KmPrice = 36,
                    CarId = 31,
                    CustomerId = 31
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 11, 1, 8, 0, 0),
                    EndTime = new DateTime(2026, 11, 1, 12, 0, 0),
                    StartKm = 14500,
                    EndKm = 14700,
                    TimePrice = 12,
                    KmPrice = 34,
                    CarId = 32,
                    CustomerId = 32
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 11, 2, 10, 0, 0),
                    EndTime = new DateTime(2026, 11, 2, 15, 0, 0),
                    StartKm = 19600,
                    EndKm = 19850,
                    TimePrice = 14,
                    KmPrice = 38,
                    CarId = 33,
                    CustomerId = 33
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 11, 3, 9, 0, 0),
                    EndTime = new DateTime(2026, 11, 3, 13, 0, 0),
                    StartKm = 35200,
                    EndKm = 35400,
                    TimePrice = 17,
                    KmPrice = 48,
                    CarId = 34,
                    CustomerId = 34
                },
                new Reservation
                {
                    StartTime = new DateTime(2026, 11, 4, 8, 0, 0),
                    EndTime = new DateTime(2026, 11, 4, 12, 0, 0),
                    StartKm = 5200,
                    EndKm = 5400,
                    TimePrice = 25,
                    KmPrice = 65,
                    CarId = 35,
                    CustomerId = 35
                }
            };
        }
        public static void SeedInvoices(ApplicationDbContext context)
        {

        }
        public static void SeedInvoiceLines(ApplicationDbContext context)
        {

        }
    }
}
