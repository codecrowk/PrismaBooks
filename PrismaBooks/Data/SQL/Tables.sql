-- Active: 1716928323111@@127.0.0.1@3306@baltlfw40qnhjbk9o36l

----> Status: Reference if enable or disabled

----------### BOOKS MAIN TABLE ###---------- 
-----## Books Table ##-----
CREATE TABLE Books (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Title VARCHAR(255) UNIQUE,
  Pages INT(10),
  Language VARCHAR(125),
  PublicationDate DATE,
  Description TEXT,
  Status BOOLEAN,
  IdAuthor INT,
  IdPublisher INT
);

-----## Authors Table ##-----
CREATE TABLE Authors (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Name VARCHAR(124) UNIQUE,
  LastName VARCHAR(44),
  Email VARCHAR(124),
  Nationality VARCHAR(124)
  Status BOOLEAN,
);

-----## Publishers Table ##-----
CREATE TABLE Publishers (
  Id INT AUTO_INCREMENT PRIMARY KEY,
  Name VARCHAR(80) UNIQUE,
  Address VARCHAR(125),
  Phone VARCHAR(35),
  Email VARCHAR(125) UNIQUE
  Status BOOLEAN,
);