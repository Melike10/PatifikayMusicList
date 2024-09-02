## Patifikay Music List Application
# Overview
The Patifikay Music List application is designed to manage a list of musicians, allowing users to filter, group, and sort them based on various criteria. This application is part of the Patika Dev Week 7 LINQ practices, focusing on filtering and manipulating collections using LINQ in C#.

# Features
The application provides the following features:

Filter Musicians by Name: Displays musicians whose names start with the letter 'S'.
Filter by Album Sales: Lists musicians who have sold more than 10 million albums.
Filter by Debut Year: Shows musicians who debuted before the year 2000 and are pop musicians.
Top Album Sales: Identifies the musician with the highest album sales.
Newest Debut: Displays the musician who has the most recent debut.
Oldest Debut: Displays the musician who has the earliest debut year.
## Class Descriptions
Musician Class
The Musician class represents a musician with the following properties:

Name: The name of the musician.
MusicType: The genre of music they perform.
Year: The year they made their debut.
SalesAlbum: The total number of albums sold.
The class also includes a static method Print that takes a list of musicians and prints their details in a formatted way.

## Program Class
The Program class is the main entry point of the application, containing the Main method. It performs the following operations:

Creates a list of Musician objects.
Filters and displays musicians based on various criteria such as name, album sales, and debut year.
Sorts and identifies musicians with the highest and lowest debut years, as well as the highest album sales.
## Example Usage
```csharp

// Example usage of filtering musicians whose names start with 'S'
Console.WriteLine("--- Musicians Whose Names Start With 'S' ---- ");
var nameStartsWithS = musicians.Where(m => m.Name.StartsWith("S")).ToList();
Musician.Print(nameStartsWithS);
```

This example demonstrates how the application uses LINQ to filter a list of musicians based on specific criteria and then prints the results using the Musician.Print method.

## Technologies Used
Language: C#
Framework: .NET
LINQ: For querying and manipulating collections
This project is a part of Patika Dev Week 7 LINQ practices, helping developers learn how to effectively use LINQ to work with collections in C#.
