--CREATE TABLE Owner (
--    OwnerID INT PRIMARY KEY IDENTITY,
--    FirstName VARCHAR(100),
--    LastName VARCHAR(100),
--    Phone VARCHAR(20),
--    Email VARCHAR(100),
--    AddressLine1 VARCHAR(200),
--    AddressLine2 VARCHAR(200),
--    City VARCHAR(100),
--    Postcode VARCHAR(20),
--    Country VARCHAR(100),
--    Notes TEXT,
--    DateCreated DATETIME DEFAULT GETDATE()
--);

BEGIN TRAN 


CREATE TABLE Owner (
    OwnerID INT PRIMARY KEY IDENTITY,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Phone VARCHAR(20),
    Email VARCHAR(100),
    AddressLine1 VARCHAR(200),
    AddressLine2 VARCHAR(200),
    City VARCHAR(100),
    Postcode VARCHAR(20),
    Country VARCHAR(100),
    Notes TEXT,
    DateCreated DATETIME DEFAULT GETDATE()
);


CREATE TABLE Animal (
    AnimalID INT PRIMARY KEY IDENTITY,
    OwnerID INT NOT NULL,   
    Name VARCHAR(100),
    Species VARCHAR(50),
    Breed VARCHAR(100),
    Gender VARCHAR(20),
    DateOfBirth DATE,
    Color VARCHAR(50),
    MicrochipNumber VARCHAR(50),
    WeightKg DECIMAL(5,2),
    DateRegistered DATETIME DEFAULT GETDATE(),
    Status VARCHAR(20),
    FOREIGN KEY (OwnerID) REFERENCES Owner(OwnerID)
);

CREATE TABLE Visits (
    VisitID INT PRIMARY KEY IDENTITY,
    MedicalNoteID INT,
    AnimalID INT NOT NULL,
    VetID INT,
    VisitDate DATETIME NOT NULL,
    ReasonForVisit TEXT,
    History TEXT,
    Examination TEXT,
    DiagnosisID INT,
    TreatmentNotes TEXT,
    FollowUpDate DATE,
    FOREIGN KEY (AnimalID) REFERENCES Animal(AnimalID)
    -- Add foreign keys for VetID and DiagnosisID if those tables exist
);

CREATE TABLE MedicalNotes (
    NoteID INT PRIMARY KEY IDENTITY,
    VisitID INT NOT NULL,
    DateWritten DATETIME NOT NULL,
    EnteredBy INT NOT NULL,
    NoteType VARCHAR(50), -- e.g. Progress, Discharge
    NoteText TEXT,
    FOREIGN KEY (VisitID) REFERENCES Visits(VisitID)
);
CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY IDENTITY,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Phone VARCHAR(20),
    Email VARCHAR(100),
    Title VARCHAR(100),
    Specialty VARCHAR(100),
    Position VARCHAR (100),
    LicenseNumber VARCHAR(50)
);

CREATE TABLE Diagnosis (
    DiagnosisID INT PRIMARY KEY IDENTITY,
    Name VARCHAR(150) NOT NULL,
    Description TEXT,
    ICDCode VARCHAR(20)
);


CREATE TABLE Organization (
     OrganizationID INT PRIMARY KEY IDENTITY,
     OrganizationName VARCHAR(100),
     OrgType VARCHAR(100),
     AddressLine1 VARCHAR(200),
     AddressLine2 VARCHAR(200),
     City VARCHAR(100),
     Postcode VARCHAR(20),
     Country VARCHAR(100),
);

CREATE TABLE COUNTRIES (
    CountryID INT PRIMARY KEY IDENTITY,
    Name VARCHAR(100)
);

COMMIT

select * from Animal


-- Insert into COUNTRIES
INSERT INTO COUNTRIES (Name) VALUES 
('United Kingdom'),
('United States'),
('Canada');

-- Insert into Owner
INSERT INTO Owner (FirstName, LastName, Phone, Email, AddressLine1, AddressLine2, City, Postcode, Country, Notes)
VALUES 
('Sarah', 'Evans', '+447911123456', 'sarah.evans@example.com', '12 Oak Street', '', 'Manchester', 'M1 1AA', 'United Kingdom', 'Loves cats'),
('James', 'Anderson', '+447912654321', 'james.anderson@example.com', '34 Pine Avenue', 'Flat 2B', 'Leeds', 'LS1 2XY', 'United Kingdom', 'Breeds Labradors');

-- Insert into Animal
INSERT INTO Animal (OwnerID, Name, Species, Breed, Gender, DateOfBirth, Color, MicrochipNumber, WeightKg, Status)
VALUES
(1, 'Whiskers', 'Cat', 'British Shorthair', 'Female', '2020-03-14', 'Grey', '1234567890ABC', 4.5, 'Active'),
(2, 'Rex', 'Dog', 'Labrador Retriever', 'Male', '2019-08-21', 'Black', '9876543210DEF', 29.7, 'Active');

-- Insert into Employee
INSERT INTO Employee (FirstName, LastName, Phone, Email, Title, Specialty, Position, LicenseNumber)
VALUES
('Dr. Emma', 'Green', '+447900000001', 'emma.green@vetclinic.com', 'Veterinarian', 'Small Animals', 'Senior Vet', 'VET12345'),
('Dr. Liam', 'Brown', '+447900000002', 'liam.brown@vetclinic.com', 'Veterinarian', 'Surgery', 'Associate Vet', 'VET67890');

-- Insert into Diagnosis
INSERT INTO Diagnosis (Name, Description, ICDCode)
VALUES
('Otitis externa', 'Inflammation of the outer ear canal', 'H60.3'),
('Canine Parvovirus', 'Highly contagious viral disease in dogs', 'A08.0');

-- Insert into Visits
INSERT INTO Visits (MedicalNoteID, AnimalID, VetID, VisitDate, ReasonForVisit, History, Examination, DiagnosisID, TreatmentNotes, FollowUpDate)
VALUES
(NULL, 1, 1, '2025-07-20 10:30', 'Regular check-up', 'No known issues', 'Healthy, slight tartar buildup on molars', 1, 'Recommended dental cleaning', '2025-08-01'),
(NULL, 2, 2, '2025-07-21 15:00', 'Vomiting and lethargy', 'Started yesterday after eating unknown food', 'Dehydrated, temp elevated', 2, 'IV fluids, antiemetics given', '2025-07-28');

-- Insert into MedicalNotes
INSERT INTO MedicalNotes (VisitID, DateWritten, EnteredBy, NoteType, NoteText)
VALUES
(1, '2025-07-20 11:00', 1, 'Progress', 'Dental tartar noted. Monitor diet and schedule cleaning.'),
(2, '2025-07-21 15:45', 2, 'Discharge', 'Parvovirus suspected. Treatment started. Owner advised to monitor closely.');

-- Insert into Organization
INSERT INTO Organization (OrganizationName, OrgType, AddressLine1, AddressLine2, City, Postcode, Country)
VALUES
('Paws and Claws Vet Clinic', 'Veterinary Clinic', '89 Vet Street', '', 'Liverpool', 'L1 3AB', 'United Kingdom'),
('Animal Rescue League', 'Charity', '55 Haven Road', 'Unit 7', 'Birmingham', 'B1 1AA', 'United Kingdom');
