--Draft of Phoenix Theatre Database

------------------------------------
--Will not be able to create as is--
--Must be updated to create the DB--
------------------------------------

--Maybe name should be two colums
--look into Okta Auth0 for secure 
--	authentication and authorization
--Need to change the PK and FK for the TheatreFilms
--	and FilmShowings

--DROP TABLE PhoenixTheatre.Customer;
--DROP TABLE PhoenixTheatre.CustomerOrder;
--DROP TABLE PhoenixTheatre.TheatreFilms;
--DROP TABLE PhoenixTheatre.FilmShowings;
--DROP TABLE PhoenixTheatre.Employee;
--DROP SCHEMA PhoenixTheatre;

CREATE SCHEMA PhoenixTheatre;
GO
 
CREATE TABLE PhoenixTheatre.Customer
(
	CustomerId UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	CustomerName NVARCHAR(100) NOT NULL, 
	Username NVARCHAR(100) NOT NULL UNIQUE,
	UserPassword NVARCHAR(200) NOT NULL
);										

CREATE TABLE PhoenixTheatre.CustomerOrder
(
	OrderId UNIQUEIDENTIFIER PRIMARY KEY,
	CustomerId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES PhoenixTheatre.Customer(CustomerId) NOT NULL,
	Tickets INT NOT NULL,
	Quantity INT NOT NULL,
	TicketPrice MONEY NOT NULL
);

CREATE TABLE PhoenixTheatre.TheatreFilms
(
	FilmName NVARCHAR(200),
	FilmRating NVARCHAR(5) NOT NULL,
	Genre NVARCHAR(100),
	FilmDescription NVARCHAR(300) NOT NULL,
	PRIMARY KEY (FilmName, Genre)
);

CREATE TABLE PhoenixTheatre.FilmShowings
(
	FilmName NVARCHAR(200) FOREIGN KEY REFERENCES PhoenixTheatre.TheatreFilms(FilmName),
	ShowDate DATE,
	Showtime TIME,
	TicketsAvailable INT NOT NULL,
	PRIMARY KEY (FilmName, ShowDate, Showtime)
);

CREATE TABLE PhoenixTheatre.Employee
(
	EmployeeId UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	EmployeeName NVARCHAR(100) NOT NULL,
	Username NVARCHAR(100) NOT NULL UNIQUE,
	UserPassword NVARCHAR(200) NOT NULL,
	IsManager NVARCHAR(3) NOT NULL
);

INSERT INTO PhoenixTheatre.Employee
(
	EmployeeName,
	Username,
	UserPassword,
	IsManager
)
VALUES
	('Jane Doe', 'janed', 'p@ssword1', 'yes'),
	('Tim Johnson', 'tjohnson', 'p@ssword1', 'no'),
	('Sam Hall', 'shall', 'p@ssword1', 'no');

--A default customer
INSERT INTO PhoenixTheatre.Customer
(
	CustomerName,
	Username,
	UserPassword
)
VALUES
	('John Doe', 'jdoe','P@ssword!');

INSERT INTO PhoenixTheatre.TheatreFilms
(
	FilmName,
	FilmRating,
	Genre,
	FilmDescription
)
VALUES
	('Assassin With Wings', 'PG-13', 'Adventure', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.'),
	('Castle Without Hope', 'PG-13', 'Drama', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.'),
	('Paladins and Mages', 'PG', 'Fantasy', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.');

INSERT INTO PhoenixTheatre.FilmShowings
(
	FilmName,
	ShowDate,
	Showtime,
	TicketsAvailable
)
VALUES
	('Assassin With Wings', '2021-01-22', '12:00:00', 40),
	('Castle Without Hope', '2021-01-22', '12:00:00', 40),
	('Paladins and Mages', '2021-01-22', '12:00:00', 40);

SELECT * FROM PhoenixTheatre.Customer;
SELECT * FROM PhoenixTheatre.CustomerOrder;
SELECT * FROM PhoenixTheatre.TheatreFilms;
SELECT * FROM PhoenixTheatre.FilmShowings;
SELECT * FROM PhoenixTheatre.Employee;