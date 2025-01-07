create database Final
use Final
CREATE TABLE Questions (
    id INT IDENTITY(1,1) PRIMARY KEY,
    QuestionText NVARCHAR(255),
    CorrectAnswer NVARCHAR(50),
    AssignedMarks INT
);
INSERT INTO Questions (QuestionText, CorrectAnswer, AssignedMarks) VALUES
('What is the capital of France?', 'Paris', 1),
('What is the largest planet in our solar system?', 'Jupiter', 1),
('What is H2O commonly known as?', 'Water', 1),
('Who wrote "Romeo and Juliet"?', 'William Shakespeare', 1);
SELECT * FROM Questions;