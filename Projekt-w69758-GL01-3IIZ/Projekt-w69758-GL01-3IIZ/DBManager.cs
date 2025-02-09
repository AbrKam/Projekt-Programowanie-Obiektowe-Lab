using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_w69758_GL01_3IIZ
{
    internal class DBManager
    {
		private readonly string _connectionString = "Data Source=projekt_db.db";

        public DBManager()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @" 
				CREATE TABLE ""Wlasciciele"" (
					""Id"" INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
					""Imie"" NVARCHAR(50),
					""Nazwisko"" NVARCHAR(50),
					""NumerTelefonu"" NVARCHAR(50) UNIQUE,
					""AdresEmail"" NVARCHAR(50) UNIQUE
				);

				CREATE TABLE ""Weterynarze"" (
					""Id"" INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
					""Imie"" NVARCHAR(50),
					""Nazwisko"" NVARCHAR(50),
					""NumerTelefonu"" NVARCHAR(50) UNIQUE,
					""AdresEmail"" NVARCHAR(50) UNIQUE,
					""Specjalizacja"" NVARCHAR(50)
				);

				CREATE TABLE ""Zwierzeta"" (
					""Id"" INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
					""Imie"" NVARCHAR(50),
					""Gatunek"" NVARCHAR(50),
					""Rasa"" NVARCHAR(50),
					""Wiek"" INT CHECK(""Wiek"" >= 0),
					""IdWlasciciela"" INT NOT NULL,
					FOREIGN KEY(""IdWlasciciela"") REFERENCES ""Wlasciciele""(""Id"")
				);

				CREATE TABLE ""Wizyty"" (
					""Id"" INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
					""Cel"" NVARCHAR(50),
					""Opis"" NVARCHAR(200),
					""DataWizyty"" DATETIME,
					""IdWeterynarza"" INT NOT NULL,
					""IdZwierzecia"" INT NOT NULL,
					FOREIGN KEY(""IdWeterynarza"") REFERENCES ""Weterynarze""(""Id""),
					FOREIGN KEY(""IdZwierzecia"") REFERENCES ""Zwierzeta""(""Id"")
				);

				CREATE TABLE ""Platnosci"" (
					""Id"" INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
					""IdWizyty"" INT NOT NULL,
					""Metoda"" NVARCHAR(25),
					""Kwota"" DECIMAL(8,2) CHECK(""Kwota"" >= 0),
					""DataPlatnosci"" DATETIME,
					""Faktura"" BIT,
					FOREIGN KEY(""IdWizyty"") REFERENCES ""Wizyty""(""Id"")
				);

				CREATE TABLE ""Zabiegi"" (
					""Id"" INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
					""NazwaZabiegu"" NVARCHAR(50),
					""Opis"" NVARCHAR(200),
					""CzasTrwania"" TIME,
					""Cena"" DECIMAL(8,2) CHECK(""Cena"" >= 0)
				);

				CREATE TABLE ""WizytyZabiegi"" (
					""Id"" INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
					""IdWizyty"" INT NOT NULL,
					""IdZabiegu"" INT NOT NULL,
					""StatusWykonania"" BIT,
					FOREIGN KEY(""IdWizyty"") REFERENCES ""Wizyty""(""Id""),
					FOREIGN KEY(""IdZabiegu"") REFERENCES ""Zabiegi""(""Id"")

				);

                ";
                command.ExecuteNonQuery();

                #region snippet_Parameter 
                command.CommandText =
                @" 
                   
				INSERT INTO ""Wlasciciele"" (""Imie"", ""Nazwisko"", ""NumerTelefonu"", ""AdresEmail"") VALUES
				('Anna', 'Kowalska', '123456789', 'kowalska.ann45@wp.pl'),
				('Jan', 'Motyka', '987654321', 'motyka6john@gmail.com'),
				('Maria', 'Marian', '456789123', 'marianm12@o2.pl'),
				('Piotr', 'Petarda', '321654987', 'petardapit3r@hotmail.com'),
				('Ewa', 'Lipa', '654321987', 'lipaewcia888@gmail.com'),
				('Damian', 'Dobromir', '789123456', 'd0br0mir.d3mn@gmail.com'),
				('Kazimierz', 'Dolny', '147258369', 'dolnyk4zik123@wp.pl');

				INSERT INTO ""Weterynarze"" (""Imie"", ""Nazwisko"", ""NumerTelefonu"", ""AdresEmail"", ""Specjalizacja"") VALUES
				('Tomasz', 'Niecik', '123123123', 'tomasz.niecik@superprzychodniavet.pl', 'Chirurgia'),
				('Anna', 'Jantar', '456456456', 'anna.jantar@superprzychodniavet.pl', 'Dermatologia'),
				('Krzysztof', 'Krawczyk', '789789789', 'krzysztof.krawczyk@superprzychodniavet.pl', 'Ortopedia'),
				('Janusz', 'Laskowski', '321321321', 'janusz.laskowski@superprzychodniavet.pl', 'Stomatologia'),
				('Zbigniew', 'Wodecki', '654654654', 'zbigniew.wodecki@superprzychodniavet.pl', 'Kardiologia'),
				('Marek', 'Grechuta', '987987987', 'marek.grechuta@superprzychodniavet.pl', 'Endokrynologia');

				INSERT INTO ""Zwierzeta"" (""Imie"", ""Gatunek"", ""Rasa"", ""Wiek"", ""IdWlasciciela"") VALUES
				('Lambada', 'Pies', 'Kundel', 5, 1),
				('Kicia', 'Kot', 'Perski', 3, 2),
				('Lili', 'Pies', 'Pinczer miniaturowy', 7, 3),
				('Puszek', 'Kot', 'Syjamski', 4, 4),
				('Brylka', 'Pies', 'Kundel', 2, 5),
				('Feliks', 'Kot', 'Brytyjski', 1, 6),
				('Louis Jr', 'Pies', 'Kundel', 2, 5),
				('Panczita', 'Pies', 'Chihuahua', 3, 7);

				INSERT INTO ""Wizyty"" (""Cel"", ""Opis"", ""DataWizyty"", ""IdWeterynarza"", ""IdZwierzecia"") VALUES
				('Szczepienie', 'Szczepienie przeciwko wsciekliznie', '2024-01-15 10:37:22', 1, 1),
				('Kontrola', 'Kontrola stanu zdrowia', '2024-01-20 12:13:45', 2, 2),
				('Zabieg', 'Operacja usuniecia guza', '2024-02-05 09:27:08', 3, 3),
				('Stomatologia', 'Usuniecie kamienia nazebnego', '2024-02-10 14:42:16', 4, 4),
				('Konsultacja', 'Konsultacja kardiologiczna', '2024-03-01 16:05:39', 5, 5),
				('Kontrola', 'Kontrola postepow leczenia', '2024-03-05 11:19:54', 1, 6);

				INSERT INTO ""Platnosci"" (""IdWizyty"", ""Metoda"", ""Kwota"", ""DataPlatnosci"", ""Faktura"") VALUES
				(1, 'Gotówka', 100.00, '2024-01-15 11:44:01', 1),
				(2, 'Karta', 200.00, '2024-01-20 12:35:55', 1),
				(3, 'Przelew', 500.00, '2024-02-05 11:10:07', 1),
				(4, 'Karta', 150.00, '2024-02-10 14:34:12', 0),
				(5, 'Gotówka', 250.00, '2024-03-01 16:37:21', 1),
				(6, 'Blik', 120.00, '2024-03-05 11:39:08', 0);

				INSERT INTO ""Zabiegi"" (""NazwaZabiegu"", ""Opis"", ""CzasTrwania"", ""Cena"") VALUES
				('Szczepienie', 'Podanie szczepionki', '00:32:07', 100.00),
				('Badanie krwi', 'Analiza laboratoryjna', '01:06:33', 149.99),
				('Usuniecie guza', 'Chirurgiczne usuniecie zmiany', '02:32:47', 500.00),
				('Stomatologia', 'Czyszczenie zebow', '01:08:08', 50.00),
				('Badanie kardiologiczne', 'EKG i echo serca', '01:02:17', 300.00);

				INSERT INTO ""WizytyZabiegi"" (""IdWizyty"", ""IdZabiegu"", ""StatusWykonania"") VALUES
				(1, 1, 1),
				(2, 2, 1),
				(3, 3, 1),
				(4, 4, 1),
				(5, 5, 1),
				(6, 2, 0);
				";
                #endregion
                command.ExecuteNonQuery();

            }
        }
    }
}
