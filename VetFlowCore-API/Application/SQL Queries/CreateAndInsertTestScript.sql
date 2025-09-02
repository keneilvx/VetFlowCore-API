BEGIN TRAN

-- Countries Lookup
CREATE TABLE Countries (
    CountryID INT PRIMARY KEY IDENTITY,
    Name VARCHAR(100) NOT NULL UNIQUE
);

-- Organizations (Clinics)
CREATE TABLE Organization (
    OrganizationID INT PRIMARY KEY IDENTITY,
    OrganizationName VARCHAR(100) NOT NULL,
    OrgType VARCHAR(100),
    AddressLine1 VARCHAR(200),
    AddressLine2 VARCHAR(200),
    City VARCHAR(100),
    Postcode VARCHAR(20),
    CountryID INT,
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID)
);


-- Owners
CREATE TABLE Owner (
    OwnerID INT PRIMARY KEY IDENTITY,
    OrganizationID INT NOT NULL,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Phone VARCHAR(20),
    Email VARCHAR(100),
    AddressLine1 VARCHAR(200),
    AddressLine2 VARCHAR(200),
    City VARCHAR(100),
    Postcode VARCHAR(20),
    CountryID INT,
    Notes TEXT,
    DateCreated DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (OrganizationID) REFERENCES Organization(OrganizationID),
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID)
);

-- Animals
CREATE TABLE Animal (
    AnimalID INT PRIMARY KEY IDENTITY,
    OwnerID INT NOT NULL,
    OrganizationID INT NOT NULL,
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
    FOREIGN KEY (OwnerID) REFERENCES Owner(OwnerID),
    FOREIGN KEY (OrganizationID) REFERENCES Organization(OrganizationID)
);

-- Employees
CREATE TABLE Employee (
    EmployeeID INT PRIMARY KEY IDENTITY,
    OrganizationID INT NOT NULL,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Phone VARCHAR(20),
    Email VARCHAR(100),
    Title VARCHAR(100),
    Specialty VARCHAR(100),
    Position VARCHAR(100),
    LicenseNumber VARCHAR(50),
    FOREIGN KEY (OrganizationID) REFERENCES Organization(OrganizationID)
);

-- Diagnosis Lookup
CREATE TABLE Diagnosis (
    DiagnosisID INT PRIMARY KEY IDENTITY,
    Name VARCHAR(150) NOT NULL,
    Description TEXT,
    ICDCode VARCHAR(20)
);

-- Visits
CREATE TABLE Visits (
    VisitID INT PRIMARY KEY IDENTITY,
    AnimalID INT NOT NULL,
    VetID INT, -- optional foreign key to Employee
    VisitDate DATETIME NOT NULL,
    ReasonForVisit TEXT,
    History TEXT,
    Examination TEXT,
    DiagnosisID INT,
    TreatmentNotes TEXT,
    FollowUpDate DATE,
    FOREIGN KEY (AnimalID) REFERENCES Animal(AnimalID),
    FOREIGN KEY (VetID) REFERENCES Employee(EmployeeID),
    FOREIGN KEY (DiagnosisID) REFERENCES Diagnosis(DiagnosisID)
);

-- Medical Notes
CREATE TABLE MedicalNotes (
    NoteID INT PRIMARY KEY IDENTITY,
    VisitID INT NOT NULL,
    DateWritten DATETIME NOT NULL,
    EnteredBy INT NOT NULL, -- FK to Employee
    NoteType VARCHAR(50),
    NoteText TEXT,
    FOREIGN KEY (VisitID) REFERENCES Visits(VisitID),
    FOREIGN KEY (EnteredBy) REFERENCES Employee(EmployeeID)
);

COMMIT