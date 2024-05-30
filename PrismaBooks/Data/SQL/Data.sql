----------### BOOKS MAIN TABLE ###---------- 
-----## Books Data ##-----
INSERT INTO Books (Title, Pages, Language, PublicationDate, Description, Status, IdAuthor, IdPublisher) VALUES 
('The Great Gatsby', 218, 'English', '1925-04-10', 'A novel by F. Scott Fitzgerald', true, 1, 1),
('To Kill a Mockingbird', 281, 'English', '1960-07-11', 'A novel by Harper Lee', true, 2, 2),
('1984', 328, 'English', '1949-06-08', 'A dystopian novel by George Orwell', true, 3, 3),
('Pride and Prejudice', 279, 'English', '1813-01-28', 'A romantic novel by Jane Austen', true, 4, 4),
('The Catcher in the Rye', 224, 'English', '1951-07-16', 'A novel by J. D. Salinger', true, 5, 5);


-----## Authors Data ##-----
INSERT INTO Authors (Name, LastName, Email, Status, Nationality) VALUES 
('F. Scott', 'Fitzgerald', 'fscott@example.com', true, 'American'),
('Harper', 'Lee', 'harperlee@example.com', true, 'American'),
('George', 'Orwell', 'georgeorwell@example.com', true, 'British'),
('Jane', 'Austen', 'janeausten@example.com', true, 'British'),
('J. D.', 'Salinger', 'jdsalinger@example.com', true, 'American');

-----## Publishers Data ##-----
INSERT INTO Publishers (Name, Address, Phone, Status, Email) VALUES 
('Random House', '123 Random St, New York, NY', '+1234567890', true, 'info@randomhouse.com'),
('Penguin Books', '456 Penguin Ave, London, UK', '+440123456789', true, 'info@penguinbooks.com'),
('Houghton Mifflin Harcourt', '789 Houghton St, Boston, MA', '+1234567890', true, 'info@hmhco.com'),
('Oxford University Press', '10 Oxford Lane, Oxford, UK', '+440123456789', true, 'info@oup.com'),
('Simon & Schuster', '321 Simon St, New York, NY', '+1234567890', true, 'info@simonandschuster.com');
