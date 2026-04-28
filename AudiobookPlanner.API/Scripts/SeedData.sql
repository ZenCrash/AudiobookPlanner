USE [Audiobook_Planner];
GO

INSERT INTO [Genres] ([name]) VALUES 
('Action'),
('Adventure'),
('Comedy'),
('Drama'),
('Fantasy'),
('Science Fiction'),
('Horror'),
('Thriller'),
('Romance'),
('Mystery'),
('Crime'),
('Animation'),
('Family'),
('Documentary'),
('War'),
('Western'),
('Musical'),
('History'),
('Biography'),
('Sport');
GO

INSERT INTO [Languages] ([LanguageName]) VALUES 
('Danish'),
('English'),
('French'),
('German'),
('Spanish'),
('Italian');
GO

INSERT INTO [Authors] ([Name]) VALUES 
('Vanessa Ball'),
('Kayleigh Haley'),
('Raina Weaver'),
('Clare Lim'),
('Saoirse Newton'),
('Madilyn Rose');
GO

INSERT INTO [Narrators] ([Name]) VALUES 
('Hayden Orr'),
('Messiah Mack'),
('Zayd Dennis'),
('Israel Silva'),
('John Simpson'),
('Joe Frazier');
GO

INSERT INTO [Series] ([Title]) VALUES 
('The Lord of the Rings');
GO

INSERT INTO [Audiobooks] ([Title], [BookNo], [Description], [LengthInMinutes], [ReleaseDate], [PublisherId], [SeriesId]) VALUES 
('The Great Gatsby', 1, 'A novel about the American dream and the decadence of the 1920s.', 300, '2020-01-01', NULL, NULL),
('To Kill a Mockingbird', 1, 'A novel about racial injustice in the Deep South.', 400, '2019-05-15', NULL, NULL),
('1984', 1, 'A dystopian novel about totalitarianism and surveillance.', 350, '2018-10-10', NULL, NULL),
('Pride and Prejudice', 1, 'A classic romance novel about the manners and matrimonial machinations among the British gentry.', 450, '2017-03-20', NULL, NULL),
('The Hobbit', 1, 'A fantasy novel about the adventures of Bilbo Baggins in Middle-earth.', 500, '2016-07-30', NULL, 1),
('The Hobbit 2', 2, 'A fantasy novel about the adventures of Bilbo Baggins in Middle-earth.', 500, '2016-07-30', NULL, 1);
GO

--Bridge Tables

INSERT INTO [AudiobookGenres] (AudiobookId, GenreId) VALUES 
(1, 1),
(1, 3),
(2, 4),
(2, 2),
(3, 6),
(3, 8),
(4, 9),
(4, 10),
(5, 20),
(5, 1),
(6, 15),
(6, 10);
GO

INSERT INTO [AudiobookLanguages] (AudiobookId, LanguageId) VALUES 
(1, 1),
(1, 2),
(2, 2),
(2, 3),
(3, 2),
(3, 4),
(4, 5),
(4, 6),
(5, 1),
(5, 2),
(6, 5),
(6, 2);
GO

INSERT INTO [AudiobookAuthors] (AudiobookId, AuthorId) VALUES 
(1, 1),
(2, 2),
(3, 3),
(3, 4),
(4, 4),
(5, 5),
(5, 3),
(6, 6);
GO

INSERT INTO [AudiobookNarrators] (AudiobookId, NarratorId) VALUES 
(1, 1),
(1, 2),
(2, 4),
(3, 5),
(3, 6),
(4, 3),
(5, 2),
(5, 4),
(6, 6);
GO