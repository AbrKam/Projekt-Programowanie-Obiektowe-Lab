using Projekt_w69758_GL01_3IIZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w69758_GL01_3IIZ.DbFunctionality
{
    static class DbInitializer
    {
        public static void Initialize(DBManager context)
        {

            context.Database.EnsureCreated();

            if (!context.Owners.Any())
            {
                context.Owners.AddRange(
                    new Owner { FirstName = "Anna", LastName = "Kowalska", TelephoneNumber = "123456789", Email = "kowalska.ann45@wp.pl" },
                    new Owner { FirstName = "Jan", LastName = "Motyka", TelephoneNumber = "987654321", Email = "motyka6john@gmail.com" },
                    new Owner { FirstName = "Maria", LastName = "Marian", TelephoneNumber = "456789123", Email = "marianm12@o2.pl" },
                    new Owner { FirstName = "Piotr", LastName = "Petarda", TelephoneNumber = "321654987", Email = "petardapit3r@hotmail.com" },
                    new Owner { FirstName = "Ewa", LastName = "Lipa", TelephoneNumber = "654321987", Email = "lipaewcia888@gmail.com" },
                    new Owner { FirstName = "Damian", LastName = "Dobromir", TelephoneNumber = "789123456", Email = "d0br0mir.d3mn@gmail.com" },
                    new Owner { FirstName = "Kazimierz", LastName = "Dolny", TelephoneNumber = "147258369", Email = "dolnyk4zik123@wp.pl" }
                );
                context.SaveChanges();
            }

            if (!context.Vets.Any())
            {
                context.Vets.AddRange(
                    new Vet { FirstName = "Tomasz", LastName = "Niecik", TelephoneNumber = "123123123", Email = "tomasz.niecik@superprzychodniavet.pl", Specialization = "Chirurgia" },
                    new Vet { FirstName = "Anna", LastName = "Jantar", TelephoneNumber = "456456456", Email = "anna.jantar@superprzychodniavet.pl", Specialization = "Dermatologia" },
                    new Vet { FirstName = "Krzysztof", LastName = "Krawczyk", TelephoneNumber = "789789789", Email = "krzysztof.krawczyk@superprzychodniavet.pl", Specialization = "Ortopedia" },
                    new Vet { FirstName = "Janusz", LastName = "Laskowski", TelephoneNumber = "321321321", Email = "janusz.laskowski@superprzychodniavet.pl", Specialization = "Stomatologia" },
                    new Vet { FirstName = "Zbigniew", LastName = "Wodecki", TelephoneNumber = "654654654", Email = "zbigniew.wodecki@superprzychodniavet.pl", Specialization = "Kardiologia" },
                    new Vet { FirstName = "Marek", LastName = "Grechuta", TelephoneNumber = "987987987", Email = "marek.grechuta@superprzychodniavet.pl", Specialization = "Endokrynologia" }
                );
                context.SaveChanges();
            }

            if (!context.Animals.Any())
            {
                context.Animals.AddRange(
                    new Animal { Name = "Lambada", Species = "Pies", Breed = "Kundel", Age = 5, OwnerId = 1 },
                    new Animal { Name = "Kicia", Species = "Kot", Breed = "Perski", Age = 3, OwnerId = 2 },
                    new Animal { Name = "Lili", Species = "Pies", Breed = "Pinczer miniaturowy", Age = 7, OwnerId = 3 },
                    new Animal { Name = "Puszek", Species = "Kot", Breed = "Syjamski", Age = 4, OwnerId = 4 },
                    new Animal { Name = "Brylka", Species = "Pies", Breed = "Kundel", Age = 2, OwnerId = 5 },
                    new Animal { Name = "Feliks", Species = "Kot", Breed = "Brytyjski", Age = 1, OwnerId = 6 },
                    new Animal { Name = "Louis Jr", Species = "Pies", Breed = "Kundel", Age = 2, OwnerId = 5 },
                    new Animal { Name = "Panczita", Species = "Pies", Breed = "Chihuahua", Age = 3, OwnerId = 7 }
                );
                context.SaveChanges();
            }

            if (!context.Visits.Any())
            {
                context.Visits.AddRange(
                    new Visit { Purpose = "Szczepienie", Description = "Szczepienie przeciwko wsciekliznie", Data = DateTime.Parse("2024-01-15 10:37:22"), VetId = 1, AnimalId = 1 },
                    new Visit { Purpose = "Kontrola", Description = "Kontrola stanu zdrowia", Data = DateTime.Parse("2024-01-20 12:13:45"), VetId = 2, AnimalId = 2 },
                    new Visit { Purpose = "Zabieg", Description = "Operacja usuniecia guza", Data = DateTime.Parse("2024-02-05 09:27:08"), VetId = 3, AnimalId = 3 },
                    new Visit { Purpose = "Stomatologia", Description = "Usuniecie kamienia nazebnego", Data = DateTime.Parse("2024-02-10 14:42:16"), VetId = 4, AnimalId = 4 },
                    new Visit { Purpose = "Konsultacja", Description = "Konsultacja kardiologiczna", Data = DateTime.Parse("2024-03-01 16:05:39"), VetId = 5, AnimalId = 5 },
                    new Visit { Purpose = "Kontrola", Description = "Kontrola postepow leczenia", Data = DateTime.Parse("2024-03-05 11:19:54"), VetId = 1, AnimalId = 6 }
                );
                context.SaveChanges();
            }

            if (!context.Procedures.Any())
            {
                context.Procedures.AddRange(
                    new Procedure { Purpose = "Szczepienie", Description = "Podanie szczepionki", TimeTaken = 32, Cost = 100.00m },
                    new Procedure { Purpose = "Badanie krwi", Description = "Analiza laboratoryjna", TimeTaken = 66, Cost = 149.99m },
                    new Procedure { Purpose = "Usuniecie guza", Description = "Chirurgiczne usuniecie zmiany", TimeTaken = 152, Cost = 500.00m },
                    new Procedure { Purpose = "Stomatologia", Description = "Czyszczenie zebow", TimeTaken = 68, Cost = 50.00m },
                    new Procedure { Purpose = "Badanie kardiologiczne", Description = "EKG i echo serca", TimeTaken = 62, Cost = 300.00m }
                );
                context.SaveChanges();
            }

            if (!context.VisitsToProcedures.Any())
            {
                context.VisitsToProcedures.AddRange(
                    new VisitsProcedures { VisitId = 1, ProcedureId = 1, IsDone = true },
                    new VisitsProcedures { VisitId = 2, ProcedureId = 2, IsDone = true },
                    new VisitsProcedures { VisitId = 3, ProcedureId = 3, IsDone = true },
                    new VisitsProcedures { VisitId = 4, ProcedureId = 4, IsDone = true },
                    new VisitsProcedures { VisitId = 5, ProcedureId = 5, IsDone = true },
                    new VisitsProcedures { VisitId = 6, ProcedureId = 2, IsDone = false }
                );
                context.SaveChanges();
            }

            if (!context.Payments.Any())
            {
                context.Payments.AddRange(
                    new Payment { VisitId = 1, PaymentMethod = "Gotówka", Cost = 100.00m, Date = DateTime.Parse("2024-01-15 11:44:01"), Invoice = true },
                    new Payment { VisitId = 2, PaymentMethod = "Karta", Cost = 200.00m, Date = DateTime.Parse("2024-01-20 12:35:55"), Invoice = true },
                    new Payment { VisitId = 3, PaymentMethod = "Przelew", Cost = 500.00m, Date = DateTime.Parse("2024-02-05 11:10:07"), Invoice = true },
                    new Payment { VisitId = 4, PaymentMethod = "Karta", Cost = 150.00m, Date = DateTime.Parse("2024-02-10 14:34:12"), Invoice = false },
                    new Payment { VisitId = 5, PaymentMethod = "Gotówka", Cost = 250.00m, Date = DateTime.Parse("2024-03-01 16:37:21"), Invoice = true },
                    new Payment { VisitId = 6, PaymentMethod = "Blik", Cost = 120.00m, Date = DateTime.Parse("2024-03-05 11:39:08"), Invoice = false }
                );
                context.SaveChanges();
            }
        }
    }
}
